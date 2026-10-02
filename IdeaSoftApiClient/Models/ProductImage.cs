using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>IdeaSoft ürün görseli.</summary>
public sealed class ProductImage
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("filename")] public string? FileName { get; set; }
    [JsonPropertyName("extension")] public string? Extension { get; set; }
    [JsonPropertyName("sortOrder")] public int? SortOrder { get; set; }
    [JsonPropertyName("thumbUrl")] public string? ThumbnailUrl { get; set; }
    [JsonPropertyName("originalUrl")] public string? OriginalUrl { get; set; }

    /// <summary>POST sırasında `data:image/jpeg;base64,...` biçimindeki görsel.</summary>
    [JsonPropertyName("attachment")] public string? Attachment { get; set; }

    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
