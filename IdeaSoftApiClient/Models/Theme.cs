using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

public sealed class Theme
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("platform")] public string? Platform { get; set; }
    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("preset")] public string? Preset { get; set; }
    [JsonPropertyName("directoryName")] public string? DirectoryName { get; set; }
    [JsonPropertyName("status")] public int? Status { get; set; }
    [JsonPropertyName("version")] public int? Version { get; set; }
    [JsonPropertyName("attachment")] public string? Attachment { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
