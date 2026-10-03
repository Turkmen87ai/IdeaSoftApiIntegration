# IdeaSoftApi MCP rehberi

Son güncelleme: **2 Ekim 2026**

Bu repo aynı yetenekleri sunan iki ayrı yerel MCP sunucusu içerir:

| Proje | Çalışma zamanı | Başlatma |
|---|---|---|
| `IdeaSoftApi.Mcp.DotNet` | .NET 8 | `dotnet run --project IdeaSoftApi.Mcp.DotNet -c Release` |
| `IdeaSoftApi.Mcp.Python` | Python 3.10+ | `uv run --project IdeaSoftApi.Mcp.Python ideasoftapi-mcp` |

İki sunucu da `stdio` kullanır. Bir MCP istemcisi sunucuyu alt süreç olarak başlatır ve araç çağrılarını standart giriş/çıkış üzerinden iletir. Normal bir konsol menüsü beklenmez.

## Junior geliştirici için kısa açıklama

MCP sunucusu, bir yapay zekâ uygulamasının IdeaSoft API'ye kontrollü biçimde erişmesini sağlayan bir adaptördür. MCP kendi başına yeni bir IdeaSoft yetkisi oluşturmaz. Paneldeki API uygulamasının izinleri ve OAuth token'ının yetkileri neyse sunucu da yalnız onları kullanabilir.

Akış şöyledir:

1. MCP istemcisi .NET veya Python sunucusunu başlatır.
2. Sunucu mağaza adresi ve token gibi bilgileri ortam değişkenlerinden okur.
3. İstemci bir aracı çağırır; örneğin `ideasoft_list`.
4. Sunucu `surface=admin` ise `/admin-api/`, `surface=store` ise `/api/` tabanını seçer.
5. Bearer token ile IdeaSoft'a istek yapılır ve yapılandırılmış sonuç döner.

## Araç sözleşmesi

İki uygulama aşağıdaki 12 araç adını ortak kullanır:

| Araç | Amaç | Varsayılan etkisi |
|---|---|---|
| `ideasoft_status` | Secret göstermeden yapılandırma durumunu verir | Yerel, salt okunur |
| `ideasoft_authorization_url` | OAuth izin URL'si ve rastgele `state` üretir | Yerel, salt okunur |
| `ideasoft_list` | Bir Admin veya Store kaynağını sayfalı listeler | GET |
| `ideasoft_get` | Kaynak ve ID ile tek kayıt getirir | GET |
| `ideasoft_request` | Belgelenmiş göreli yolda genel istek yapar | GET veya kilitli yazma |
| `ideasoft_webhook_list` | Webhook aboneliklerini listeler | GET |
| `ideasoft_webhook_create` | Webhook aboneliği oluşturur | Kilitli POST |
| `ideasoft_webhook_update` | Webhook aboneliğini günceller | Kilitli PUT |
| `ideasoft_webhook_delete` | Webhook aboneliğini siler | Kilitli DELETE |
| `ideasoft_verify_webhook` | Ham gövde ile Base64 HMAC değerini karşılaştırır | Yerel doğrulama |
| `ideasoft_capabilities` | Sunucunun kapsam ve güvenlik kurallarını açıklar | Yerel, salt okunur |
| `ideasoft_migration_checklist` | Site taşıma iş sırasını verir | Yerel, salt okunur |

Sunucular ayrıca şu üç okunabilir MCP kaynağını yayınlar:

- `ideasoft://guide/capabilities`
- `ideasoft://guide/security`
- `ideasoft://guide/migration`

## Admin ve Store yüzeyini seçme

`surface` parametresi yalnız `admin` veya `store` olabilir.

```text
surface=admin + path=products/42  → /admin-api/products/42
surface=store + path=products/42  → /api/products/42
```

`path` alanına `/admin-api`, `/api`, tam URL, sorgu dizesi veya `..` eklemeyin. Sorgu değerlerini ayrı `query`/`queryJson` alanından verin. Bu kural Bearer token'ın başka bir alan adına yanlışlıkla gönderilmesini engeller.

Admin ve Store aynı şey değildir. Admin API mağazanın yönetim ve entegrasyon yüzeyidir; Store API mağaza/vitrin senaryolarına ait ayrı bir sözleşmedir. Aynı adlı kaynakların alanları ve desteklediği operasyonlar farklı olabilir. Endpoint'i seçmeden önce [Admin ve Store karşılaştırmasını](ADMIN_STORE_API_REHBERI.md) okuyun.

## “Tüm özellikleri kapsar” ne demektir?

Canlı dokümanda yüzlerce operasyon vardır. Her operasyon için ayrı MCP aracı üretmek yerine `ideasoft_request`, Admin ve Store tarafındaki belgelenmiş bütün güvenli göreli yolları çağırabilecek genel geçit olarak tasarlanmıştır. `list`, `get` ve webhook araçları sık kullanılan işlemleri basitleştirir.

Bu yaklaşım şu anlama gelmez:

- Bilinmeyen endpoint veya alanlar otomatik tahmin edilmez.
- API paketinizde bulunmayan yetkiler aşılmaz.
- Bir web sitesinin HTML/CSS tasarımı tek API çağrısıyla IdeaSoft temasına çevrilmez.
- Canlı dokümandaki endpoint sözleşmesini kontrol etme gereği ortadan kalkmaz.

Özel bir operasyon için önce resmi endpoint sayfasından HTTP metodunu, yolu, gövdeyi ve izinleri doğrulayın; sonra genel aracı kullanın.

## Ortam değişkenleri

| Değişken | Açıklama |
|---|---|
| `IDEASOFT_STORE_URL` | `https://magazaniz.myideasoft.com` biçimindeki mağaza kökü |
| `IDEASOFT_ACCESS_TOKEN` | Hazır access token; varsa doğrudan kullanılır |
| `IDEASOFT_CLIENT_ID` | OAuth izin URL'si veya refresh akışı için |
| `IDEASOFT_CLIENT_SECRET` | Refresh akışı ve webhook HMAC kontrolü için |
| `IDEASOFT_REDIRECT_URI` | Panelde kayıtlı OAuth callback adresi |
| `IDEASOFT_REFRESH_TOKEN` | Access token verilmediyse yenileme için |
| `IDEASOFT_MCP_ALLOW_WRITES` | Yalnız `true` veya `1` ise yazma kilidinin ilk aşaması açılır |
| `IDEASOFT_MCP_TIMEOUT_SECONDS` | İstek zaman aşımı; varsayılan 100, sınır 1-600 |
| `IDEASOFT_MCP_MAX_RETRY_COUNT` | Yeniden deneme sayısı; varsayılan 3, sınır 0-10 |

Secret değerleri kaynak koduna, `.env` dosyasına, paylaşılabilir MCP yapılandırmasına veya Git'e yazılmamalıdır. İşletim sistemi ya da MCP istemcisinin güvenli secret mekanizmasını kullanın.

## Yazma güvenliği

POST, PUT ve DELETE için iki koşul aynı anda gerekir:

1. Sunucu ortamında `IDEASOFT_MCP_ALLOW_WRITES=true` olmalıdır.
2. Araç çağrısındaki onay değeri tam olarak `IDEASOFT_WRITE_CONFIRMED` olmalıdır.

Bu bir yetkilendirme sistemi değil, kazara yazmayı azaltan ek güvenlik kapısıdır. IdeaSoft panel izinlerini en dar kapsamda tutmaya devam edin. DELETE çağrısından önce mağaza alan adını ve kayıt ID'sini insan gözüyle kontrol edin.

POST otomatik yeniden denenmez; aksi halde ağ kesintisinde aynı kayıt iki kez oluşabilir. GET, PUT ve DELETE yalnız 429, 502, 503 ve 504 yanıtlarında sınırlı olarak yeniden denenebilir.

## Webhook güvenliği

Webhook abonelikleri Admin API'deki `client_webhooks` kaynağından yönetilir. Gelen bildirimi işlerken:

1. HTTP gövdesini değiştirmeden ham metin/byte olarak alın.
2. `X-Ideashop-Hmac-Sha256` başlığındaki Base64 değeri alın.
3. `ideasoft_verify_webhook` ile HMAC'i doğrulayın.
4. Yalnız sonuç geçerliyse JSON'u ayrıştırın ve işleyin.

Araç Client Secret'ı parametre olarak kabul etmez; ortamdan okur ve sonucu yalnız `isValid` olarak döndürür. Ayrıntılı topic ve teslim davranışı için [Webhook rehberine](WEBHOOK_REHBERI.md) bakın.

## OAuth notları

`ideasoft_authorization_url` URL ile birlikte rastgele bir `state` döndürür. Bu değeri kullanıcı oturumunda saklayın ve callback'ten dönen `state` ile sabit biçimde karşılaştırın. Authorization code kısa ömürlüdür; token değişimini geciktirmeyin.

Access token doğrudan verilmezse iki sunucu da Client ID, Client Secret ve Refresh Token ile bellekte token yenileyebilir. Dönen yeni refresh token yalnız süreç belleğinde tutulur. Kalıcı üretim sistemi kurarken yeni token çiftini şifreli bir secret deposuna yazan ayrı yaşam döngüsü tasarlayın.

## Geliştirme ve çevrimdışı doğrulama

```powershell
dotnet build IdeaSoftApiIntegration.sln -c Release -warnaserror
dotnet run --project IdeaSoftApi.Mcp.DotNet.Tests -c Release
uv sync --project IdeaSoftApi.Mcp.Python
uv run --project IdeaSoftApi.Mcp.Python python -m unittest discover -s IdeaSoftApi.Mcp.Python/tests -v
```

Bu testler sahte HTTP yanıtları kullanır; gerçek mağazaya bağlanmaz. Canlı test ancak kullanıcı açıkça istediğinde, kimlik bilgileri güvenli ortam değişkenlerinde bulunduğunda ve yöntem salt okunur olduğunda yapılmalıdır.

## MCP istemci örnekleri

`samples/McpDotNetTest` resmi .NET MCP SDK'sını, `samples/McpPythonTest` resmi Python MCP SDK'sını kullanır. Her iki istemci de hem .NET hem Python sunucusunu gerçek `stdio` protokolü üzerinden başlatabilir. Böylece aynı araç sözleşmesinin iki çalışma zamanı arasında uyumlu olduğu dört yönde doğrulanır:

| İstemci | Sunucu | Komut |
|---|---|---|
| .NET 8 | .NET 8 | `dotnet run --project samples/McpDotNetTest -c Release -- --server dotnet` |
| .NET 8 | Python | `dotnet run --project samples/McpDotNetTest -c Release -- --server python` |
| Python | Python | `uv run --offline --project samples/McpPythonTest ideasoftapi-mcp-python-test --server python` |
| Python | .NET 8 | `uv run --offline --project samples/McpPythonTest ideasoftapi-mcp-python-test --server dotnet` |

Önce `dotnet build IdeaSoftApiIntegration.sln -c Release -warnaserror`, `uv sync --project IdeaSoftApi.Mcp.Python` ve `uv sync --project samples/McpPythonTest` çalıştırın. Her örnek aşağıdakileri doğrular:

1. Beklenen 12 MCP aracı keşfediliyor.
2. Beklenen 3 MCP kaynağı keşfediliyor.
3. `ideasoft_capabilities` yapılandırılmış sonuç döndürüyor.
4. `ideasoft_status`, yazmanın kapalı ve secret dönüşünün engelli olduğunu gösteriyor.
5. `ideasoft_migration_checklist` adımları ve güvenlik kurallarını döndürüyor.
6. `ideasoft://guide/security` kaynağı okunabiliyor.

Bu örnekler canlı Admin veya Store endpoint'i çağırmaz. Alt sürece yalnız işletim sistemi için gereken sınırlı ortam değişkenleri aktarılır; `IDEASOFT_*` değişkenleri özellikle dışarıda bırakılır. Bu nedenle geliştiricinin terminalinde Client ID, Client Secret veya token tanımlı olsa bile örnek MCP sunucusuna geçmez.

## Birden fazla araçla devam etme kuralları

Başka bir geliştirme aracı projeyi değiştirmeden önce:

1. Bu dosyayı, kök README'yi, Admin/Store ve Webhook rehberlerini okusun.
2. .NET ve Python araç adları ile parametre anlamlarını eş zamanlı korusun.
3. Bir uygulamaya araç eklerse diğerine de eşdeğerini ve çevrimdışı testini eklesin.
4. Secret içeren fixture, çıktı veya örnek commit etmesin.
5. Canlı POST/PUT/DELETE çalıştırmasın.
6. Her iki test paketini ve çözüm derlemesini çalıştırmadan teslim vermesin.

## Resmi MCP SDK kaynakları

- [.NET MCP SDK](https://github.com/modelcontextprotocol/csharp-sdk)
- [Python MCP SDK](https://github.com/modelcontextprotocol/python-sdk)

Her iki uygulama da ilgili resmi SDK'nın stdio sunucu modelini kullanır.
