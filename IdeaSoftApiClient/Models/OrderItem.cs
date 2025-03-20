using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft sipariş kalemi modelini temsil eder
/// </summary>
public class OrderItem
{
    /// <summary>
    /// Sipariş kalemi kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Sipariş kimliği
    /// </summary>
    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }
    
    /// <summary>
    /// Ürün kimliği
    /// </summary>
    [JsonPropertyName("productId")]
    public int ProductId { get; set; }
    
    /// <summary>
    /// Ürün adı
    /// </summary>
    [JsonPropertyName("productName")]
    public string ProductName { get; set; } = string.Empty;
    
    /// <summary>
    /// Ürün kodu
    /// </summary>
    [JsonPropertyName("productCode")]
    public string ProductCode { get; set; } = string.Empty;
    
    /// <summary>
    /// Varyasyon kimliği (varsa)
    /// </summary>
    [JsonPropertyName("variantId")]
    public int? VariantId { get; set; }
    
    /// <summary>
    /// Varyasyon açıklaması (varsa)
    /// </summary>
    [JsonPropertyName("variantDescription")]
    public string? VariantDescription { get; set; }
    
    /// <summary>
    /// Miktar
    /// </summary>
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    
    /// <summary>
    /// Birim fiyat
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }
    
    /// <summary>
    /// İndirimli birim fiyat
    /// </summary>
    [JsonPropertyName("discountedPrice")]
    public decimal? DiscountedPrice { get; set; }
    
    /// <summary>
    /// Toplam (miktar * fiyat)
    /// </summary>
    [JsonPropertyName("total")]
    public decimal Total { get; set; }
    
    /// <summary>
    /// KDV oranı
    /// </summary>
    [JsonPropertyName("taxRate")]
    public decimal TaxRate { get; set; }
    
    /// <summary>
    /// KDV tutarı
    /// </summary>
    [JsonPropertyName("taxAmount")]
    public decimal TaxAmount { get; set; }
    
    /// <summary>
    /// İade edilen miktar
    /// </summary>
    [JsonPropertyName("refundedQuantity")]
    public int? RefundedQuantity { get; set; }
}