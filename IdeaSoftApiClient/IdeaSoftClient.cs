using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;
using IdeaSoftApiClient.Services;
using System.Net.Http.Headers;
using System.Text;

namespace IdeaSoftApiClient;

/// <summary>
/// IdeaSoft API istemcisi
/// </summary>
public class IdeaSoftClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly ApiConfig _config;
    private bool _disposed;
    
    /// <summary>
    /// Ürün API hizmetleri
    /// </summary>
    public ProductService Products { get; }
    
    /// <summary>
    /// Kategori API hizmetleri
    /// </summary>
    public CategoryService Categories { get; }
    
    /// <summary>
    /// Sipariş API hizmetleri
    /// </summary>
    public OrderService Orders { get; }
    
    /// <summary>
    /// Müşteri API hizmetleri
    /// </summary>
    public CustomerService Customers { get; }
    
    /// <summary>
    /// Marka API hizmetleri
    /// </summary>
    public BrandService Brands { get; }
    
    /// <summary>
    /// Ödeme yöntemi API hizmetleri
    /// </summary>
    public PaymentMethodService PaymentMethods { get; }
    
    /// <summary>
    /// Kargo yöntemi API hizmetleri
    /// </summary>
    public ShippingMethodService ShippingMethods { get; }
    
    /// <summary>
    /// Bölge API hizmetleri
    /// </summary>
    public RegionService Regions { get; }
    
    /// <summary>
    /// IdeaSoft API istemcisini oluşturur
    /// </summary>
    /// <param name="config">API yapılandırması</param>
    public IdeaSoftClient(ApiConfig config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
        
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(_config.BaseUrl),
            Timeout = TimeSpan.FromMilliseconds(_config.TimeoutMs)
        };
        
        // HTTP Basic Authentication için kimlik bilgilerini ayarla
        var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_config.ApiKey}:{_config.ApiSecret}"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
        
        // Servis sınıflarını başlat
        Products = new ProductService(_httpClient);
        Categories = new CategoryService(_httpClient);
        Orders = new OrderService(_httpClient);
        Customers = new CustomerService(_httpClient);
        Brands = new BrandService(_httpClient);
        PaymentMethods = new PaymentMethodService(_httpClient);
        ShippingMethods = new ShippingMethodService(_httpClient);
        Regions = new RegionService(_httpClient);
    }
    
    /// <summary>
    /// IdeaSoft API istemcisini oluşturur (DI ile)
    /// </summary>
    /// <param name="httpClient">HttpClient örneği</param>
    /// <param name="config">API yapılandırması</param>
    public IdeaSoftClient(HttpClient httpClient, ApiConfig config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        
        // URL'i ayarla
        _httpClient.BaseAddress = new Uri(_config.BaseUrl);
        
        // HTTP Basic Authentication için kimlik bilgilerini ayarla
        var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_config.ApiKey}:{_config.ApiSecret}"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
        
        // Servis sınıflarını başlat
        Products = new ProductService(_httpClient);
        Categories = new CategoryService(_httpClient);
        Orders = new OrderService(_httpClient);
        Customers = new CustomerService(_httpClient);
        Brands = new BrandService(_httpClient);
        PaymentMethods = new PaymentMethodService(_httpClient);
        ShippingMethods = new ShippingMethodService(_httpClient);
        Regions = new RegionService(_httpClient);
    }
    
    /// <summary>
    /// Kaynakları temizler
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    /// <summary>
    /// Kaynakları temizler
    /// </summary>
    /// <param name="disposing">Yönetilen kaynakları temizlenecek mi</param>
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;
            
        if (disposing)
        {
            _httpClient.Dispose();
        }
        
        _disposed = true;
    }
}