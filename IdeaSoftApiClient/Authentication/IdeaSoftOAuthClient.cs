using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;
using System.Security.Cryptography;
using System.Text.Json;

namespace IdeaSoftApiClient.Authentication;

/// <summary>Authorization Code alma adresini ve token işlemlerini yönetir.</summary>
public sealed class IdeaSoftOAuthClient : IDisposable
{
    private readonly ApiConfig _config;
    private readonly HttpClient _httpClient;
    private readonly bool _ownsHttpClient;
    private readonly JsonSerializerOptions _jsonOptions = new() { PropertyNameCaseInsensitive = true };

    public IdeaSoftOAuthClient(ApiConfig config, HttpClient? httpClient = null)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
        _config.Validate();
        _ownsHttpClient = httpClient is null;
        _httpClient = httpClient ?? new HttpClient { Timeout = config.Timeout };
    }

    /// <summary>CSRF kontrolü için güvenli ve rastgele bir state değeri üretir.</summary>
    public static string CreateState(int byteLength = 32)
    {
        if (byteLength is < 16 or > 128)
            throw new ArgumentOutOfRangeException(nameof(byteLength), "Uzunluk 16 ile 128 bayt arasında olmalıdır.");

        return Convert.ToHexString(RandomNumberGenerator.GetBytes(byteLength)).ToLowerInvariant();
    }

    /// <summary>Kullanıcının tarayıcıda açacağı IdeaSoft izin adresini üretir.</summary>
    public Uri CreateAuthorizationUri(string clientId, Uri redirectUri, string state)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(clientId);
        ArgumentException.ThrowIfNullOrWhiteSpace(state);
        ArgumentNullException.ThrowIfNull(redirectUri);

        var query = new Dictionary<string, string>
        {
            ["client_id"] = clientId,
            ["response_type"] = "code",
            ["state"] = state,
            ["redirect_uri"] = redirectUri.AbsoluteUri
        };

        return new Uri(_config.StoreUri, "panel/auth?" + QueryStringBuilder.Build(
            query.Select(item => new KeyValuePair<string, string?>(item.Key, item.Value))));
    }

    /// <summary>30 saniye geçerli authorization code'u access ve refresh token ile değiştirir.</summary>
    public Task<OAuthToken> ExchangeCodeAsync(
        string clientId,
        string clientSecret,
        string code,
        Uri redirectUri,
        CancellationToken cancellationToken = default) =>
        RequestTokenAsync(new Dictionary<string, string>
        {
            ["grant_type"] = "authorization_code",
            ["client_id"] = Require(clientId, nameof(clientId)),
            ["client_secret"] = Require(clientSecret, nameof(clientSecret)),
            ["code"] = Require(code, nameof(code)),
            ["redirect_uri"] = (redirectUri ?? throw new ArgumentNullException(nameof(redirectUri))).AbsoluteUri
        }, cancellationToken);

    /// <summary>Refresh token'ı kullanarak yeni access ve refresh token alır.</summary>
    /// <remarks>IdeaSoft her yenilemede refresh token'ı döndürür; eski değeri yenisiyle değiştirin.</remarks>
    public Task<OAuthToken> RefreshAsync(
        string clientId,
        string clientSecret,
        string refreshToken,
        CancellationToken cancellationToken = default) =>
        RequestTokenAsync(new Dictionary<string, string>
        {
            ["grant_type"] = "refresh_token",
            ["client_id"] = Require(clientId, nameof(clientId)),
            ["client_secret"] = Require(clientSecret, nameof(clientSecret)),
            ["refresh_token"] = Require(refreshToken, nameof(refreshToken))
        }, cancellationToken);

    private async Task<OAuthToken> RequestTokenAsync(
        Dictionary<string, string> values,
        CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri(_config.StoreUri, "oauth/v2/token"))
        {
            Content = new FormUrlEncodedContent(values)
        };
        using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            throw ApiErrorParser.Create(response, body, "OAuth token isteği başarısız oldu.");

        var token = JsonSerializer.Deserialize<OAuthToken>(body, _jsonOptions);
        if (token is null || string.IsNullOrWhiteSpace(token.AccessToken))
            throw new ApiException("IdeaSoft geçerli bir OAuth token cevabı döndürmedi.", (int)response.StatusCode, responseBody: body);

        return token;
    }

    private static string Require(string value, string name) =>
        string.IsNullOrWhiteSpace(value) ? throw new ArgumentException($"{name} boş olamaz.", name) : value;

    public void Dispose()
    {
        if (_ownsHttpClient) _httpClient.Dispose();
    }
}
