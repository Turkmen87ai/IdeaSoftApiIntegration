using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft API'sinden dönen indirim modeli
/// </summary>
public class Discount
{
    /// <summary>
    /// İndirim ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// İndirim adı
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// İndirim açıklaması
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// İndirim türü (yüzde, sabit tutar vb.)
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    /// <summary>
    /// İndirim değeri
    /// </summary>
    [JsonPropertyName("value")]
    public decimal Value { get; set; }
    
    /// <summary>
    /// İndirim kupon kodu
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    
    /// <summary>
    /// İndirimin etkin olup olmadığı
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }
    
    /// <summary>
    /// İndirim başlangıç tarihi
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }
    
    /// <summary>
    /// İndirim bitiş tarihi
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
    
    /// <summary>
    /// İndirim hedefi (ürün, kategori, sepet vb.)
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
    
    /// <summary>
    /// İndirim uygulanacak minimum sepet tutarı
    /// </summary>
    [JsonPropertyName("min_order_amount")]
    public decimal? MinOrderAmount { get; set; }
    
    /// <summary>
    /// İndirim maksimum kullanım sayısı
    /// </summary>
    [JsonPropertyName("max_usage")]
    public int? MaxUsage { get; set; }
    
    /// <summary>
    /// İndirim kullanım sayısı
    /// </summary>
    [JsonPropertyName("usage_count")]
    public int? UsageCount { get; set; }
    
    /// <summary>
    /// Kullanıcı başına maksimum kullanım sayısı
    /// </summary>
    [JsonPropertyName("max_usage_per_customer")]
    public int? MaxUsagePerCustomer { get; set; }
    
    /// <summary>
    /// Oluşturma tarihi
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }
    
    /// <summary>
    /// Güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}