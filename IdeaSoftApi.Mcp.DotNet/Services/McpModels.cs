using System.Text.Json;

namespace IdeaSoftApi.Mcp.DotNet.Services;

public sealed record ApiToolResult(
    string Surface,
    string Method,
    string Path,
    int StatusCode,
    string? RequestId,
    JsonElement? Data);

public sealed record AuthorizationToolResult(
    string AuthorizationUrl,
    string State,
    string RedirectUri,
    string Warning);

public sealed record WebhookVerificationResult(bool IsValid, string Algorithm);

public sealed record CapabilityInfo(
    string Server,
    string[] Surfaces,
    string[] Tools,
    string[] SecurityRules,
    string Coverage);

public sealed record MigrationChecklist(string[] Steps, string[] SafetyRules);
