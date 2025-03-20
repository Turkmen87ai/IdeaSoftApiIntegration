using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft müşteri modelini temsil eder
/// </summary>
public class Customer
{
    /// <summary>
    /// Müşteri kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Müşteri grubunun kimliği
    /// </summary>
    [JsonPropertyName("customerGroupId")]
    public int? CustomerGroupId { get; set; }
    
    /// <summary>
    /// Ad
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = string.Empty;
    
    /// <summary>
    /// Soyad
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = string.Empty;
    
    /// <summary>
    /// E-posta adresi
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// Telefon numarası
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    
    /// <summary>
    /// Kullanıcı aktif mi
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool IsActive { get; set; }
    
    /// <summary>
    /// Müşteri oluşturulma tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Müşteri güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
    
    /// <summary>
    /// Müşteri adresleri
    /// </summary>
    [JsonPropertyName("addresses")]
    public List<Address>? Addresses { get; set; }
}