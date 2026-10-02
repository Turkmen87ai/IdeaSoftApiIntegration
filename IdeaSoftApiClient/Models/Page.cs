using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

public sealed class Page
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;
    [JsonPropertyName("slug")] public string? Slug { get; set; }
    [JsonPropertyName("content")] public string? Content { get; set; }
    [JsonPropertyName("status")] public int? Status { get; set; }
    [JsonPropertyName("sortOrder")] public int? SortOrder { get; set; }
    [JsonPropertyName("pageTitle")] public string? PageTitle { get; set; }
    [JsonPropertyName("metaDescription")] public string? MetaDescription { get; set; }
    [JsonPropertyName("metaKeywords")] public string? MetaKeywords { get; set; }
    [JsonPropertyName("canonicalUrl")] public string? CanonicalUrl { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
