using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>
/// IdeaSoft API yanıtlarını temsil eder
/// </summary>
/// <typeparam name="T">Yanıt veri tipi</typeparam>
public class ApiResponse<T>
{
    /// <summary>
    /// API yanıtının durumu (success, error)
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// Yanıt verileri
    /// </summary>
    [JsonPropertyName("data")]
    public T? Data { get; set; }
    
    /// <summary>
    /// Toplam kayıt sayısı (listelemede kullanılır)
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
    
    /// <summary>
    /// Sayfa numarası (listelemede kullanılır)
    /// </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }
    
    /// <summary>
    /// Sayfa başına kayıt sayısı (listelemede kullanılır)
    /// </summary>
    [JsonPropertyName("perPage")]
    public int? PerPage { get; set; }
    
    /// <summary>
    /// Hata mesajı (hata durumunda)
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    
    /// <summary>
    /// Hatanın detayları (hata durumunda)
    /// </summary>
    [JsonPropertyName("errors")]
    public Dictionary<string, string[]>? Errors { get; set; }
    
    /// <summary>
    /// Yanıtın başarılı olup olmadığını döner
    /// </summary>
    [JsonIgnore]
    public bool IsSuccess => Status?.ToLower() == "success";
}

/// <summary>
/// Sayfalandırılmış liste yanıtları için model
/// </summary>
/// <typeparam name="T">Liste elemanlarının tipi</typeparam>
public class PagedApiResponse<T> : ApiResponse<List<T>>
{
}