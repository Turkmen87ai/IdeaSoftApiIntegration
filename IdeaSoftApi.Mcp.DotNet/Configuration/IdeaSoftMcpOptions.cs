using IdeaSoftApiClient.Config;

namespace IdeaSoftApi.Mcp.DotNet.Configuration;

public sealed class IdeaSoftMcpOptions
{
    public const string WriteConfirmation = "IDEASOFT_WRITE_CONFIRMED";

    public string? StoreUrl { get; init; }
    public string? AccessToken { get; init; }
    public string? ClientId { get; init; }
    public string? ClientSecret { get; init; }
    public string? RedirectUri { get; init; }
    public string? RefreshToken { get; init; }
    public bool AllowWrites { get; init; }
    public int TimeoutSeconds { get; init; } = 100;
    public int MaxRetryCount { get; init; } = 3;

    public static IdeaSoftMcpOptions FromEnvironment() => new()
    {
        StoreUrl = Read("IDEASOFT_STORE_URL"),
        AccessToken = Read("IDEASOFT_ACCESS_TOKEN"),
        ClientId = Read("IDEASOFT_CLIENT_ID"),
        ClientSecret = Read("IDEASOFT_CLIENT_SECRET"),
        RedirectUri = Read("IDEASOFT_REDIRECT_URI"),
        RefreshToken = Read("IDEASOFT_REFRESH_TOKEN"),
        AllowWrites = ParseBoolean("IDEASOFT_MCP_ALLOW_WRITES"),
        TimeoutSeconds = ParseInteger("IDEASOFT_MCP_TIMEOUT_SECONDS", 100, 1, 600),
        MaxRetryCount = ParseInteger("IDEASOFT_MCP_MAX_RETRY_COUNT", 3, 0, 10)
    };

    public ApiConfig CreateApiConfig()
    {
        if (string.IsNullOrWhiteSpace(StoreUrl))
            throw new InvalidOperationException("IDEASOFT_STORE_URL ortam değişkeni tanımlı değil.");

        return new ApiConfig(StoreUrl)
        {
            Timeout = TimeSpan.FromSeconds(TimeoutSeconds),
            MaxRetryCount = MaxRetryCount,
            RetryNonIdempotentRequests = false
        };
    }

    public ConfigurationStatus ToStatus()
    {
        Uri? storeUri = null;
        if (!string.IsNullOrWhiteSpace(StoreUrl) && Uri.TryCreate(StoreUrl, UriKind.Absolute, out var candidate))
            storeUri = new Uri(candidate.GetLeftPart(UriPartial.Authority));

        return new ConfigurationStatus(
            ServerName: "IdeaSoftApi MCP",
            StoreUrl: storeUri?.AbsoluteUri,
            AccessTokenConfigured: !string.IsNullOrWhiteSpace(AccessToken),
            RefreshFlowConfigured: !string.IsNullOrWhiteSpace(ClientId) &&
                                   !string.IsNullOrWhiteSpace(ClientSecret) &&
                                   !string.IsNullOrWhiteSpace(RefreshToken),
            AuthorizationUrlConfigured: !string.IsNullOrWhiteSpace(ClientId) &&
                                        Uri.TryCreate(RedirectUri, UriKind.Absolute, out _),
            WritesEnabled: AllowWrites,
            WriteConfirmation: WriteConfirmation,
            SecretsAreReturned: false);
    }

    private static string? Read(string name) =>
        string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable(name))
            ? null
            : Environment.GetEnvironmentVariable(name)!.Trim();

    private static bool ParseBoolean(string name) =>
        string.Equals(Read(name), "true", StringComparison.OrdinalIgnoreCase) || Read(name) == "1";

    private static int ParseInteger(string name, int fallback, int minimum, int maximum) =>
        int.TryParse(Read(name), out var value) && value >= minimum && value <= maximum ? value : fallback;
}

public sealed record ConfigurationStatus(
    string ServerName,
    string? StoreUrl,
    bool AccessTokenConfigured,
    bool RefreshFlowConfigured,
    bool AuthorizationUrlConfigured,
    bool WritesEnabled,
    string WriteConfirmation,
    bool SecretsAreReturned);
