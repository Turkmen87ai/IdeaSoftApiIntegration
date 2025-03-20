using IdeaSoftApiClient.Models;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>
/// IdeaSoft sipariş API hizmetleri
/// </summary>
public class OrderService : BaseApiService<Order>
{
    /// <summary>
    /// Yeni bir sipariş servisi oluşturur
    /// </summary>
    /// <param name="httpClient">HTTP istemcisi</param>
    public OrderService(HttpClient httpClient) 
        : base(httpClient, "orders")
    {
    }
    
    /// <summary>
    /// Sipariş durumuna göre filtreler
    /// </summary>
    /// <param name="status">Sipariş durumu (örn: "new", "pending", "completed")</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına sipariş sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Sipariş listesi</returns>
    public async Task<List<Order>> GetByStatusAsync(string status, int page = 1, int perPage = 20, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(status))
            throw new ArgumentException("Sipariş durumu boş olamaz", nameof(status));
            
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&status={Uri.EscapeDataString(status)}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Order>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Order>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Durum = {status} için siparişler listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <summary>
    /// Müşteriye göre siparişleri filtreler
    /// </summary>
    /// <param name="customerId">Müşteri ID'si</param>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına sipariş sayısı</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Sipariş listesi</returns>
    public async Task<List<Order>> GetByCustomerAsync(int customerId, int page = 1, int perPage = 20, CancellationToken cancellationToken = default)
    {
        try
        {
            // URL oluştur
            var url = $"api/{_resourcePath}?page={page}&per_page={perPage}&customer_id={customerId}";
            
            // İsteği gönder
            var response = await _httpClient.GetAsync(url, cancellationToken);
            
            // Yanıtı kontrol et
            response.EnsureSuccessStatusCode();
            
            // Yanıtı deserialize et
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            var apiResponse = JsonSerializer.Deserialize<PagedApiResponse<Order>>(content, _jsonOptions);
            
            if (apiResponse is null)
                throw new Exceptions.ApiException("API yanıtı geçersiz");
                
            if (!apiResponse.IsSuccess)
                throw new Exceptions.ApiException(apiResponse.Message ?? "API hatası", (int)response.StatusCode);
                
            return apiResponse.Data ?? new List<Order>();
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Müşteri ID = {customerId} için siparişler listelenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
    
    /// <summary>
    /// Sipariş durumunu günceller
    /// </summary>
    /// <param name="orderId">Sipariş ID'si</param>
    /// <param name="newStatus">Yeni durum</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Güncellenmiş sipariş</returns>
    public async Task<Order> UpdateStatusAsync(int orderId, string newStatus, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
            throw new ArgumentException("Yeni durum boş olamaz", nameof(newStatus));
            
        try
        {
            // Önce siparişi getir
            var order = await GetByIdAsync(orderId, null, cancellationToken);
            
            // Durumu güncelle
            order.Status = newStatus;
            
            // Güncellemeyi gönder
            return await UpdateAsync(orderId, order, cancellationToken);
        }
        catch (Exception ex) when (ex is not Exceptions.ApiException)
        {
            throw new Exceptions.ApiException($"Sipariş ID = {orderId} için durum güncellenirken hata oluştu: {ex.Message}", innerException: ex);
        }
    }
}