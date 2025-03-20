using IdeaSoftApiClient.Exceptions;
using IdeaSoftApiClient.Models;
using System.Text;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>
/// API servisleri için temel sınıf
/// </summary>
/// <typeparam name="T">Servis tarafından işlenen veri tipi</typeparam>
public abstract class BaseApiService<T> : IApiService<T> where T : class
{
    protected readonly HttpClient _httpClient;
    protected readonly string _resourcePath;
    protected readonly JsonSerializerOptions _jsonOptions;
    
    /// <summary>
    /// Temel API servisini oluşturur
    /// </summary>
    /// <param name="httpClient">HTTP istemcisi</param>
    /// <param name="resourcePath">API kaynak yolu (örn: "products")</param>
    protected BaseApiService(HttpClient httpClient, string resourcePath)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _resourcePath = resourcePath.Trim('/');
        
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
    }
    
    /// <inheritdoc/>
    public virtual async Task<T> GetByIdAsync(int id, string[]? includes = null, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}/{id}";
            
            // İlişkisel veri ekle (varsa)
            if (includes is { Length: > 0 })
            {
                url += $"?includes={string.Join(",", includes)}";
            }
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<T>>(content, _jsonOptions);
            
            if (apiResponse is null || apiResponse.Data is null)
                throw new ApiException($"Kayıt bulunamadı: ID = {id}");
                
            if (!apiResponse.IsSuccess)
                throw new ApiException(apiResponse.Message ?? $"API hatası: ID = {id}", (int)response.StatusCode);
                
            return apiResponse.Data;
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            throw new ApiException($"{id} ID'li kayıt getirilirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <inheritdoc/>
    public virtual async Task<List<T>> ListAsync(int page = 1, int perPage = 20, string[]? includes = null, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}";
            
            // İlişkisel veri ekle (varsa)
            if (includes is { Length: > 0 })
            {
                url += $"&includes={string.Join(",", includes)}";
            }
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<T>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<T>();
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            throw new ApiException($"Kayıtlar listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <inheritdoc/>
    public virtual async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}";
            
            // JSON oluştur
            var json = JsonSerializer.Serialize(entity, _jsonOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            // İsteği gönder
            var response = await _httpClient.PostAsync(url, content, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<T>>(responseContent, _jsonOptions);
            
            if (apiResponse is null || apiResponse.Data is null)
                throw new ApiException("Kayıt oluşturulamadı");
                
            if (!apiResponse.IsSuccess)
                throw new ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data;
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            throw new ApiException($"Kayıt oluşturulurken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <inheritdoc/>
    public virtual async Task<T> UpdateAsync(int id, T entity, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}/{id}";
            
            // JSON oluştur
            var json = JsonSerializer.Serialize(entity, _jsonOptions);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            // İsteği gönder
            var response = await _httpClient.PutAsync(url, content, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<ApiResponse<T>>(responseContent, _jsonOptions);
            
            if (apiResponse is null || apiResponse.Data is null)
                throw new ApiException($"Kayıt güncellenemedi: ID = {id}");
                
            if (!apiResponse.IsSuccess)
                throw new ApiException(apiResponse.Message ?? $"API hatası: ID = {id}", (int)response.StatusCode);
                
            return apiResponse.Data;
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            throw new ApiException($"{id} ID'li kayıt güncellenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <inheritdoc/>
    public virtual async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}/{id}";
            
            // İsteği gönder
            var response = await _httpClient.DeleteAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et (basit yanıt bekleniyor)
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            
            // Başarı durumunu döndür
            return !string.IsNullOrEmpty(content) && content.Contains("success");
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            throw new ApiException($"{id} ID'li kayıt silinirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
}