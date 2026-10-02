# AdminApiTest — IdeaSoft Admin API Test Örneği

Bu uygulama gerçek bir IdeaSoft mağazasında OAuth ve yalnız Admin API (`/admin-api`) bağlantısını güvenli biçimde doğrular. Store API için ayrı [StoreApiTest](../StoreApiTest/README.md) projesini kullanın.

- Ürün, kategori ve sipariş uçlarına yalnızca `GET` isteği gönderir.
- Client Secret, access token ve refresh token kaynak koda yazılmaz.
- Token değerlerini ekrana basmaz veya diske kaydetmez.
- Ortam değişkenleri işlem bittiğinde terminal oturumundan temizlenebilir.

## Kendi geliştirmelerimizi test etme

Varsayılan mod ağ bağlantısı ve gerçek kimlik bilgisi kullanmadan kütüphaneyi sınar:

```powershell
dotnet run --project samples/AdminApiTest -- --self-test
```

Bu mod mağaza URL normalizasyonunu, OAuth izin URL'sini ve state değerini, Bearer başlığını, `/admin-api/` yolunu ve harici URL'ye token sızdırma engelini test eder. `/api/` Store yolu bu uygulamanın kapsamında değildir.

Yerel kontrollerden sonra gerçek mağaza testini de çalıştırmak için:

```powershell
dotnet run --project samples/AdminApiTest -- --all
```

## Seçenek 1: Hazır access token ile test

```powershell
$env:IDEASOFT_STORE_URL = "https://magaza-adiniz.myideasoft.com"
$env:IDEASOFT_ACCESS_TOKEN = "ACCESS_TOKEN_DEGERINIZ"

dotnet run --project samples/AdminApiTest -- --live

Remove-Item Env:IDEASOFT_ACCESS_TOKEN
```

Bu yöntemde Client ID ve Client Secret gerekmez.

## Seçenek 2: OAuth authorization code ile test

Panelde kayıtlı yönlendirme adresi ile `IDEASOFT_REDIRECT_URI` birebir aynı olmalıdır.

```powershell
$env:IDEASOFT_STORE_URL = "https://magaza-adiniz.myideasoft.com"
$env:IDEASOFT_CLIENT_ID = "CLIENT_ID_DEGERINIZ"
$env:IDEASOFT_CLIENT_SECRET = "CLIENT_SECRET_DEGERINIZ"
$env:IDEASOFT_REDIRECT_URI = "https://panelde-kayitli-adres.example/callback"

dotnet run --project samples/AdminApiTest -- --live

Remove-Item Env:IDEASOFT_CLIENT_ID
Remove-Item Env:IDEASOFT_CLIENT_SECRET
```

Uygulama bir izin adresi üretir. Bu adresi tarayıcıda açın, izin verin ve yönlendirildiğiniz tam URL'yi konsola yapıştırın. `state` değeri doğrulandıktan sonra authorization code token ile değiştirilir.

## Seçenek 3: Refresh token ile test

Yukarıdaki Client ID ve Client Secret değişkenlerine ek olarak:

```powershell
$env:IDEASOFT_REFRESH_TOKEN = "REFRESH_TOKEN_DEGERINIZ"

dotnet run --project samples/AdminApiTest -- --live

Remove-Item Env:IDEASOFT_REFRESH_TOKEN
```

IdeaSoft yenileme sırasında yeni bir refresh token döndürür. Bu test uygulaması güvenlik nedeniyle yeni token'ı kalıcı olarak saklamaz; gerçek uygulamada yeni değeri şifreli secret manager içinde eskisinin yerine kaydedin.

## Güvenlik

- Gerçek kimlik bilgilerini `.env`, `appsettings.json`, kaynak kod, ekran görüntüsü veya Git commit'i içine koymayın.
- Paylaşılan bilgisayarda ortam değişkenlerini testten sonra temizleyin.
- Konsol geçmişini ve CI loglarını herkese açık paylaşmayın.
- Yazma/silme testi gerekiyorsa bunu ayrı bir test mağazasında ve açık onayla yapın.
