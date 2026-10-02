# IdeaSoft Webhook rehberi

Bu belge, IdeaSoft webhook'larını .NET 8/C# ile güvenli biçimde almak ve yönetmek için hazırlanmıştır. Resmi dokümanda açıkça yazan bilgiler ile üretim ortamı için önerilen uygulamalar özellikle ayrılmıştır.

Son canlı doküman incelemesi: **2 Ekim 2026**

## Webhook nedir?

Normal API kullanımında uygulamanız IdeaSoft'a “ürün değişti mi?” diye istek gönderir. Buna polling denir. Webhook kullanımında ise IdeaSoft, desteklenen bir olay gerçekleştiğinde sizin HTTPS adresinize `POST` isteği gönderir.

Basit akış:

```text
IdeaSoft'ta olay oluşur
        ↓
IdeaSoft sizin webhook adresinize POST gönderir
        ↓
Uygulamanız HMAC imzasını doğrular
        ↓
Mesajı güvenli kuyruğa/kayda alır
        ↓
10 saniye dolmadan HTTP 200 döner
        ↓
Gerekirse gelen id ile tam nesne API'den okunur
```

Webhook, Store API'nin altında bir endpoint grubu değildir. Canlı dokümanda ayrı bir **Webhooks** bölümü vardır; abonelik kayıtları Admin API'deki `/admin-api/client_webhooks` kaynağından yönetilir.

## Resmi dokümandan doğrulanan davranışlar

- IdeaSoft hedef adrese `POST` gönderir.
- V8'de yalnız değeri değişen alanlar gönderilir.
- Daha fazla veri gerekiyorsa gelen `id` ile API çağrısı yapılmalıdır.
- Eski `fields` seçimi V8'de kaldırılmıştır.
- İstekle birlikte `X-Ideashop-Hmac-Sha256` başlığı gönderilir.
- İmza, ham istek gövdesi ve uygulamanın `client_secret` değeriyle HMAC-SHA256 üretilip Base64'e çevrilerek doğrulanır.
- IdeaSoft her denemede yanıt için 10 saniye bekler.
- `200 OK` alınana veya sistemde tanımlı deneme sayısına ulaşılana kadar yeniden gönderim yapılır.
- Tanımlı deneme sayısı aşılırsa webhook aboneliği otomatik silinir.
- Resmi sayfa maksimum deneme sayısını, denemeler arasındaki beklemeyi ve teslim sırası garantisini yayımlamaz.

Son üç belirsizlik nedeniyle alıcı kod tekrar gelen mesajlara dayanıklı olmalıdır. Aboneliklerin varlığı ayrıca izlenmelidir.

## Abonelik yönetimi

Abonelik işlemleri Admin API'dedir:

| Amaç | Metot ve yol | OAuth kapsamı | Başarılı cevap |
|---|---|---|---:|
| Listele | `GET /admin-api/client_webhooks` | `api_read` | 200 |
| Oluştur | `POST /admin-api/client_webhooks` | `api_create` | 201 |
| Say | `GET /admin-api/client_webhooks/count` | `api_read` | 200 |
| Tek kayıt getir | `GET /admin-api/client_webhooks/{id}` | `api_read` | 200 |
| Güncelle | `PUT /admin-api/client_webhooks/{id}` | `api_update` | 200 |
| Sil | `DELETE /admin-api/client_webhooks/{id}` | `api_delete` | 204 |

### V8 için oluşturma örneği

```http
POST https://magaza-adiniz.myideasoft.com/admin-api/client_webhooks
Authorization: Bearer ACCESS_TOKEN
Content-Type: application/json
```

```json
{
  "topic": "product/create",
  "address": "https://uygulamaniz.example/webhooks/ideasoft/product-create",
  "status": 1
}
```

Alanlar:

| Alan | Zorunlu | Anlamı |
|---|---|---|
| `topic` | Evet | Dinlenecek olay adı |
| `address` | Evet | IdeaSoft'un POST göndereceği HTTPS adresi |
| `status` | Evet | `1` aktif, `0` pasif |
| `fields` | Hayır/eski | V8'de kaldırıldı; yeni kodda gönderilmemeli |
| `id` | Cevapta | Abonelik kaydının kimliği |
| `createdAt`, `updatedAt` | Cevapta | Oluşturma ve güncelleme zamanı |

## Güncel V8 olayları ve gönderilebilen alanlar

Aşağıdaki tablo canlı Webhooks sayfasından çıkarılmıştır. “Alanlar” sütunu tam nesne garantisi değildir; sadece ilgili olay için yayımlanan V8 alan listesidir. Güncelleme olayında yalnız değişen alanların gelebileceğini unutmayın.

| Olay grubu | Topic'ler | V8 alanları |
|---|---|---|
| Marka | `brand/create`, `brand/update`, `brand/delete` | `id`, `name`, `slug`, `status`, `updatedAt`, `createdAt` |
| Kategori | `category/create`, `category/update`, `category/delete` | `id`, `name`, `slug`, `status`, `updatedAt`, `createdAt` |
| Ek tercih | `extra_pref/update` | `exclude_tax_abroad` |
| Üye | `member/create`, `member/update`, `member/delete` | `id`, `firstname`, `surname`, `email`, `status`, `kvkkStatus`, `allowedToPhone`, `allowedToCampaigns`, `allowedToSms`, `mobilePhoneNumber`, `address`, `location`, `country`, `zipCode`, `lastIp`, `gender`, `birthDate`, `updatedAt`, `createdAt` |
| Üye grubu | `member_group/create`, `member_group/update`, `member_group/delete` | `id`, `name` |
| Sipariş | `order/create`, `order/update`, `order/delete` | `id`, `customerFirstname`, `customerSurname`, `status`, `amount`, `paymentStatus`, `customerEmail`, `customerPhone`, `paymentTypeName`, `paymentProviderCode`, `paymentProviderName`, `paymentGatewayCode`, `paymentGatewayName`, `bankName`, `currency`, `currencyRates`, `couponDiscount`, `taxAmount`, `totalCustomTaxAmount`, `promotionDiscount`, `generalAmount`, `shippingAmount`, `finalAmount`, `additionalServiceAmount`, `installment`, `installmentRate`, `extraInstallment`, `transactionId`, `hasUserNote`, `errorMessage`, `referrer`, `useGiftPackage`, `usePromotion`, `shippingProviderCode`, `shippingTrackingCode`, `shippingAddress`, `billingAddress`, `orderItems`, `createdAt`, `updatedAt` |
| İade talebi | `order_refund_request/create`, `order_refund_request/update`, `order_refund_request/delete` | `id`, `code`, `status`, `fee`, `updatedAt`, `createdAt` |
| Ürün | `product/create`, `product/update`, `product/delete` | `id`, `name`, `fullName`, `barcode`, `brand`, `categories`, `stockTypeLabel`, `digitalProduct`, `hasOption`, `slug`, `sku`, `status`, `stockAmount`, `price1`, `updatedAt`, `createdAt` |
| Ödeme | `payment/create`, `payment/update`, `payment/delete` | `id`, `transactionId`, `memberFirstname`, `memberSurname`, `status`, `amount`, `updatedAt`, `createdAt` |
| Tema | `theme/create`, `theme/update`, `theme/delete` | `id`, `name`, `status`, `version`, `updatedAt`, `createdAt` |
| Kuyruk işlemi | `queue_process/create`, `queue_process/update` | `id`, `type`, `status`, `updatedAt`, `createdAt` |
| E-posta listesi | `maillist/create`, `maillist/update`, `maillist/delete` | `id`, `name`, `email`, `lastMailSentDate`, `creatorIpAddress`, `maillistGroup` |
| Para birimi | `currency/update` | `id`, `status`, `label`, `buyingPrice`, `sellingPrice`, `updatedAt` |
| Fiyat kuralı | `price_rule/create`, `price_rule/update`, `price_rule/delete` | `id`, `name` |

Webhooks genel sayfasında alanlarıyla açıklanan toplam **37 topic** vardır.

### Canlı abonelik endpoint'indeki 41 değer

Doğrudan [ClientWebhook POST](https://apidoc.ideasoft.dev/docs/admin-api/404iksebffzqg-client-webhook-post) sayfası ise `topic` için **41 allowed value** gösterir. Yukarıdaki 37 değere ek olarak şunları kabul edilen değerler arasında listeler:

- `contract/create`
- `contract/update`
- `currency/create`
- `currency/delete`

Bu dört topic'in teslim alanları Webhooks genel tablosunda açıklanmaz. Sonuç olarak iki resmi sayfa farklı ayrıntı seviyesindedir:

- Abonelik oluşturma isteğini doğrularken en özel sözleşme olan canlı ClientWebhook POST sayfasındaki 41 değeri esas alın.
- Teslim gövdesi beklerken yalnız Webhooks genel tablosundaki 37 topic için yayımlanmış alan bilgisine güvenin.
- Ek dört topic'i üretimde işlemeye başlamadan önce test mağazasında teslim gövdesini doğrulayın veya IdeaSoft desteğinden teyit alın.

## HMAC doğrulaması

Webhook gövdesini JSON'a çevirmeden önce ham byte dizisini saklayın. İmza, yeniden biçimlendirilmiş JSON üzerinden hesaplanırsa boşluk veya alan sırası değişikliği nedeniyle doğrulama başarısız olur.

### .NET 8 doğrulama yardımcı metodu

```csharp
using System.Security.Cryptography;
using System.Text;

static bool IsValidIdeaSoftWebhook(
    ReadOnlySpan<byte> rawBody,
    string receivedBase64Hmac,
    string clientSecret)
{
    byte[] received;

    try
    {
        received = Convert.FromBase64String(receivedBase64Hmac);
    }
    catch (FormatException)
    {
        return false;
    }

    var secretBytes = Encoding.UTF8.GetBytes(clientSecret);
    var expected = HMACSHA256.HashData(secretBytes, rawBody);

    return received.Length == expected.Length &&
           CryptographicOperations.FixedTimeEquals(received, expected);
}
```

Bu hesap, resmi dokümandaki PHP örneğinin .NET karşılığıdır:

```text
Base64(HMAC-SHA256(raw_request_body, client_secret))
```

### Minimal ASP.NET Core alıcı akışı

```csharp
app.MapPost("/webhooks/ideasoft/product-create", async (HttpRequest request) =>
{
    using var buffer = new MemoryStream();
    await request.Body.CopyToAsync(buffer);
    var rawBody = buffer.ToArray();

    var receivedHmac = request.Headers["X-Ideashop-Hmac-Sha256"].ToString();
    var clientSecret = configuration["IdeaSoft:ClientSecret"]
        ?? throw new InvalidOperationException("IdeaSoft Client Secret yapılandırılmamış.");

    if (string.IsNullOrWhiteSpace(receivedHmac) ||
        !IsValidIdeaSoftWebhook(rawBody, receivedHmac, clientSecret))
    {
        return Results.Unauthorized();
    }

    // 1. JSON'u ancak imza doğrulandıktan sonra ayrıştırın.
    // 2. Mesajı kalıcı kuyruğa veya iş tablosuna yazın.
    // 3. Aynı mesaj tekrar gelirse ikinci kez yan etki üretmeyin.
    // 4. Ağır işi arka planda çalıştırın.

    return Results.Ok();
});
```

Örnek yalnız alıcı iskeletidir. Üretimde istek boyutu sınırı, yapılandırma doğrulaması, dayanıklı kuyruk, güvenli loglama ve hata ölçümleri eklenmelidir.

## 10 saniyelik yanıt penceresi nasıl yönetilir?

Önerilen sıra:

1. Ham gövdeyi oku.
2. HMAC'i doğrula.
3. Mesajı dayanıklı bir kuyruğa veya veritabanındaki iş tablosuna kaydet.
4. Kayıt başarıyla kalıcı olduktan sonra `200 OK` dön.
5. Ürün/sipariş sorgusu ve diğer uzun işleri arka planda yap.

İşlem bitene kadar HTTP isteğini açık tutmak 10 saniye sınırını aşabilir. Kalıcı kayda almadan hemen `200` dönmek ise uygulama çökerse mesajı kaybettirebilir.

## Tekrar gelen mesajlar ve sıralama

Resmi sayfa hata durumunda yeniden deneme yapıldığını söyler. Bu nedenle aynı olay birden fazla kez gelebilir. Teslim sırası garantisi yayımlanmadığı için olayların her zaman sırayla geleceği varsayılmamalıdır.

Uygulama önerileri:

- Aynı olayı ikinci kez işlemek zarar vermemelidir; buna idempotent işleme denir.
- Resmi bir event ID belgelenmediği için kendi tekrar anahtarınızı dikkatli oluşturun. Örneğin endpoint/topic + nesne `id` + `updatedAt` + ham gövde özeti birlikte kullanılabilir.
- `update` olayında daha eski bir `updatedAt` gelirse güncel kaydın üzerine yazmadan önce API'den son durumu okuyun.
- `delete` olayında API'den nesneyi tekrar okuma başarısız olabilir; gelen minimum alanları ve yerel eşlemeyi kullanın.
- Sipariş ve üye gövdeleri kişisel veri içerebilir. Tam gövdeyi uygulama loglarına yazmayın.

Bu maddeler üretim güvenliği önerisidir; IdeaSoft'un yayımladığı teslim garantileri değildir.

## Canlı sayfalar ve yerel OpenAPI çelişkisi

Üç farklı sözleşme görünümü vardır:

| Kaynak | Topic sayısı | Fark |
|---|---:|---|
| Eski yerel `admin-swagger-prod.json` | 32 | `maillist/*`, `price_rule/*` ve `currency/*` yok |
| Canlı Webhooks genel tablosu | 37 | Teslim alanları yayımlanmış; `contract/*`, `currency/create`, `currency/delete` yok |
| Canlı ClientWebhook POST sözleşmesi | 41 | 37 değerin tamamı + `contract/create`, `contract/update`, `currency/create`, `currency/delete` |

Uygulama kuralı:

- Yeni abonelik değerini doğrulamak için canlı ClientWebhook POST sözleşmesindeki 41 değeri esas alın.
- Teslim alanı beklentisi için 37 satırlı Webhooks genel tablosunu esas alın.
- Eski enum yüzünden güncel `maillist/*`, `price_rule/*` veya `currency/*` topic'lerini istemci tarafında reddetmeyin.
- Alanları yayımlanmayan dört ek topic için üretim kullanımından önce ayrı doğrulama yapın.
- Resmi sayfalar eşitlenene kadar topic modelini kapalı C# `enum` yerine doğrulanmış string/sabitler olarak ele almak daha güvenlidir.

## Resmi belgede açıklanmayan noktalar

Aşağıdakiler canlı Webhooks sayfasında açıkça belirtilmemiştir; kod bunları uydurmamalıdır:

- Teslimat gövdesinin tek ve değişmez bir envelope şeması.
- Topic bilgisinin ayrı bir HTTP başlığında gönderilip gönderilmediği.
- Benzersiz event/delivery ID başlığı.
- Maksimum yeniden deneme sayısı ve bekleme planı.
- Olayların sıralı teslim garantisi.
- Kaynak IP listesi.
- Client Secret değiştirildiğinde mevcut aboneliklerin geçiş davranışı.

Bu bilgiler gerekiyorsa test mağazasında güvenli bir alıcıyla gözlem yapılmalı veya `apisupport@ideasoft.com.tr` adresinden yazılı doğrulama alınmalıdır. Gözlem sonucu bu belgeye tarih ve sürümle eklenmelidir; secret veya kişisel veri kaydedilmemelidir.

## Güvenlik kontrol listesi

- [ ] Yalnız HTTPS webhook adresi kullanılıyor.
- [ ] HMAC, ham gövde üzerinden ve JSON ayrıştırılmadan önce doğrulanıyor.
- [ ] Karşılaştırma sabit zamanlı yapılıyor.
- [ ] Client Secret yalnız secret manager veya ortam değişkeninde tutuluyor.
- [ ] Secret, token, tam sipariş/üye gövdesi loglanmıyor.
- [ ] İstek boyutu ve eşzamanlılık sınırı var.
- [ ] Mesaj kalıcı kuyruğa alınmadan `200` dönülmüyor.
- [ ] İşleyici tekrar gönderime dayanıklı.
- [ ] Abonelik listesi düzenli kontrol ediliyor; otomatik silinme alarmı var.
- [ ] İşleme hataları ve kuyruk gecikmesi ölçülüyor.
- [ ] Canlı mağazada POST/PUT/DELETE testi için açık kullanıcı onayı var.

## LLM için değişmezler

```yaml
verified_at: 2026-10-02
documentation_section: webhooks
subscription_api: admin_api
subscription_path: /admin-api/client_webhooks
delivery_method: POST
signature_header: X-Ideashop-Hmac-Sha256
signature_algorithm: base64_hmac_sha256_raw_body
signature_secret: oauth_client_secret
success_acknowledgement: HTTP_200
response_timeout_seconds: 10
payload_rule_v8: only_changed_fields
fields_selector_v8: removed
live_subscription_allowed_topic_count: 41
live_topics_with_documented_fields: 37
local_openapi_topic_count: 32
unknowns:
  - retry_count
  - retry_schedule
  - delivery_ordering
  - event_id
  - source_ip_ranges
never:
  - log_client_secret
  - parse_before_hmac_verification
  - assume_exactly_once_delivery
  - treat_local_openapi_topic_enum_as_current
```

## Resmi kaynaklar

- [IdeaSoft Webhooks](https://apidoc.ideasoft.dev/docs/webhooks/5cc9374300b99-webhooks)
- [ClientWebhook LIST](https://apidoc.ideasoft.dev/docs/admin-api/6y3bz6fwibimh-client-webhook-list)
- [ClientWebhook POST](https://apidoc.ideasoft.dev/docs/admin-api/404iksebffzqg-client-webhook-post)
- [IdeaSoft yardım: kaynak ve trafik kullanımı](https://www.ideasoft.com.tr/yardim/kaynak-ve-trafik-kullanimi/)
- [IdeaSoft API ana dokümanı](https://apidoc.ideasoft.dev/)
