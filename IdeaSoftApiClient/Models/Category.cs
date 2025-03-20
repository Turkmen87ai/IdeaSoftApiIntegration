using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft kategori modelini temsil eder
/// </summary>
public class Category
{
    /// <summary>
    /// Kategori kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Kategori adı
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Kategori açıklaması
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// Üst kategori kimliği
    /// </summary>
    [JsonPropertyName("parentId")]
    public int? ParentId { get; set; }
    
    /// <summary>
    /// Kategori sırası
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }
    
    /// <summary>
    /// Kategori SEO URL'si
    /// </summary>
    [JsonPropertyName("seoUrl")]
    public string? SeoUrl { get; set; }
    
    /// <summary>
    /// Kategori oluşturulma tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Kategori güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}