# LLM bilgi haritası ve çalışma kuralları

Bu dosya farklı kodlama ajanlarının projeyi bozmadan devam edebilmesi için kısa, makinece okunabilir bir başlangıç noktasıdır. İnsan geliştiriciler de aynı sırayı kullanabilir.

Son doğrulama: **2 Ekim 2026**

## Önce okunacak dosyalar

1. Kök [README](../README.md)
2. [Admin API ve Store API rehberi](ADMIN_STORE_API_REHBERI.md)
3. [Webhook rehberi](WEBHOOK_REHBERI.md)
4. [MCP rehberi](MCP_REHBERI.md)
5. Admin kodu değişecekse `IdeaSoftApiClient/IdeaSoftClient.cs`; Store kodu değişecekse `IdeaSoftApiClient/IdeaSoftStoreClient.cs`
6. İlgili örnek değişecekse `samples/AdminApiTest` veya `samples/StoreApiTest` README dosyası

`.ai-workspace` klasörü varsa yerel çalışma protokolü, PRD, sorun günlüğü ve görev kilidi için ayrıca tamamen okunmalıdır. Bu klasör bilerek Git'e gönderilmez ve yeni klonda bulunmayabilir.

## Tek cümlelik mimari

Bu repo .NET 8 ile yazılmış, OAuth2/Bearer kullanan ve dış URL'ye token sızmasını engelleyen iki ayrı istemci sunar: Admin için `IdeaSoftClient`, Store için `IdeaSoftStoreClient`.

## Doğrulanmış sabitler

```yaml
runtime: [dotnet_8, python_3_10_plus]
public_clients:
  admin: IdeaSoftClient
  store: IdeaSoftStoreClient
admin_path_prefix: /admin-api
store_path_prefix: /api
oauth_authorization_path: /panel/auth
oauth_token_path: /oauth/v2/token
oauth_flow: authorization_code
token_header: "Authorization: Bearer <token>"
webhook_management_path: /admin-api/client_webhooks
webhook_signature_header: X-Ideashop-Hmac-Sha256
webhook_signature: Base64(HMAC-SHA256(raw_body, client_secret))
secrets_in_git: forbidden
ai_signature_in_commits: forbidden
mcp_servers:
  dotnet: IdeaSoftApi.Mcp.DotNet
  python: IdeaSoftApi.Mcp.Python
mcp_transport: stdio
mcp_tool_parity: required
mcp_writes_default: disabled
mcp_write_confirmation: IDEASOFT_WRITE_CONFIRMED
```

## Kaynak önceliği

Bir bilgi çelişirse şu sırayı kullanın:

1. İlgili endpoint'in canlı resmi `apidoc.ideasoft.dev` sayfası.
2. Canlı resmi Webhooks/Authentication/HTTP durum sayfaları.
3. `ideasoft.com.tr/yardim` üzerindeki resmi yardım sayfaları.
4. Repodaki `admin-swagger-prod.json` anlık görüntüsü.
5. Repodaki `ideaSoftApi.md` türetilmiş eski metin.
6. `swagger.json`; bu dosya Store için ciddi biçimde eksiktir.

Canlı belgede açıkça yazmayan davranışı “IdeaSoft garantisi” gibi anlatmayın. Gerekirse “uygulama önerisi”, “çıkarım” veya “doğrulama bekliyor” etiketi kullanın.

## Bilinen kapsam ve çelişkiler

| Konu | Gerçek durum | Ajanın davranışı |
|---|---|---|
| Admin canlı kapsam | 903 operasyon / 176 grup | Genel `SendAsync<T>` yeni yolları çağırabilir; yine de endpoint sayfasını kontrol et |
| Yerel Admin snapshot | 875 operasyon / 524 yol | Canlı dokümandan eski olduğunu varsay |
| Store canlı kapsam | 333 operasyon / 74 grup | Yalnız `IdeaSoftStoreClient` ile çağır |
| Yerel `swagger.json` | 6 yol / 11 operasyon | Kod üretim kaynağı olarak kullanma |
| Canlı abonelik topic değerleri | ClientWebhook POST sayfasında 41 | Abonelik doğrulamasında doğrudan endpoint sözleşmesini esas al |
| Alanları belgelenmiş webhook topic'leri | Webhooks genel tablosunda 37 | Payload alanı beklentisinde bu tabloyu esas al |
| Yerel webhook enum'u | 32 | Kapalı enum ile güncel topic'leri engelleme |
| Webhook `fields` | V8'de kaldırıldı | Yeni abonelik gövdesine ekleme |
| Webhook gövdesi | Yalnız değişen alanlar | Tam veri gerekiyorsa `id` ile API'den oku |

## Kesinlikle yapılmaması gerekenler

- `IdeaSoftClient` içindeki Admin tabanını Store desteği adına `/api` olarak değiştirmek.
- Store yolunu `SendAsync` ile mutlak URL olarak çağırmaya çalışmak.
- Client ID/Secret, access token, refresh token veya authorization code'u dosyaya yazmak.
- Token/secret değerini test çıktısına, hata mesajına veya dokümana kopyalamak.
- Kullanıcı açıkça istemeden canlı mağazada POST, PUT veya DELETE çalıştırmak.
- POST isteklerini idempotency kanıtı olmadan otomatik yeniden denemek.
- Webhook JSON'unu HMAC doğrulamasından önce güvenilir kabul etmek.
- Aynı webhook'un yalnız bir kez geleceğini varsaymak.
- Commit mesajına veya trailer alanına yapay zekâ üretim/ortak-yazar imzası eklemek.

## Store API desteğini değiştirirken

1. `IdeaSoftStoreClient` ayrımını koru; Admin istemcinin tabanını değiştirme.
2. Store istemcisinde yalnız `/api` altındaki göreli yolları kabul et.
3. Canlı Store endpoint sayfalarından istek/cevap sözleşmesi çıkar.
4. Admin ve Store modellerini alan alan karşılaştır.
5. Ayrı davranış testlerini ve `StoreApiTest` self-testini güncelle.
6. Secret'ları yalnız ortam değişkeni/secret manager üzerinden al.
7. Canlı yazma testini açık kullanıcı onayı olmadan çalıştırma.

## Webhook alıcısı eklenecekse

1. Ham gövdeyi byte dizisi olarak oku.
2. `X-Ideashop-Hmac-Sha256` değerini Client Secret ile doğrula.
3. Sabit zamanlı karşılaştırma kullan.
4. JSON'u ancak doğrulamadan sonra ayrıştır.
5. Mesajı dayanıklı kuyruğa yaz.
6. 10 saniye içinde `200 OK` dön.
7. Tekrar teslim ve sırasız teslim ihtimaline dayanıklı ol.
8. Aboneliğin otomatik silinmesini algılamak için liste/count izleme planı kur.

## Zorunlu yerel doğrulama

Doküman değişikliği bile olsa en az şu komutlar çalıştırılmalıdır:

```powershell
dotnet build IdeaSoftApiIntegration.sln -c Release -warnaserror
dotnet run --project IdeaSoftApiClient.Tests -c Release
dotnet run --project samples/AdminApiTest -c Release -- --self-test
dotnet run --project samples/StoreApiTest -c Release -- --self-test
dotnet run --project IdeaSoftApi.Mcp.DotNet.Tests -c Release
uv sync --project IdeaSoftApi.Mcp.Python
uv run --project IdeaSoftApi.Mcp.Python python -m unittest discover -s IdeaSoftApi.Mcp.Python/tests -v
git diff --check
git status --short
```

`.ai-workspace/scripts/Invoke-SafeValidation.ps1` varsa:

- Temiz görev başlangıcında `-RequireClean` kullanılır.
- Değişiklik sırasında bayraksız çalıştırılır.
- Commit sonrasında repo yeniden temizken tekrar `-RequireClean` çalıştırılır.

## Commit ve push kontrolü

```text
[ ] Değişiklik yalnız görev kapsamındaki dosyalarda
[ ] Secret/token/authorization code yok
[ ] Build ve testler geçti
[ ] git diff --check geçti
[ ] Staged diff elle incelendi
[ ] Commit subject kısa ve insan tarafından yazılmış
[ ] Yapay zekâ üretim veya ortak-yazar trailer'ı yok
[ ] Push sonrası origin/main SHA yerel HEAD ile aynı
```

## Yeni araştırma nasıl kaydedilir?

Her yeni doğrulamada şu formatı kullanın:

```markdown
### YYYY-MM-DD — Konu

- Kaynak: tam resmi URL
- Gözlenen sürüm/yüzey: Admin | Store | Webhooks
- Doğrulanmış gerçek: ...
- Çıkarım veya öneri: ...
- Belirsiz kalan nokta: ...
- Etkilenen kod/doküman: ...
- Secret veya kişisel veri kaydedildi mi?: Hayır
```

Bu ayrım, sonraki LLM'in doğrulanmış platform davranışını genel yazılım tavsiyesiyle karıştırmasını önler.
