using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft API'sinden dönen kampanya modeli
/// </summary>
public class Campaign
{
    /// <summary>
    /// Kampanya ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Kampanya adı
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Kampanya açıklaması
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// Kampanya türü (yüzde, sabit indirim vb.)
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    /// <summary>
    /// Kampanya indirim değeri
    /// </summary>
    [JsonPropertyName("discount_value")]
    public decimal DiscountValue { get; set; }
    
    /// <summary>
    /// Kampanya minimum sepet tutarı
    /// </summary>
    [JsonPropertyName("min_order_amount")]
    public decimal? MinOrderAmount { get; set; }
    
    /// <summary>
    /// Kampanya başlangıç tarihi
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }
    
    /// <summary>
    /// Kampanya bitiş tarihi
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }
    
    /// <summary>
    /// Kampanya hedefi (ürün, kategori, sepet vb.)
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
    
    /// <summary>
    /// Kampanyanın uygulandığı ürün/kategori/marka vb. ID'leri
    /// </summary>
    [JsonPropertyName("target_ids")]
    public List<int>? TargetIds { get; set; }
    
    /// <summary>
    /// Kampanya kodu
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    
    /// <summary>
    /// Kampanyanın etkin olup olmadığı
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }
    
    /// <summary>
    /// Kampanya kullanım limiti
    /// </summary>
    [JsonPropertyName("usage_limit")]
    public int? UsageLimit { get; set; }
    
    /// <summary>
    /// Kampanya kullanım sayısı
    /// </summary>
    [JsonPropertyName("usage_count")]
    public int? UsageCount { get; set; }
    
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