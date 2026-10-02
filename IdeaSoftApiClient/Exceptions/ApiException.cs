namespace IdeaSoftApiClient.Exceptions;

/// <summary>
/// IdeaSoft API'si ile iletişim sırasında oluşan hataları temsil eden temel sınıf
/// </summary>
public class ApiException : Exception
{
    /// <summary>
    /// HTTP durumu kodu
    /// </summary>
    public int StatusCode { get; }

    /// <summary>
    /// API'den dönen hata mesajı (varsa)
    /// </summary>
    public string? ApiErrorMessage { get; }

    /// <summary>
    /// API'den dönen hata kodu (varsa)
    /// </summary>
    public string? ApiErrorCode { get; }

    /// <summary>Sunucudan dönen ham cevap gövdesi. Gizli veri içerebileceği için loglarken dikkat edin.</summary>
    public string? ResponseBody { get; }

    /// <summary>IdeaSoft veya ara katman tarafından gönderilen istek kimliği.</summary>
    public string? RequestId { get; }

    /// <summary>
    /// Yeni bir API istisnası oluşturur
    /// </summary>
    /// <param name="message">Hata mesajı</param>
    /// <param name="statusCode">HTTP durumu kodu</param>
    /// <param name="apiErrorMessage">API'den dönen hata mesajı</param>
    /// <param name="apiErrorCode">API'den dönen hata kodu</param>
    /// <param name="responseBody">API'den dönen ham cevap</param>
    /// <param name="requestId">İstek takip kimliği</param>
    /// <param name="innerException">İç istisna</param>
    public ApiException(
        string message,
        int statusCode = 0,
        string? apiErrorMessage = null,
        string? apiErrorCode = null,
        string? responseBody = null,
        string? requestId = null,
        Exception? innerException = null)
        : base(message, innerException)
    {
        StatusCode = statusCode;
        ApiErrorMessage = apiErrorMessage;
        ApiErrorCode = apiErrorCode;
        ResponseBody = responseBody;
        RequestId = requestId;
    }
}
