namespace IdeaSoftApiClient.Config;

/// <summary>IdeaSoft istemcisinin bağlantı ve yeniden deneme ayarları.</summary>
public sealed class ApiConfig
{
    /// <param name="storeUrl">Mağaza kök adresi. Örnek: https://magaza-adiniz.myideasoft.com</param>
    public ApiConfig(string storeUrl)
    {
        if (!Uri.TryCreate(storeUrl, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttps && uri.Scheme != Uri.UriSchemeHttp))
        {
            throw new ArgumentException("Geçerli bir HTTP/HTTPS mağaza adresi girin.", nameof(storeUrl));
        }

        StoreUri = new Uri(uri.GetLeftPart(UriPartial.Authority).TrimEnd('/') + "/", UriKind.Absolute);
    }

    /// <summary>Mağazanın kök adresi.</summary>
    public Uri StoreUri { get; }

    /// <summary>HTTP isteği zaman aşımı. Varsayılan 100 saniyedir.</summary>
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(100);

    /// <summary>429 ve geçici sunucu hatalarında yapılacak en fazla ek deneme sayısı.</summary>
    public int MaxRetryCount { get; init; } = 3;

    /// <summary>Sunucu Retry-After başlığı göndermediğinde ilk bekleme süresi.</summary>
    public TimeSpan RetryBaseDelay { get; init; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// POST gibi tekrarlandığında çift kayıt oluşturabilecek metotlarda otomatik retry'ı açar.
    /// Varsayılan false değerini yalnız hedef operasyonun idempotent olduğunu biliyorsanız değiştirin.
    /// </summary>
    public bool RetryNonIdempotentRequests { get; init; }

    internal void Validate()
    {
        if (Timeout <= TimeSpan.Zero)
            throw new ArgumentOutOfRangeException(nameof(Timeout), "Zaman aşımı sıfırdan büyük olmalıdır.");
        if (MaxRetryCount is < 0 or > 10)
            throw new ArgumentOutOfRangeException(nameof(MaxRetryCount), "Yeniden deneme sayısı 0 ile 10 arasında olmalıdır.");
        if (RetryBaseDelay < TimeSpan.Zero)
            throw new ArgumentOutOfRangeException(nameof(RetryBaseDelay), "Bekleme süresi negatif olamaz.");
    }
}
