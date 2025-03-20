using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft sipariş modelini temsil eder
/// </summary>
public class Order
{
    /// <summary>
    /// Sipariş kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Sipariş numarası
    /// </summary>
    [JsonPropertyName("orderNumber")]
    public string OrderNumber { get; set; } = string.Empty;
    
    /// <summary>
    /// Müşteri kimliği
    /// </summary>
    [JsonPropertyName("customerId")]
    public int CustomerId { get; set; }
    
    /// <summary>
    /// Sipariş durumu
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// Ödeme türü
    /// </summary>
    [JsonPropertyName("paymentType")]
    public string PaymentType { get; set; } = string.Empty;
    
    /// <summary>
    /// Kargo firması
    /// </summary>
    [JsonPropertyName("shippingProvider")]
    public string? ShippingProvider { get; set; }
    
    /// <summary>
    /// Kargo izleme numarası
    /// </summary>
    [JsonPropertyName("trackingNumber")]
    public string? TrackingNumber { get; set; }
    
    /// <summary>
    /// Sipariş toplamı
    /// </summary>
    [JsonPropertyName("total")]
    public decimal Total { get; set; }
    
    /// <summary>
    /// Kargo ücreti
    /// </summary>
    [JsonPropertyName("shippingAmount")]
    public decimal ShippingAmount { get; set; }
    
    /// <summary>
    /// Sipariş kalemi sayısı
    /// </summary>
    [JsonPropertyName("itemCount")]
    public int ItemCount { get; set; }
    
    /// <summary>
    /// Sipariş notları
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
    
    /// <summary>
    /// Sipariş oluşturulma tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Sipariş güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>
    /// Teslimat adresi
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public Address? ShippingAddress { get; set; }
    
    /// <summary>
    /// Fatura adresi
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public Address? BillingAddress { get; set; }
    
    /// <summary>
    /// Sipariş kalemleri
    /// </summary>
    [JsonPropertyName("items")]
    public List<OrderItem>? Items { get; set; }
}