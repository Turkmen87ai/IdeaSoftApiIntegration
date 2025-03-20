namespace IdeaSoftApiClient.Config;

/// <summary>
/// IdeaSoft API yapılandırması için kullanılan sınıf
/// </summary>
public class ApiConfig
{
    /// <summary>
    /// API'nin temel URL'si (örn: https://magaza-adiniz.myideasoft.com)
    /// </summary>
    public string BaseUrl { get; }
    
    /// <summary>
    /// API için kimlik doğrulama anahtarı
    /// </summary>
    public string ApiKey { get; }
    
    /// <summary>
    /// API için kimlik doğrulama parolası
    /// </summary>
    public string ApiSecret { get; }
    
    /// <summary>
    /// API istekleri için zaman aşımı süresi (milisaniye)
    /// </summary>
    public int TimeoutMs { get; }
    
    /// <summary>
    /// API yapılandırmasını oluşturur
    /// </summary>
    /// <param name="baseUrl">API'nin temel URL'si (varsayılan: https://dentrealmarket.myideasoft.com)</param>
    /// <param name="apiKey">API için kimlik doğrulama anahtarı</param>
    /// <param name="apiSecret">API için kimlik doğrulama parolası</param>
    /// <param name="timeoutMs">API istekleri için zaman aşımı süresi (milisaniye)</param>
    public ApiConfig(string baseUrl = "https://dentrealmarket.myideasoft.com", string apiKey = "", string apiSecret = "", int timeoutMs = 30000)
    {
        if (string.IsNullOrEmpty(baseUrl))
            throw new ArgumentNullException(nameof(baseUrl), "Temel URL boş olamaz");
            
        if (string.IsNullOrEmpty(apiKey))
            throw new ArgumentNullException(nameof(apiKey), "API anahtarı boş olamaz");
            
        if (string.IsNullOrEmpty(apiSecret))
            throw new ArgumentNullException(nameof(apiSecret), "API parolası boş olamaz");
            
        if (timeoutMs <= 0)
            throw new ArgumentOutOfRangeException(nameof(timeoutMs), "Zaman aşımı pozitif olmalıdır");
            
        BaseUrl = baseUrl.TrimEnd('/');
        ApiKey = apiKey;
        ApiSecret = apiSecret;
        TimeoutMs = timeoutMs;
    }
}