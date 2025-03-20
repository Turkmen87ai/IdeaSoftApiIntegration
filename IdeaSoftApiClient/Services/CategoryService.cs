using IdeaSoftApiClient.Models;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>
/// IdeaSoft kategori API hizmetleri
/// </summary>
public class CategoryService : BaseApiService<Category>
{
    /// <summary>
    /// Yeni bir kategori servisi oluşturur
    /// </summary>
    /// <param name="httpClient">HTTP istemcisi</param>
    public CategoryService(HttpClient httpClient) 
        : base(httpClient, "categories")
    {
    }
    
    /// <summary>
    /// Üst kategorileri getirir
    /// </summary>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına kategori sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Üst kategorilerin listesi</returns>
    public async Task<List<Category>> GetTopCategoriesAsync(int page = 1, int perPage = 50, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&parent_id=0";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Category>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Category>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Üst kategoriler listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <summary>
    /// Alt kategorileri getirir
    /// </summary>
    /// <param name="parentId">Üst kategori ID'si</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına kategori sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Alt kategorilerin listesi</returns>
    public async Task<List<Category>> GetSubCategoriesAsync(int parentId, int page = 1, int perPage = 50, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&parent_id={parentId}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Category>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Category>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"ParentId = {parentId} için alt kategoriler listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
}