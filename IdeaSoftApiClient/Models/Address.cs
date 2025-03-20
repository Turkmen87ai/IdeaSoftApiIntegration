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
    public string Phone { get; set; } = string.Empty;
    
    /// <summary>
    /// E-posta adresi
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    
    /// <summary>
    /// Şirket adı
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }
    
    /// <summary>
    /// Adres satırı 1
    /// </summary>
    [JsonPropertyName("address1")]
    public string Address1 { get; set; } = string.Empty;
    
    /// <summary>
    /// Adres satırı 2
    /// </summary>
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }
    
    /// <summary>
    /// Posta kodu
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }
    
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
    /// Vergi dairesi (fatura adresi için)
    /// </summary>
    [JsonPropertyName("taxOffice")]
    public string? TaxOffice { get; set; }
    
    /// <summary>
    /// Vergi numarası (fatura adresi için)
    /// </summary>
    [JsonPropertyName("taxNumber")]
    public string? TaxNumber { get; set; }
}