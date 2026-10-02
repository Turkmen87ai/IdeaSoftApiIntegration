using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Authentication;

/// <summary>IdeaSoft OAuth2 token cevabı.</summary>
public sealed class OAuthToken
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; init; } = string.Empty;

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; init; } = string.Empty;

    [JsonPropertyName("token_type")]
    public string TokenType { get; init; } = "bearer";

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; init; }

    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    [JsonIgnore]
    public DateTimeOffset ReceivedAt { get; init; } = DateTimeOffset.UtcNow;

    [JsonIgnore]
    public DateTimeOffset ExpiresAt => ReceivedAt.AddSeconds(ExpiresIn);

    public bool IsExpired(TimeSpan? safetyMargin = null) =>
        DateTimeOffset.UtcNow >= ExpiresAt - (safetyMargin ?? TimeSpan.FromMinutes(1));
}
