# IdeaSoft Store API Console Test

Bu uygulama `IdeaSoftStoreClient` sınıfını ayrı olarak test eder. Admin Console Test ile karıştırılmaması için kendi projesi ve komutları vardır.

- Yalnız `/api/products`, `/api/categories` ve `/api/orders` yollarına `GET` gönderir.
- `/admin-api` çağrısı yapmaz.
- Client Secret, access token ve refresh token kaynak koda yazılmaz.
- Token değerlerini ekrana basmaz veya diske kaydetmez.
- Varsayılan `--self-test` modu ağ bağlantısı ve gerçek kimlik bilgisi kullanmaz.

## Çevrimdışı self-test

```powershell
dotnet run --project samples/IdeaSoftStoreApi.ConsoleTest -- --self-test
```

Bu mod şunları doğrular:

1. Mağaza URL'si güvenli biçimde kök adrese çevrilir.
2. OAuth izin URL'si ve `state` doğru üretilir.
3. Bearer token yalnız mağazanın `/api/` yoluna gönderilir.
4. Mutlak harici URL reddedilir.

## Hazır access token ile canlı salt-okunur test

```powershell
$env:IDEASOFT_STORE_URL = "https://magaza-adiniz.myideasoft.com"
$env:IDEASOFT_ACCESS_TOKEN = "ACCESS_TOKEN_DEGERINIZ"

dotnet run --project samples/IdeaSoftStoreApi.ConsoleTest -- --live

Remove-Item Env:IDEASOFT_ACCESS_TOKEN
```

## Authorization code ile canlı test

```powershell
$env:IDEASOFT_STORE_URL = "https://magaza-adiniz.myideasoft.com"
$env:IDEASOFT_CLIENT_ID = "CLIENT_ID_DEGERINIZ"
$env:IDEASOFT_CLIENT_SECRET = "CLIENT_SECRET_DEGERINIZ"
$env:IDEASOFT_REDIRECT_URI = "https://panelde-kayitli-adres.example/callback"

dotnet run --project samples/IdeaSoftStoreApi.ConsoleTest -- --live
```

Uygulama OAuth izin adresini üretir. İzin sonrasında yönlendirilen tam URL konsola yapıştırılır; `state` doğrulanmadan token istenmez.

## Refresh token ile canlı test

Yukarıdaki Client ID, Client Secret ve Redirect URI değişkenlerine ek olarak:

```powershell
$env:IDEASOFT_REFRESH_TOKEN = "REFRESH_TOKEN_DEGERINIZ"

dotnet run --project samples/IdeaSoftStoreApi.ConsoleTest -- --live
```

IdeaSoft yenilemede yeni refresh token döndürebilir. Bu örnek token'ı kalıcı saklamaz. Gerçek uygulama dönen yeni değeri şifreli secret manager içinde eskisinin yerine yazmalıdır.

## Güvenlik sınırı

- Canlı mod yalnız üç GET çağrısı yapar ve her listeden en fazla bir kayıt ister.
- POST, PUT ve DELETE test edilmez.
- Sipariş cevabı kişisel veri içerebilir; uygulama cevap gövdesini yazdırmaz.
- Canlı test kullanıcı açıkça istemedikçe otomatik çalıştırılmamalıdır.
