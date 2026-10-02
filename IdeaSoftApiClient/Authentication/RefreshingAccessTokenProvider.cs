namespace IdeaSoftApiClient.Authentication;

/// <summary>Access token süresi dolmadan refresh token ile otomatik yeniler.</summary>
/// <remarks>
/// IdeaSoft refresh token'ı her yenilemede döndürür. <c>tokenUpdated</c>
/// geri çağrısında yeni token çiftini kalıcı ve şifreli depoya yazın.
/// </remarks>
public sealed class RefreshingAccessTokenProvider : IAccessTokenProvider, IDisposable
{
    private readonly IdeaSoftOAuthClient _oauthClient;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly Func<OAuthToken, CancellationToken, Task>? _tokenUpdated;
    private readonly SemaphoreSlim _refreshLock = new(1, 1);
    private OAuthToken _token;

    public RefreshingAccessTokenProvider(
        IdeaSoftOAuthClient oauthClient,
        string clientId,
        string clientSecret,
        OAuthToken initialToken,
        Func<OAuthToken, CancellationToken, Task>? tokenUpdated = null)
    {
        _oauthClient = oauthClient ?? throw new ArgumentNullException(nameof(oauthClient));
        _clientId = string.IsNullOrWhiteSpace(clientId) ? throw new ArgumentException("Client ID boş olamaz.", nameof(clientId)) : clientId;
        _clientSecret = string.IsNullOrWhiteSpace(clientSecret) ? throw new ArgumentException("Client Secret boş olamaz.", nameof(clientSecret)) : clientSecret;
        _token = initialToken ?? throw new ArgumentNullException(nameof(initialToken));
        _tokenUpdated = tokenUpdated;
    }

    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        if (!_token.IsExpired()) return _token.AccessToken;

        await _refreshLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (!_token.IsExpired()) return _token.AccessToken;
            if (string.IsNullOrWhiteSpace(_token.RefreshToken))
                throw new InvalidOperationException("Token yenilemek için refresh token bulunamadı.");

            _token = await _oauthClient.RefreshAsync(_clientId, _clientSecret, _token.RefreshToken, cancellationToken)
                .ConfigureAwait(false);
            if (_tokenUpdated is not null)
                await _tokenUpdated(_token, cancellationToken).ConfigureAwait(false);

            return _token.AccessToken;
        }
        finally
        {
            _refreshLock.Release();
        }
    }

    public void Dispose() => _refreshLock.Dispose();
}
