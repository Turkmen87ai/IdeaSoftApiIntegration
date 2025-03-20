# IdeaSoft API Integration Library

Bu kütüphane, IdeaSoft e-ticaret platformu API'si ile kolay entegrasyon sağlamak için geliştirilmiştir. Junior geliştiricilerin kolayca kullanabileceği şekilde tasarlanmıştır.

## Özellikleri

- IdeaSoft API'sine HTTP istekleri gönderme
- JSON veri alma ve gönderme 
- Asenkron metodlar (async/await)
- Basit hata yönetimi
- Çeşitli endpoint'ler için hazır servisler:
  - Ürünler
  - Kategoriler
  - Siparişler
  - Müşteriler

## Kurulum

NuGet üzerinden paket yöneticisi kullanarak:

```bash
Install-Package IdeaSoftApiClient
```

Veya .NET CLI kullanarak:

```bash
dotnet add package IdeaSoftApiClient
```

## Kullanım

### Başlangıç

```csharp
// API yapılandırmasını oluştur
var config = new ApiConfig(
    baseUrl: "https://magaza-adiniz.myideasoft.com", 
    apiKey: "API_ANAHTARI", 
    apiSecret: "API_PAROLASI"
);

// API istemcisini oluştur
using var client = new IdeaSoftClient(config);

// Servisleri kullan
var products = await client.Products.ListAsync();
var categories = await client.Categories.ListAsync();
```

### Ürünlerle Çalışma

```csharp
// Tüm ürünleri listele
var allProducts = await client.Products.ListAsync();

// Belirli bir ürünü getir
var product = await client.Products.GetByIdAsync(123);

// Kategoriye göre ürünleri getir
var categoryProducts = await client.Products.GetByCategoryAsync(categoryId: 5);

// İsme göre ürün ara
var searchResults = await client.Products.SearchByNameAsync("iPhone");

// Yeni ürün oluştur
var newProduct = new Product 
{
    Name = "Test Ürün",
    Code = "TEST001",
    Price = 99.99m,
    Stock = 10,
    CategoryId = 1
};
var createdProduct = await client.Products.CreateAsync(newProduct);

// Ürün güncelle
product.Price = 149.99m;
var updatedProduct = await client.Products.UpdateAsync(product.Id, product);

// Ürün sil
var isDeleted = await client.Products.DeleteAsync(123);
```

### Siparişlerle Çalışma

```csharp
// Tüm siparişleri listele
var allOrders = await client.Orders.ListAsync();

// Belirli bir siparişi getir
var order = await client.Orders.GetByIdAsync(123);

// Duruma göre siparişleri getir
var newOrders = await client.Orders.GetByStatusAsync("new");
var processingOrders = await client.Orders.GetByStatusAsync("processing");

// Müşteriye göre siparişleri getir
var customerOrders = await client.Orders.GetByCustomerAsync(customerId: 42);

// Sipariş durumunu güncelle
var updatedOrder = await client.Orders.UpdateStatusAsync(orderId: 123, newStatus: "completed");
```

### Kategorilerle Çalışma

```csharp
// Tüm kategorileri listele
var allCategories = await client.Categories.ListAsync();

// Belirli bir kategoriyi getir
var category = await client.Categories.GetByIdAsync(5);

// Üst kategorileri getir
var topCategories = await client.Categories.GetTopCategoriesAsync();

// Alt kategorileri getir
var subCategories = await client.Categories.GetSubCategoriesAsync(parentId: 5);
```

### Müşterilerle Çalışma

```csharp
// Tüm müşterileri listele
var allCustomers = await client.Customers.ListAsync();

// Belirli bir müşteriyi getir
var customer = await client.Customers.GetByIdAsync(42);

// E-posta adresine göre müşteri ara
var customerByEmail = await client.Customers.GetByEmailAsync("ornek@email.com");

// Ada göre müşteri ara
var customersByName = await client.Customers.SearchByNameAsync("Ahmet");
```

## Hata Yönetimi

```csharp
try 
{
    var product = await client.Products.GetByIdAsync(99999); // Var olmayan ürün
}
catch (ApiException ex)
{
    Console.WriteLine($"Hata kodu: {ex.StatusCode}");
    Console.WriteLine($"Hata mesajı: {ex.Message}");
    Console.WriteLine($"API hata mesajı: {ex.ApiErrorMessage}");
}
```

## Geliştirme

Bu kütüphane .NET 8.0 için geliştirilmiştir ve aşağıdaki bağımlılıkları kullanır:

- System.Text.Json
- Microsoft.Extensions.Http

## Lisans

Bu kütüphane MIT lisansı altında dağıtılmaktadır.