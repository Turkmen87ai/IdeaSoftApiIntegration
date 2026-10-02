using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>IdeaSoft sipariş modelinin en sık kullanılan alanları.</summary>
public sealed class Order
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("transactionId")] public string? TransactionId { get; set; }
    [JsonPropertyName("customerFirstname")] public string? CustomerFirstName { get; set; }
    [JsonPropertyName("customerSurname")] public string? CustomerSurname { get; set; }
    [JsonPropertyName("customerEmail")] public string? CustomerEmail { get; set; }
    [JsonPropertyName("customerPhone")] public string? CustomerPhone { get; set; }
    [JsonPropertyName("status")] public string? Status { get; set; }
    [JsonPropertyName("paymentStatus")] public string? PaymentStatus { get; set; }
    [JsonPropertyName("paymentTypeName")] public string? PaymentTypeName { get; set; }
    [JsonPropertyName("currency")] public string? Currency { get; set; }
    [JsonPropertyName("generalAmount")] public decimal? GeneralAmount { get; set; }
    [JsonPropertyName("finalAmount")] public decimal? FinalAmount { get; set; }
    [JsonPropertyName("shippingAmount")] public decimal? ShippingAmount { get; set; }
    [JsonPropertyName("shippingProviderName")] public string? ShippingProviderName { get; set; }
    [JsonPropertyName("shippingTrackingCode")] public string? ShippingTrackingCode { get; set; }
    [JsonPropertyName("orderItems")] public List<OrderItem>? Items { get; set; }
    [JsonPropertyName("createdAt")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
