using IdeaSoftApiClient.Models;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>
/// IdeaSoft müşteri API hizmetleri
/// </summary>
public class CustomerService : BaseApiService<Customer>
{
    /// <summary>
    /// Yeni bir müşteri servisi oluşturur
    /// </summary>
    /// <param name="httpClient">HTTP istemcisi</param>
    public CustomerService(HttpClient httpClient) 
        : base(httpClient, "customers")
    {
    }
    
    /// <summary>
    /// E-posta adresine göre müşteri arar
    /// </summary>
    /// <param name="email">E-posta adresi</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Bulunan müşteri</returns>
    public async Task<Customer?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("E-posta adresi boş olamaz", nameof(email));
            
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?email={Uri.EscapeDataString(email)}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Customer>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            // İlk eşleşen müşteriyi döndür (veya null)
            return apiResponse.Data?.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"E-posta = {email} için müşteri aranırken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <summary>
    /// Ada göre müşteri arar
    /// </summary>
    /// <param name="name">Müşteri adı veya soyadı</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına müşteri sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Müşteri listesi</returns>
    public async Task<List<Customer>> SearchByNameAsync(string name, int page = 1, int perPage = 20, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Arama terimi boş olamaz", nameof(name));
            
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&q={Uri.EscapeDataString(name)}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Customer>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Customer>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Müşteriler aranırken hata oluştu (Terim: {name}): {ex.Message}", innerException: ex);
        }
    }
}