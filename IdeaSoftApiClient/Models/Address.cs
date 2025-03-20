using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft adres modelini temsil eder
/// </summary>
public class Address
{
    /// <summary>
    /// Adres kimliği
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// Müşteri kimliği
    /// </summary>
    [JsonPropertyName("customerId")]
    public int CustomerId { get; set; }
    
    /// <summary>
    /// Adres başlığı
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
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
    /// Telefon numarası
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    
    /// <summary>
    /// Adres satırı 1
    /// </summary>
    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; set; } = string.Empty;
    
    /// <summary>
    /// Adres satırı 2
    /// </summary>
    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; set; }
    
    /// <summary>
    /// İlçe
    /// </summary>
    [JsonPropertyName("district")]
    public string? District { get; set; }
    
    /// <summary>
    /// Şehir
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;
    
    /// <summary>
    /// Ülke
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;
    
    /// <summary>
    /// Posta kodu
    /// </summary>
    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; set; }
    
    /// <summary>
    /// Adres oluşturulma tarihi
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Adres güncelleme tarihi
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}