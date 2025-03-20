using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft ürün modelini temsil eder
/// </summary>
public class Product
{
    /// <summary>
    /// Ürün kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Ürün adı
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Ürün kodu
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
    
    /// <summary>
    /// Ürün açıklaması
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    /// <summary>
    /// Ürün fiyatı
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }
    
    /// <summary>
    /// Ürün indirimsiz fiyatı
    /// </summary>
    [JsonPropertyName("regularPrice")]
    public decimal? RegularPrice { get; set; }
    
    /// <summary>
    /// Ürün stok miktarı
    /// </summary>
    [JsonPropertyName("stock")]
    public int Stock { get; set; }
    
    /// <summary>
    /// Ürün kategori kimliği
    /// </summary>
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }
    
    /// <summary>
    /// Ürün marka kimliği
    /// </summary>
    [JsonPropertyName("brandId")]
    public int? BrandId { get; set; }
    
    /// <summary>
    /// Ürün oluşturulma tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Ürün güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>
    /// Ürün görüntüleri
    /// </summary>
    [JsonPropertyName("images")]
    public List<ProductImage>? Images { get; set; }
}