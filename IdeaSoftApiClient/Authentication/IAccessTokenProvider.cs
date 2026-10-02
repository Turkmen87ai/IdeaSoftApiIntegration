namespace IdeaSoftApiClient.Authentication;

/// <summary>Her API isteği öncesinde kullanılacak access token'ı sağlar.</summary>
public interface IAccessTokenProvider
{
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default);
}

/// <summary>Sabit bir access token kullanan en basit sağlayıcı.</summary>
public sealed class StaticAccessTokenProvider : IAccessTokenProvider
{
    private readonly string _accessToken;

    public StaticAccessTokenProvider(string accessToken)
    {
        _accessToken = string.IsNullOrWhiteSpace(accessToken)
            ? throw new ArgumentException("Access token boş olamaz.", nameof(accessToken))
            : accessToken;
    }

    public Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default) =>
        Task.FromResult(_accessToken);
}
