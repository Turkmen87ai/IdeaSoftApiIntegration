using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft ürün görüntüsü modelini temsil eder
/// </summary>
public class ProductImage
{
    /// <summary>
    /// Görüntü kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Görüntü adı
    /// </summary>
    [JsonPropertyName("filename")]
    public string Filename { get; set; } = string.Empty;
    
    /// <summary>
    /// Görüntü URL'si
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// Görüntü sırası
    /// </summary>
    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; set; }
    
    /// <summary>
    /// Görüntü eklenme tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Görüntü güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}