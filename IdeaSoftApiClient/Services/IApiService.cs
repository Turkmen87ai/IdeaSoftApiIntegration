namespace IdeaSoftApiClient.Services;

/// <summary>
/// Tüm API servisleri için temel arayüz
/// </summary>
/// <typeparam name="T">Hizmet tarafından işlenen veri tipi</typeparam>
public interface IApiService<T> where T : class
{
    /// <summary>
    /// ID ile kayıt getirir
    /// </summary>
    /// <param name="id">Kayıt ID'si</param>
    /// <param name="includes">İlişkisel veriyi dahil etmek için parametreler (varsa)</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Bulunan kayıt</returns>
    Task<T> GetByIdAsync(int id, string[]? includes = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Tüm kayıtları listeler
    /// </summary>
    /// <param name="page">Sayfa numarası</param>
    /// <param name="perPage">Sayfa başına kayıt sayısı</param>
    /// <param name="includes">İlişkisel veriyi dahil etmek için parametreler (varsa)</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Kayıtların listesi</returns>
    Task<List<T>> ListAsync(int page = 1, int perPage = 20, string[]? includes = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Yeni kayıt oluşturur
    /// </summary>
    /// <param name="entity">Oluşturulacak kayıt</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Oluşturulan kayıt</returns>
    Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Kayıt günceller
    /// </summary>
    /// <param name="id">Güncellenecek kayıt ID'si</param>
    /// <param name="entity">Güncel veriler</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>Güncellenen kayıt</returns>
    Task<T> UpdateAsync(int id, T entity, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Kayıt siler
    /// </summary>
    /// <param name="id">Silinecek kayıt ID'si</param>
    /// <param name="cancellationToken">İptal belirteci</param>
    /// <returns>İşlem başarılı mı</returns>
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}