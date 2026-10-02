using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>IdeaSoft ürün modelinin en sık kullanılan alanları.</summary>
public sealed class Product
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("fullName")] public string? FullName { get; set; }
    [JsonPropertyName("slug")] public string? Slug { get; set; }
    [JsonPropertyName("sku")] public string? Sku { get; set; }
    [JsonPropertyName("barcode")] public string? Barcode { get; set; }
    [JsonPropertyName("stockAmount")] public decimal? StockAmount { get; set; }
    [JsonPropertyName("price1")] public decimal? Price { get; set; }
    [JsonPropertyName("discount")] public decimal? Discount { get; set; }
    [JsonPropertyName("discountType")] public int? DiscountType { get; set; }
    [JsonPropertyName("taxIncluded")] public int? TaxIncluded { get; set; }
    [JsonPropertyName("tax")] public int? Tax { get; set; }
    [JsonPropertyName("status")] public int? Status { get; set; }
    [JsonPropertyName("shortDetails")] public string? ShortDetails { get; set; }
    [JsonPropertyName("pageTitle")] public string? PageTitle { get; set; }
    [JsonPropertyName("metaDescription")] public string? MetaDescription { get; set; }
    [JsonPropertyName("metaKeywords")] public string? MetaKeywords { get; set; }
    [JsonPropertyName("canonicalUrl")] public string? CanonicalUrl { get; set; }
    [JsonPropertyName("categories")] public List<Category>? Categories { get; set; }
    [JsonPropertyName("images")] public List<ProductImage>? Images { get; set; }
    [JsonPropertyName("createdAt")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
