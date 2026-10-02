# IdeaSoft API Integration

IdeaSoft Admin API ile .NET 8 üzerinden çalışmayı kolaylaştıran açık kaynak bir C# istemcisidir. Projenin amacı, OAuth2 sürecini ve günlük API çağrılarını yeni başlayan bir geliştiricinin de takip edebileceği kadar açık hale getirmektir.

> Bu proje IdeaSoft'un resmi SDK'sı değildir. Canlı mağazada yazma veya silme işlemi yapmadan önce test verisiyle deneyin ve gerekli API izinlerini en dar kapsamda verin.

## Neler var?

- Güncel IdeaSoft OAuth2 Authorization Code akışı
- `Bearer` access token ile Admin API çağrıları
- Access token süresi dolmadan otomatik yenileme seçeneği
- 429, 502, 503 ve 504 cevaplarında kontrollü yeniden deneme
- Ürün, kategori, sipariş, üye, marka, sayfa ve tema için hazır istemciler
- Diğer bütün Admin API yolları için genel `SendAsync` ve `Resource<T>` metotları
- Hata kodu, cevap gövdesi ve istek kimliğini taşıyan `ApiException`
- Harici test paketi gerektirmeyen hızlı test projesi

## Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- IdeaSoft mağazasında API özelliği
- Yönetim panelinde oluşturulmuş Client ID, Client Secret ve Redirect URI
- Kullanılacak işlemler için Okuma veya Okuma/Yazma izinleri

IdeaSoft panelinde yalnızca `1` ID'li yönetici kullanıcı API bölümünü görebilir ve düzenleyebilir. Yol: **Entegrasyonlar → API → API Ekle**.

## Projeyi çalıştırma

```bash
git clone https://github.com/Turkmen87ai/IdeaSoftApiIntegration.git
cd IdeaSoftApiIntegration
dotnet build
dotnet run --project IdeaSoftApiClient.Tests
```

Hazır örneği gerçek mağazanızla çalıştırmak için token'ı dosyaya yazmak yerine ortam değişkeni kullanın:

```powershell
$env:IDEASOFT_STORE_URL = "https://magaza-adiniz.myideasoft.com"
$env:IDEASOFT_ACCESS_TOKEN = "ACCESS_TOKEN"
dotnet run --project samples/IdeaSoftApi.Sample
```

## 1. OAuth2 izin adresini oluşturma

IdeaSoft, kullanıcı adı ve parolayı uygulamanıza vermek yerine OAuth2 Authorization Code akışını kullanır.

```csharp
using IdeaSoftApiClient.Authentication;
using IdeaSoftApiClient.Config;

var config = new ApiConfig("https://magaza-adiniz.myideasoft.com");
var oauth = new IdeaSoftOAuthClient(config);

// Bu değeri kullanıcı oturumunda saklayın ve callback'te aynen kontrol edin.
var state = IdeaSoftOAuthClient.CreateState();

var authorizationUrl = oauth.CreateAuthorizationUri(
    clientId: "CLIENT_ID",
    redirectUri: new Uri("https://uygulamaniz.example/ideasoft/callback"),
    state: state);

Console.WriteLine(authorizationUrl);
```

Kullanıcı bu adresi açar, IdeaSoft panelinde izin verir ve Redirect URI adresinize `code` ile `state` gelir. Gelen `state`, daha önce sakladığınız değerle aynı değilse işlemi durdurun.

## 2. Code değerini token ile değiştirme

Callback ile gelen code yalnızca yaklaşık 30 saniye geçerlidir; bekletmeden token isteği gönderin.

```csharp
var token = await oauth.ExchangeCodeAsync(
    clientId: "CLIENT_ID",
    clientSecret: "CLIENT_SECRET",
    code: callbackCode,
    redirectUri: new Uri("https://uygulamaniz.example/ideasoft/callback"));

Console.WriteLine(token.ExpiresAt);
```

Access token yaklaşık 24 saat, refresh token yaklaşık 2 ay geçerlidir. IdeaSoft her yenilemede yeni refresh token da döndürür; eski refresh token'ın üzerine yenisini güvenli biçimde kaydedin.

## 3. API istemcisini kullanma

Elinizde geçerli bir access token varsa en kısa kullanım:

```csharp
using IdeaSoftApiClient;
using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Models;

var config = new ApiConfig("https://magaza-adiniz.myideasoft.com");
using var client = new IdeaSoftClient(config, accessToken: "ACCESS_TOKEN");

var response = await client.Products.ListAsync(page: 1, limit: 20);

foreach (var product in response.Data)
{
    Console.WriteLine($"{product.Id}: {product.Name} - {product.Price}");
}
```

### Filtre kullanma

IdeaSoft sorgu parametreleri kaynağa göre değişir. OpenAPI dokümanında yazan adı aynen kullanın.

```csharp
var filters = new Dictionary<string, string?>
{
    ["status"] = "1",
    ["category"] = "42",
    ["sort"] = "-id"
};

var products = await client.Products.ListAsync(
    page: 1,
    limit: 50,
    filters: filters);
```

### Kayıt getirme, oluşturma, güncelleme ve silme

```csharp
var product = (await client.Products.GetAsync(123)).Data;

var created = await client.Products.CreateAsync(new Product
{
    Name = "Örnek ürün",
    Sku = "ORNEK-001",
    Price = 149.90m,
    StockAmount = 10,
    Status = 1
});

created.Data.Price = 159.90m;
await client.Products.UpdateAsync(created.Data.Id, created.Data);

// Geri alınamaz; canlı mağazada kullanmadan önce ID'yi doğrulayın.
await client.Products.DeleteAsync(created.Data.Id);
```

Hazır kaynaklar: `Products`, `Categories`, `Orders`, `Members`, `Brands`, `Pages` ve `Themes`.

## Otomatik token yenileme

```csharp
var tokenProvider = new RefreshingAccessTokenProvider(
    oauth,
    clientId: "CLIENT_ID",
    clientSecret: "CLIENT_SECRET",
    initialToken: savedToken,
    tokenUpdated: async (newToken, cancellationToken) =>
    {
        // Gerçek uygulamada access ve refresh token'ı şifreli depoya birlikte yazın.
        await SaveTokenSecurelyAsync(newToken, cancellationToken);
    });

using var client = new IdeaSoftClient(config, tokenProvider);
```

Client Secret, access token ve refresh token'ı kaynak koda, Git'e veya loglara yazmayın.

## Dokümandaki bütün endpoint'leri çağırma

Kütüphanede her nesne için yüzlerce ayrı metot bulunması yerine iki genel yol vardır.

Standart CRUD kaynağı:

```csharp
using System.Text.Json;

var sliders = client.Resource<JsonElement>("sliders");
var firstPage = await sliders.ListAsync(limit: 100);
```

Özel operasyon:

```csharp
using System.Text.Json;

var result = await client.SendAsync<JsonElement>(
    HttpMethod.Put,
    "products/123/change_category",
    body: new { category = 42 });
```

`SendAsync` yoluna `admin-api/` eklemeyin; istemci bunu güvenli biçimde kendisi ekler. Mutlak harici URL'ler reddedilir, böylece Bearer token'ın yanlış bir alan adına gönderilmesi önlenir.

## Hata yönetimi

```csharp
using IdeaSoftApiClient.Exceptions;

try
{
    var product = await client.Products.GetAsync(999999);
}
catch (ApiException exception)
{
    Console.WriteLine($"HTTP: {exception.StatusCode}");
    Console.WriteLine($"Kod: {exception.ApiErrorCode}");
    Console.WriteLine($"Mesaj: {exception.ApiErrorMessage}");
    Console.WriteLine($"İstek kimliği: {exception.RequestId}");
}
```

Yaygın durum kodları:

| Kod | Anlamı | Ne yapılmalı? |
|---:|---|---|
| 200 | GET/PUT başarılı | Cevabı işle |
| 201 | POST ile kayıt oluşturuldu | Dönen kaydın ID'sini sakla |
| 204 | DELETE başarılı, gövde yok | Başarılı kabul et |
| 400 | İstek yapısı bozuk | JSON ve parametreleri kontrol et |
| 401 | Token yok/geçersiz | Token'ı yenile |
| 403 | İzin yetersiz | Panelde gerekli kapsamı açtır |
| 404 | Kayıt bulunamadı | ID ve yolu kontrol et |
| 422 | Alan doğrulama hatası | Gönderilen modeli düzelt |
| 429 | Çok sık istek | İstemci otomatik olarak kısa süre bekler |
| 500/503 | Sunucu hatası | Daha sonra tekrar dene ve istek kimliğini kaydet |

## Bir siteyi IdeaSoft'a taşıma hakkında

API; ürün, kategori, marka, sayfa, blog, menü, slider, banner, tema ve tema varlıkları gibi pek çok parçayı yönetebilir. Buna rağmen herhangi bir sitenin HTML/CSS/JavaScript tasarımını tek çağrıyla birebir IdeaSoft temasına dönüştüren bir endpoint yoktur. Sağlıklı taşıma şu sırayla yapılır:

1. Kaynak sitedeki içerik, medya, URL, SEO ve ürün ilişkilerini envanterle.
2. Dosyaları ve görselleri aktar; eski ve yeni URL eşlemesini sakla.
3. Marka, kategori, özellik ve etiket gibi bağımlılıkları oluştur.
4. Ürünleri ve ilişkilerini eski ID → yeni ID eşleme tablosuyla aktar.
5. Sayfa, blog, menü, slider, banner ve site içeriklerini aktar.
6. IdeaSoft tema yapısına uygun bir tema oluşturup tema varlıklarını yükle.
7. URL yönlendirmelerini, canonical adreslerini ve meta alanlarını doğrula.
8. Ödeme, kargo, sözleşme ve kişisel veri içeren alanları panelde ayrıca kontrol et.
9. Önce pasif/test ortamında çalıştır; sayıları ve örnek kayıtları karşılaştırdıktan sonra yayına al.

Tema ve dosya yükleme işlemleri paket/izin kısıtlarına bağlı olabilir. Gerçek taşıma öncesinde güncel kapsamları [IdeaSoft API dokümanından](https://apidoc.ideasoft.dev/) ve IdeaSoft destek ekibinden doğrulayın.

## Kaynak dokümanlar

- [IdeaSoft API kullanımı](https://www.ideasoft.com.tr/yardim/api-kullanimi/)
- [IdeaSoft Admin ve Store API dokümanı](https://apidoc.ideasoft.dev/)
- Repodaki `admin-swagger-prod.json`: Admin API OpenAPI anlık görüntüsü
- Repodaki `swagger.json`: sınırlı/eski Store API anlık görüntüsü

## Güvenlik notları

- OAuth `state` değerini mutlaka doğrulayın.
- Redirect URI panelde kayıtlı değerle birebir aynı olmalıdır.
- Yalnız gereken Okuma veya Okuma/Yazma izinlerini verin.
- Token'ları şifreli depolayın ve hata loglarında maskeleyin.
- Silme ve toplu güncelleme öncesinde yedek alın.
- Üye/sipariş verileri kişisel veri içerebilir; KVKK yükümlülüklerinizi ayrıca değerlendirin.

Otomatik retry varsayılan olarak GET/HEAD/PUT/DELETE/OPTIONS için açıktır. POST tekrarlandığında çift kayıt oluşturabileceği için otomatik denenmez. Yalnız ilgili POST operasyonunun idempotent olduğunu kesin olarak biliyorsanız `ApiConfig.RetryNonIdempotentRequests` ayarını açın.

## Lisans

[MIT](LICENSE)
