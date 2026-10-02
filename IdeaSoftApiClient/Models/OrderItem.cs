using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>IdeaSoft sipariş kalemi.</summary>
public sealed class OrderItem
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("productName")] public string? ProductName { get; set; }
    [JsonPropertyName("productSku")] public string? ProductSku { get; set; }
    [JsonPropertyName("productBarcode")] public string? ProductBarcode { get; set; }
    [JsonPropertyName("productPrice")] public decimal? ProductPrice { get; set; }
    [JsonPropertyName("productCurrency")] public string? ProductCurrency { get; set; }
    [JsonPropertyName("productQuantity")] public decimal? ProductQuantity { get; set; }
    [JsonPropertyName("productTax")] public decimal? ProductTax { get; set; }
    [JsonPropertyName("productDiscount")] public decimal? ProductDiscount { get; set; }
    [JsonPropertyName("discount")] public decimal? CouponDiscount { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
