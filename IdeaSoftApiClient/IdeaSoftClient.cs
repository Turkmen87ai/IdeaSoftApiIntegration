using IdeaSoftApiClient.Authentication;
using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;
using IdeaSoftApiClient.Models;
using IdeaSoftApiClient.Services;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient;

/// <summary>IdeaSoft Admin API için OAuth2/Bearer destekli .NET istemcisi.</summary>
public sealed class IdeaSoftClient : IDisposable
{
    private readonly ApiConfig _config;
    private readonly IAccessTokenProvider _tokenProvider;
    private readonly HttpClient _httpClient;
    private readonly bool _ownsHttpClient;
    private bool _disposed;

    public IdeaSoftClient(ApiConfig config, string accessToken, HttpClient? httpClient = null)
        : this(config, new StaticAccessTokenProvider(accessToken), httpClient)
    {
    }

    public IdeaSoftClient(ApiConfig config, IAccessTokenProvider tokenProvider, HttpClient? httpClient = null)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
        _config.Validate();
        _tokenProvider = tokenProvider ?? throw new ArgumentNullException(nameof(tokenProvider));
        _ownsHttpClient = httpClient is null;
        _httpClient = httpClient ?? new HttpClient();
        _httpClient.Timeout = config.Timeout;

        Products = Resource<Product>("products");
        Categories = Resource<Category>("categories");
        Orders = Resource<Order>("orders");
        Members = Resource<Member>("members");
        Brands = Resource<Brand>("brands");
        Pages = Resource<Page>("pages");
        Themes = Resource<Theme>("themes");
    }

    public AdminResourceClient<Product> Products { get; }
    public AdminResourceClient<Category> Categories { get; }
    public AdminResourceClient<Order> Orders { get; }
    public AdminResourceClient<Member> Members { get; }
    public AdminResourceClient<Brand> Brands { get; }
    public AdminResourceClient<Page> Pages { get; }
    public AdminResourceClient<Theme> Themes { get; }

    /// <summary>OpenAPI'deki herhangi bir standart kaynağa tipli erişim oluşturur.</summary>
    public AdminResourceClient<T> Resource<T>(string resource) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(resource);
        ValidateRelativePath(resource);
        return new AdminResourceClient<T>(this, resource);
    }

    /// <summary>OpenAPI'deki özel işlemler dahil tüm Admin API yollarını çağırır.</summary>
    /// <param name="method">HTTP metodu.</param>
    /// <param name="path">`admin-api/` öneki olmadan yol. Örnek: `products/42/change_category`.</param>
    /// <param name="body">POST/PUT istek gövdesi.</param>
    /// <param name="query">URL sorgu parametreleri.</param>
    /// <param name="cancellationToken">İptal belirteci.</param>
    public async Task<IdeaSoftResponse<T>> SendAsync<T>(
        HttpMethod method,
        string path,
        object? body = null,
        IEnumerable<KeyValuePair<string, string?>>? query = null,
        CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        ArgumentNullException.ThrowIfNull(method);
        ValidateRelativePath(path);

        var relativePath = "admin-api/" + path.TrimStart('/');
        if (query is not null)
        {
            var queryText = QueryStringBuilder.Build(query);
            if (queryText.Length > 0) relativePath += "?" + queryText;
        }

        for (var attempt = 0; ; attempt++)
        {
            using var request = new HttpRequestMessage(method, new Uri(_config.StoreUri, relativePath));
            var token = await _tokenProvider.GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(token))
                throw new InvalidOperationException("Access token sağlayıcısı boş token döndürdü.");

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (body is not null) request.Content = JsonContent.Create(body, options: JsonOptions.Default);

            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .ConfigureAwait(false);

            if (ShouldRetry(method, response.StatusCode) && attempt < _config.MaxRetryCount)
            {
                await Task.Delay(GetRetryDelay(response, attempt), cancellationToken).ConfigureAwait(false);
                continue;
            }

            var responseBody = response.Content.Headers.ContentLength == 0
                ? string.Empty
                : await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                throw ApiErrorParser.Create(response, responseBody, $"IdeaSoft API isteği başarısız oldu ({method} {path}).");

            var data = Deserialize<T>(responseBody);
            var headers = response.Headers.Concat(response.Content.Headers)
                .ToDictionary(header => header.Key, header => header.Value.ToArray(), StringComparer.OrdinalIgnoreCase);
            var requestId = headers.TryGetValue("X-Request-Id", out var requestIds)
                ? requestIds.FirstOrDefault()
                : headers.TryGetValue("CF-Ray", out var cfRays) ? cfRays.FirstOrDefault() : null;

            return new IdeaSoftResponse<T>
            {
                Data = data,
                StatusCode = response.StatusCode,
                Headers = headers,
                RequestId = requestId
            };
        }
    }

    public void Dispose()
    {
        if (_disposed) return;
        if (_ownsHttpClient) _httpClient.Dispose();
        _disposed = true;
    }

    private static T Deserialize<T>(string body)
    {
        if (string.IsNullOrWhiteSpace(body)) return default!;

        using var document = JsonDocument.Parse(body);
        var root = document.RootElement;
        if (root.ValueKind == JsonValueKind.Object && root.TryGetProperty("data", out var dataElement))
            root = dataElement;

        try
        {
            return root.Deserialize<T>(JsonOptions.Default)!;
        }
        catch (JsonException exception)
        {
            throw new ApiException("IdeaSoft cevabı beklenen .NET tipine dönüştürülemedi.", responseBody: body, innerException: exception);
        }
    }

    private static void ValidateRelativePath(string path)
    {
        if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("API yolu boş olamaz.", nameof(path));
        if (Uri.TryCreate(path, UriKind.Absolute, out _) || path.Contains("..", StringComparison.Ordinal))
            throw new ArgumentException("Yalnızca mağaza içindeki göreli API yollarına izin verilir.", nameof(path));
    }

    private bool ShouldRetry(HttpMethod method, HttpStatusCode statusCode)
    {
        var transientStatus = statusCode == HttpStatusCode.TooManyRequests ||
                              statusCode == HttpStatusCode.BadGateway ||
                              statusCode == HttpStatusCode.ServiceUnavailable ||
                              statusCode == HttpStatusCode.GatewayTimeout;
        if (!transientStatus) return false;

        return _config.RetryNonIdempotentRequests ||
               method == HttpMethod.Get ||
               method == HttpMethod.Head ||
               method == HttpMethod.Put ||
               method == HttpMethod.Delete ||
               method == HttpMethod.Options;
    }

    private TimeSpan GetRetryDelay(HttpResponseMessage response, int attempt)
    {
        if (response.Headers.RetryAfter?.Delta is { } delta) return Clamp(delta);
        if (response.Headers.RetryAfter?.Date is { } date) return Clamp(date - DateTimeOffset.UtcNow);

        var multiplier = Math.Pow(2, attempt);
        return Clamp(TimeSpan.FromMilliseconds(_config.RetryBaseDelay.TotalMilliseconds * multiplier));
    }

    private static TimeSpan Clamp(TimeSpan value) =>
        value < TimeSpan.Zero ? TimeSpan.Zero : value > TimeSpan.FromSeconds(30) ? TimeSpan.FromSeconds(30) : value;

    private static class JsonOptions
    {
        internal static readonly JsonSerializerOptions Default = new(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };
    }
}
