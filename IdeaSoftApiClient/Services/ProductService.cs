using IdeaSoftApiClient.Models;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>
/// IdeaSoft ürün API hizmetleri
/// </summary>
public class ProductService : BaseApiService<Product>
{
    /// <summary>
    /// Yeni bir ürün servisi oluşturur
    /// </summary>
    /// <param name="httpClient">HTTP istemcisi</param>
    public ProductService(HttpClient httpClient) 
        : base(httpClient, "products")
    {
    }
    
    /// <summary>
    /// Ürünleri kategoriye göre filtreler
    /// </summary>
    /// <param name="categoryId">Kategori ID'si</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına ürün sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Ürün listesi</returns>
    public async Task<List<Product>> GetByCategoryAsync(int categoryId, int page = 1, int perPage = 20, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&category_id={categoryId}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Product>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Product>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Kategori ID = {categoryId} için ürünler listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <summary>
    /// Ürünleri ada göre arar
    /// </summary>
    /// <param name="searchTerm">Arama terimi</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına ürün sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Ürün listesi</returns>
    public async Task<List<Product>> SearchByNameAsync(string searchTerm, int page = 1, int perPage = 20, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            throw new ArgumentException("Arama terimi boş olamaz", nameof(searchTerm));
            
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&q={Uri.EscapeDataString(searchTerm)}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Product>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Product>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Ürünler aranırken hata oluştu (Terim: {searchTerm}): {ex.Message}", innerException: ex);
        }
    }
}