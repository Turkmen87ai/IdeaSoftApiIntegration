using IdeaSoftApi.Mcp.DotNet.Configuration;
using IdeaSoftApiClient;
using IdeaSoftApiClient.Authentication;
using IdeaSoftApiClient.Models;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace IdeaSoftApi.Mcp.DotNet.Services;

public sealed class IdeaSoftMcpGateway : IDisposable
{
    private static readonly HashSet<string> AllowedMethods = new(StringComparer.OrdinalIgnoreCase)
    {
        "GET", "POST", "PUT", "DELETE"
    };

    private readonly IdeaSoftMcpOptions _options;
    private readonly HttpClient? _httpClient;
    private readonly object _clientLock = new();
    private IdeaSoftOAuthClient? _oauthClient;
    private RefreshingAccessTokenProvider? _refreshingTokenProvider;
    private IdeaSoftClient? _adminClient;
    private IdeaSoftStoreClient? _storeClient;
    private bool _disposed;

    public IdeaSoftMcpGateway(IdeaSoftMcpOptions options)
        : this(options, null)
    {
    }

    public IdeaSoftMcpGateway(IdeaSoftMcpOptions options, HttpClient? httpClient)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        _httpClient = httpClient;
    }

    public ConfigurationStatus GetStatus() => _options.ToStatus();

    public AuthorizationToolResult CreateAuthorizationUrl()
    {
        var config = _options.CreateApiConfig();
        if (string.IsNullOrWhiteSpace(_options.ClientId))
            throw new InvalidOperationException("IDEASOFT_CLIENT_ID ortam değişkeni tanımlı değil.");
        if (!Uri.TryCreate(_options.RedirectUri, UriKind.Absolute, out var redirectUri))
            throw new InvalidOperationException("IDEASOFT_REDIRECT_URI geçerli bir mutlak URL değil.");

        using var oauth = new IdeaSoftOAuthClient(config, _httpClient);
        var state = IdeaSoftOAuthClient.CreateState();
        var url = oauth.CreateAuthorizationUri(_options.ClientId, redirectUri, state);
        return new AuthorizationToolResult(
            url.AbsoluteUri,
            state,
            redirectUri.AbsoluteUri,
            "State değerini kullanıcı oturumunda saklayın ve callback'te birebir doğrulayın.");
    }

    public async Task<ApiToolResult> SendAsync(
        string surface,
        string method,
        string path,
        string? queryJson,
        string? bodyJson,
        string? writeConfirmation,
        CancellationToken cancellationToken)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        var normalizedSurface = NormalizeSurface(surface);
        var normalizedMethod = NormalizeMethod(method);
        EnsureWriteAllowed(normalizedMethod, writeConfirmation);

        var query = ParseQuery(queryJson);
        var body = ParseBody(bodyJson);
        var response = normalizedSurface == "admin"
            ? await GetAdminClient().SendAsync<JsonElement>(
                new HttpMethod(normalizedMethod), path, body, query, cancellationToken).ConfigureAwait(false)
            : await GetStoreClient().SendAsync<JsonElement>(
                new HttpMethod(normalizedMethod), path, body, query, cancellationToken).ConfigureAwait(false);

        return ToToolResult(normalizedSurface, normalizedMethod, path, response);
    }

    public Task<ApiToolResult> ListAsync(
        string surface,
        string resource,
        int page,
        int limit,
        string? filtersJson,
        CancellationToken cancellationToken)
    {
        if (page < 1) throw new ArgumentOutOfRangeException(nameof(page), "page en az 1 olmalıdır.");
        if (limit is < 1 or > 100) throw new ArgumentOutOfRangeException(nameof(limit), "limit 1 ile 100 arasında olmalıdır.");

        var query = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["page"] = page.ToString(System.Globalization.CultureInfo.InvariantCulture),
            ["limit"] = limit.ToString(System.Globalization.CultureInfo.InvariantCulture)
        };
        foreach (var filter in ParseQuery(filtersJson))
        {
            if (filter.Key is not ("page" or "limit")) query[filter.Key] = filter.Value;
        }

        return SendAsync(surface, "GET", resource, JsonSerializer.Serialize(query), null, null, cancellationToken);
    }

    public Task<ApiToolResult> GetAsync(
        string surface,
        string resource,
        long id,
        CancellationToken cancellationToken)
    {
        if (id < 1) throw new ArgumentOutOfRangeException(nameof(id), "id pozitif olmalıdır.");
        return SendAsync(surface, "GET", $"{resource.TrimEnd('/')}/{id}", null, null, null, cancellationToken);
    }

    public WebhookVerificationResult VerifyWebhook(string rawBody, string receivedBase64Hmac)
    {
        if (string.IsNullOrWhiteSpace(_options.ClientSecret))
            throw new InvalidOperationException("IDEASOFT_CLIENT_SECRET ortam değişkeni tanımlı değil.");
        if (string.IsNullOrWhiteSpace(receivedBase64Hmac))
            return new WebhookVerificationResult(false, "HMAC-SHA256/Base64");

        byte[] received;
        try
        {
            received = Convert.FromBase64String(receivedBase64Hmac);
        }
        catch (FormatException)
        {
            return new WebhookVerificationResult(false, "HMAC-SHA256/Base64");
        }

        var expected = HMACSHA256.HashData(
            Encoding.UTF8.GetBytes(_options.ClientSecret),
            Encoding.UTF8.GetBytes(rawBody ?? string.Empty));
        var valid = received.Length == expected.Length && CryptographicOperations.FixedTimeEquals(received, expected);
        return new WebhookVerificationResult(valid, "HMAC-SHA256/Base64");
    }

    public void Dispose()
    {
        if (_disposed) return;
        _adminClient?.Dispose();
        _storeClient?.Dispose();
        _refreshingTokenProvider?.Dispose();
        _oauthClient?.Dispose();
        _disposed = true;
    }

    private IdeaSoftClient GetAdminClient()
    {
        EnsureClients();
        return _adminClient!;
    }

    private IdeaSoftStoreClient GetStoreClient()
    {
        EnsureClients();
        return _storeClient!;
    }

    private void EnsureClients()
    {
        if (_adminClient is not null) return;

        lock (_clientLock)
        {
            if (_adminClient is not null) return;
            var config = _options.CreateApiConfig();
            IAccessTokenProvider tokenProvider;

            if (!string.IsNullOrWhiteSpace(_options.AccessToken))
            {
                tokenProvider = new StaticAccessTokenProvider(_options.AccessToken);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_options.ClientId) ||
                    string.IsNullOrWhiteSpace(_options.ClientSecret) ||
                    string.IsNullOrWhiteSpace(_options.RefreshToken))
                {
                    throw new InvalidOperationException(
                        "IDEASOFT_ACCESS_TOKEN veya Client ID/Client Secret/Refresh Token üçlüsü tanımlanmalıdır.");
                }

                _oauthClient = new IdeaSoftOAuthClient(config, _httpClient);
                _refreshingTokenProvider = new RefreshingAccessTokenProvider(
                    _oauthClient,
                    _options.ClientId,
                    _options.ClientSecret,
                    new OAuthToken
                    {
                        AccessToken = string.Empty,
                        RefreshToken = _options.RefreshToken,
                        ExpiresIn = 0,
                        ReceivedAt = DateTimeOffset.UnixEpoch
                    });
                tokenProvider = _refreshingTokenProvider;
            }

            _adminClient = new IdeaSoftClient(config, tokenProvider, _httpClient);
            _storeClient = new IdeaSoftStoreClient(config, tokenProvider, _httpClient);
        }
    }

    private void EnsureWriteAllowed(string method, string? confirmation)
    {
        if (method == "GET") return;
        if (!_options.AllowWrites)
            throw new InvalidOperationException("Yazma işlemleri kapalı. IDEASOFT_MCP_ALLOW_WRITES=true olmadan çalıştırılamaz.");
        if (!string.Equals(confirmation, IdeaSoftMcpOptions.WriteConfirmation, StringComparison.Ordinal))
            throw new InvalidOperationException($"Yazma için writeConfirmation tam olarak {IdeaSoftMcpOptions.WriteConfirmation} olmalıdır.");
    }

    private static string NormalizeSurface(string surface) =>
        surface?.Trim().ToLowerInvariant() switch
        {
            "admin" => "admin",
            "store" => "store",
            _ => throw new ArgumentException("surface yalnız admin veya store olabilir.", nameof(surface))
        };

    private static string NormalizeMethod(string method)
    {
        var normalized = method?.Trim().ToUpperInvariant() ?? string.Empty;
        return AllowedMethods.Contains(normalized)
            ? normalized
            : throw new ArgumentException("method yalnız GET, POST, PUT veya DELETE olabilir.", nameof(method));
    }

    private static IEnumerable<KeyValuePair<string, string?>> ParseQuery(string? json)
    {
        if (string.IsNullOrWhiteSpace(json)) return [];
        using var document = JsonDocument.Parse(json);
        if (document.RootElement.ValueKind != JsonValueKind.Object)
            throw new ArgumentException("queryJson bir JSON nesnesi olmalıdır.", nameof(json));

        return document.RootElement.EnumerateObject()
            .Select(property => new KeyValuePair<string, string?>(
                property.Name,
                property.Value.ValueKind == JsonValueKind.Null ? null : property.Value.ToString()))
            .ToArray();
    }

    private static object? ParseBody(string? json)
    {
        if (string.IsNullOrWhiteSpace(json)) return null;
        using var document = JsonDocument.Parse(json);
        return document.RootElement.Clone();
    }

    private static ApiToolResult ToToolResult(
        string surface,
        string method,
        string path,
        IdeaSoftResponse<JsonElement> response) =>
        new(
            surface,
            method,
            path,
            (int)response.StatusCode,
            response.RequestId,
            response.Data.ValueKind == JsonValueKind.Undefined ? null : response.Data);
}
