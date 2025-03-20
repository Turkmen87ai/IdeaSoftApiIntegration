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
    /// Görüntü dosya adı
    /// </summary>
    [JsonPropertyName("filename")]
    public string Filename { get; set; } = string.Empty;
    
    /// <summary>
    /// Görüntü URL'si
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// Küçük resim URL'si
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }
    
    /// <summary>
    /// Görüntü başlığı
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    
    /// <summary>
    /// Görüntü sırası
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }
}