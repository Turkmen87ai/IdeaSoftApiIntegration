using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

public sealed class Brand
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("slug")] public string? Slug { get; set; }
    [JsonPropertyName("status")] public int? Status { get; set; }
    [JsonPropertyName("sortOrder")] public int? SortOrder { get; set; }
    [JsonPropertyName("imageUrl")] public string? ImageUrl { get; set; }
    [JsonPropertyName("attachment")] public string? Attachment { get; set; }
    [JsonPropertyName("showcaseContent")] public string? ShowcaseContent { get; set; }
    [JsonPropertyName("showcaseFooterContent")] public string? ShowcaseFooterContent { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
