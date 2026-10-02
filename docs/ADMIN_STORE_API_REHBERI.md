# IdeaSoft Admin API ve Store API rehberi

Bu belge, IdeaSoft'un iki REST API yüzeyini birbirine karıştırmadan kullanmak için hazırlanmıştır. Anlatım yeni başlayan bir C# geliştiricisinin takip edebileceği düzeydedir. Aynı zamanda başka bir LLM'in karar verirken kullanabileceği açık sınırlar ve doğrulanmış sayılar içerir.

Son canlı doküman incelemesi: **2 Ekim 2026**

## En kısa cevap

- **Admin API**, mağazanın arka ofis ve entegrasyon işlemleri için geniş kapsamlı yüzeydir. Yol öneki `/admin-api` olur.
- **Store API**, mağaza tarafındaki daha dar yüzeydir. Sepet, favori, üye adresi gibi mağaza deneyimine yakın kaynakları da içerir. Yol öneki `/api` olur.
- İkisi de aynı mağaza alan adını ve OAuth2 ile alınan Bearer access token'ı kullanır.
- Store API adı, bu API'nin anonim veya tarayıcıya gömülebilecek bir API olduğu anlamına gelmez. İncelenen güncel Store endpoint'i de `Authorization: Bearer ...` ister.
- Webhook abonelikleri Store API altında değildir. `/admin-api/client_webhooks` üzerinden yönetilir ve ayrıntılar [Webhook rehberinde](WEBHOOK_REHBERI.md) anlatılır.
- Bu repodaki `IdeaSoftClient` şu anda **yalnız Admin API** içindir. `SendAsync` yoluna `api/` vererek Store API çağırmaya çalışmayın.

## Basit benzetme

Bir mağazayı fiziksel dükkân gibi düşünün:

- Admin API, depo ve yönetim ofisinin anahtarları gibidir. Ürün, sipariş, içerik, ayar, rapor ve entegrasyon gibi geniş bir alanı yönetir.
- Store API, satış alanında kullanılan daha dar bir servis kapısı gibidir. Ürünler yanında sepet, favori, teslimat/fatura adresi ve mağaza kullanıcısı akışlarına daha yakındır.
- Webhook, mağazada bir şey değiştiğinde sizin sisteminize gönderilen zildir. Sürekli “değişiklik oldu mu?” diye sormak yerine IdeaSoft sizi bilgilendirir.

Bu benzetme yön gösterir; gerçek yetkiyi endpoint'in güncel dokümanı ve OAuth izinleri belirler.

## Doğrulanmış teknik farklar ve kullanım amacı

| Konu | Admin API | Store API |
|---|---|---|
| Temel URL | `https://magaza-adiniz.myideasoft.com/admin-api/...` | `https://magaza-adiniz.myideasoft.com/api/...` |
| Canlı navigasyon kapsamı | 903 operasyon, 176 kaynak grubu | 333 operasyon, 74 kaynak grubu |
| Metot dağılımı | 508 GET, 115 POST, 159 PUT, 121 DELETE | 147 GET, 62 POST, 63 PUT, 61 DELETE |
| Kimlik doğrulama | OAuth2 Authorization Code ile alınan Bearer token | Aynı OAuth2/Bearer akışı |
| Doküman güvenlik gösterimi | Bearer Auth ve operasyon bazlı OAuth kapsamı | İncelenen operasyonlarda Bearer Auth |
| Tipik kullanım | ERP/PIM/muhasebe, yönetim otomasyonu, site taşıma, içerik/tema, rapor, webhook aboneliği | Mağaza deneyimi, sepet, favoriler, müşteri adresleri ve daha dar kaynak işlemleri |
| Bu repodaki destek | Var; `IdeaSoftClient` Admin tabanını güvenli biçimde ekler | Henüz yok; ayrı istemci gerektirir |

Sayılar canlı Stoplight navigasyonundan çıkarılmıştır. Bir operasyonun mağaza paketinde açık olması, verilen kullanıcı izinleri ve sürüm gibi ek koşullara bağlı olabilir.

Tablodaki URL, güvenlik ve kapsam sayıları doğrudan canlı sayfalardan doğrulanmıştır. “Tipik kullanım” satırı ise IdeaSoft'un kaynak gruplarından yapılan mimari çıkarımdır; resmi doküman iki API arasındaki amacı tek bir tanım cümlesiyle açıklamamaktadır.

## Aynı OAuth akışı nasıl kullanılır?

Admin ve Store bölümlerindeki güncel Authentication sayfaları aynı akışı anlatır:

1. Panelde uygulama oluşturulur. `Client ID`, `Client Secret` ve `Redirect URI` elde edilir.
2. Kullanıcı `/panel/auth` adresinde gerekli izinleri onaylar.
3. Uygulamanın callback adresine kısa ömürlü `code` ve daha önce gönderilen `state` gelir.
4. `code`, `/oauth/v2/token` adresinde access ve refresh token ile değiştirilir.
5. API çağrısına `Authorization: Bearer ACCESS_TOKEN` başlığı eklenir.
6. Access token bittiğinde refresh token kullanılır ve dönen **yeni refresh token** eskisinin yerine güvenli biçimde saklanır.

Resmi dokümana göre:

- Authorization code yaklaşık 30 saniye geçerlidir.
- Access token yaklaşık 24 saat geçerlidir.
- Refresh token yaklaşık 2 ay geçerlidir.
- `state` geri dönüşte mutlaka karşılaştırılmalıdır.

> Dokümandaki bazı eski token örnekleri `GET` satırı gösterse de bölüm tanımı `POST` der. Bu repo token isteğini OAuth2'ye uygun `application/x-www-form-urlencoded` POST olarak gönderir.

Client Secret, access token ve refresh token hiçbir zaman kaynak koda, Git'e, ekran görüntüsüne veya loga yazılmamalıdır.

## Yol farkı neden önemlidir?

Aynı kaynak adı iki yüzeyde de bulunabilir:

```text
Admin: GET https://magaza-adiniz.myideasoft.com/admin-api/products
Store: GET https://magaza-adiniz.myideasoft.com/api/products
```

Bu iki endpoint'in alanları, filtreleri ve operasyonları aynı olmak zorunda değildir. Örneğin canlı dokümanda:

- Admin `Product` grubu 9 operasyon içerir. Listeleme/CRUD yanında kategori değiştirme, vitrin sırası güncelleme ve kullanılan entegrasyon dağıtıcılarını alma gibi özel işlemler vardır.
- Store `Product` grubu 5 temel CRUD operasyonu içerir.
- Admin ürün listeleme endpoint'i Store ürün listeleme endpoint'inden daha fazla filtre gösterir.

Bu nedenle sadece `admin-api` kelimesini `api` ile değiştirmek güvenli bir Store API uygulaması değildir. Ayrı sözleşme, ayrı modeller ve ayrı testler gerekir.

## Hangi API'yi seçmeliyim?

### Admin API seçin

- ERP, muhasebe, PIM veya kargo entegrasyonu yapıyorsanız.
- Ürün/sipariş verisini yönetim bakışıyla aktarıyorsanız.
- Sayfa, blog, banner, menü, tema, SEO veya mağaza ayarı yönetiyorsanız.
- Rapor, log, kullanıcı rolü veya geniş yönetim kaynaklarına ihtiyacınız varsa.
- Webhook aboneliği oluşturacak, güncelleyecek veya silecekseniz.
- Bir siteyi IdeaSoft'a taşıma aracı geliştiriyorsanız.

### Store API seçin

- Uygulamanız sepet ve sepet kalemleriyle çalışıyorsa.
- Favori ürün, üye adresi, hızlı sepet veya mağaza deneyimine yakın bir akış kuruyorsanız.
- İhtiyaç duyduğunuz kaynak Store API dokümanında bulunuyor ve oradaki daha dar sözleşme yeterliyse.

### Webhook seçin

- Değişiklikleri sürekli liste sorgusu ile taramak istemiyorsanız.
- Ürün, sipariş, ödeme, üye ve desteklenen diğer olaylar gerçekleştiğinde bildirim almak istiyorsanız.

Webhook çoğu zaman API'nin yerine geçmez. Bildirim yalnız değişen alanları taşır; tam nesne gerekirse gelen `id` ile uygun API endpoint'inden tekrar okunur.

## Kapsam karşılaştırması

Canlı katalogdaki 74 Store grubunun 60'ı Admin tarafında aynı grup adına da sahiptir. Aynı ad, aynı sözleşme anlamına gelmez.

### Yalnız Store kataloğunda görülen 14 grup

`AccountInformation`, `Cache`, `CartItem`, `DistributorToProduct`, `ExtraInfoToProduct`, `LabelToProduct`, `OptionToProduct`, `OrderRefundRequestItem`, `ProductToCategory`, `ProductToCountDown`, `ProductToTag`, `SelectionToProduct`, `ShipmentItem`, `SpecToProduct`

Buradaki “yalnız” ifadesi grup adını karşılaştırır. Admin tarafında benzer işi farklı ad veya özel operasyonla yapan bir endpoint bulunabilir.

### Store API'deki 74 grup

<details>
<summary>Tam listeyi göster</summary>

`AccountInformation`, `BillingAddress`, `Brand`, `Cache`, `Cart`, `CartItem`, `Category`, `CombineProduct`, `Country`, `Currency`, `CurrentAccount`, `Distributor`, `DistributorToProduct`, `ExtraInfo`, `ExtraInfoToProduct`, `FavouritedProduct`, `InstallmentRate`, `Label`, `LabelToProduct`, `Location`, `Maillist`, `MaillistGroup`, `Member`, `MemberAddress`, `MemberGroup`, `Option`, `OptionGroup`, `OptionToProduct`, `Order`, `OrderDetail`, `OrderItem`, `OrderRefundRequest`, `OrderRefundRequestItem`, `OrderUserNote`, `Payment`, `PaymentGateway`, `PaymentProvider`, `Preference`, `PreOrderInfo`, `Product`, `ProductButton`, `ProductComment`, `ProductDetail`, `ProductImage`, `ProductPrice`, `ProductProtection`, `ProductSpecialInfo`, `ProductToCategory`, `ProductToCountDown`, `ProductToTag`, `PurchaseLimitation`, `PurchaseLimitationItem`, `QuickCart`, `Region`, `ScriptTag`, `Selection`, `SelectionGroup`, `SelectionToProduct`, `Shipment`, `ShipmentItem`, `ShippingAddress`, `ShippingCompany`, `ShippingProvider`, `ShippingRate`, `ShoppingExperience`, `SpecGroup`, `SpecName`, `SpecToProduct`, `SpecValue`, `Tag`, `Theme`, `Town`, `TownGroup`, `User`

</details>

### Admin'de olup Store'da aynı adla bulunmayan 116 grup

<details>
<summary>Tam listeyi göster</summary>

`AbandonedCart`, `AbandonedOrder`, `AclResource`, `ActiveCart`, `AppSettingPref`, `Bank`, `Banner`, `BddkCategory`, `Blacklist`, `Block`, `Blog`, `BlogCategory`, `BlogCommentPref`, `BlogTag`, `CategoryMapping`, `CheckoutDesignPref`, `Client`, `ClientPermission`, `ClientWebhook`, `ClosingProduct`, `Collection`, `CommonFileTranslation`, `CommonPref`, `Contract`, `ContractPlan`, `Coupon`, `CustomizationGroup`, `CustomTax`, `Default`, `DraftOrder`, `DropdownPref`, `ExtraInstallment`, `ExtraPref`, `FileManager`, `FilterMenu`, `Form`, `FraudOrder`, `FraudRisk`, `GoogleAnalytics`, `InstalledApplication`, `InvoiceSetting`, `Language`, `LogNetGsm`, `MailAccounts`, `MailContent`, `MailContentTranslation`, `MemberGroupEmail`, `MemberGroupPosAccount`, `MenuItem`, `MerchantPoll`, `MerchantPollPref`, `MetaField`, `Midblock`, `NetGsm`, `Notification`, `OfferedProduct`, `OrderCustomTaxLine`, `Package`, `PackageItem`, `PackageItemProduct`, `Page`, `Partnership`, `PartnershipUrl`, `PaymentBddkCategory`, `PaymentGatewaySetting`, `PaymentProviderSetting`, `PaymentProxy`, `PaymentProxySetting`, `PaymentType`, `PixelSettingPref`, `PointLog`, `PointPref`, `Poll`, `Popup`, `PosCampaign`, `PosCampaignCategory`, `PosCampaignProduct`, `PriceGap`, `PriceRule`, `ProcessLog`, `ProductCategory`, `ProductCountDown`, `ProductCustomizationGroup`, `ProductExtraField`, `ProductExtraInfo`, `ProductFeed`, `ProductLabel`, `ProductPriceWarning`, `ProductTag`, `ProductToCollection`, `Promotion`, `PromotionBar`, `Question`, `QueueProcess`, `Report`, `SearchEnginePref`, `SeoPref`, `SeoSetting`, `ShipmentPref`, `ShippingProviderSetting`, `SiteContent`, `Slider`, `SmsConfig`, `SmtpPref`, `Statistic`, `StockWarning`, `Subscription`, `SubscriptionProduct`, `TabbedMidblock`, `TabbedMidblockProduct`, `Ticket`, `TrackingCode`, `UrlRouting`, `UserLog`, `UserRole`, `UserRolePermission`

</details>

## Bu repoda Store API nasıl eklenmeli?

Store desteği gelecekte eklenecekse mevcut `IdeaSoftClient` tabanı sessizce değiştirilmemelidir. Önerilen güvenli yapı:

1. `IdeaSoftClient` Admin API için geriye uyumlu kalır.
2. Ayrı bir `IdeaSoftStoreClient` oluşturulur.
3. Store istemcisi yalnız `api/` altındaki göreli yolları kabul eder.
4. Admin ve Store modelleri yalnız şemaları gerçekten aynıysa paylaşılır; isim benzerliği tek başına yeterli değildir.
5. Her yüzey için harici URL'ye Bearer token sızmasını engelleyen test bulunur.
6. Store testleri canlı mağazada varsayılan olarak yalnız GET çalıştırır.
7. `swagger.json` güncel Store sözleşmesi sanılarak kod üretilmez; dosya yalnız 6 yol/11 operasyon içerir ve canlı 333 operasyonu temsil etmez.

## Sık yapılan hatalar

- Store API'yi ismi nedeniyle anonim/public sanmak.
- Client Secret veya Bearer token'ı tarayıcı JavaScript'ine koymak.
- Admin yolunu Store yoluyla veya Store yolunu Admin yoluyla birleştirmek.
- Aynı adlı Admin ve Store modellerini karşılaştırmadan tek sınıfa zorlamak.
- Repo kökündeki eski `swagger.json` dosyasını eksiksiz Store şeması sanmak.
- Store istemcisini mevcut Admin `SendAsync` metoduna mutlak URL vererek kullanmak. İstemci bunu token güvenliği için reddeder.
- İzin yetersizliğini `404` veya model hatası sanmak; önce `401/403` ve panel izinlerini kontrol etmek.

## LLM için karar özeti

```yaml
verified_at: 2026-10-02
repository_client_scope: admin_api_only
admin:
  path_prefix: /admin-api
  live_groups: 176
  live_operations: 903
store:
  path_prefix: /api
  live_groups: 74
  live_operations: 333
authentication:
  flow: oauth2_authorization_code
  api_header: "Authorization: Bearer <access-token>"
webhook_subscription_surface: admin_api
webhook_subscription_path: /admin-api/client_webhooks
store_snapshot_warning: swagger.json_is_incomplete_6_paths_11_operations
implementation_rule: never_switch_IdeaSoftClient_base_path_to_add_store_support
```

## Resmi kaynaklar

- [IdeaSoft API ana dokümanı](https://apidoc.ideasoft.dev/)
- [Admin API Authentication](https://apidoc.ideasoft.dev/docs/admin-api/3x74avtrv8u23-authentication)
- [Store API Authentication](https://apidoc.ideasoft.dev/docs/store-api/3x74avtrv8u23-authentication)
- [Admin Product LIST](https://apidoc.ideasoft.dev/docs/admin-api/6hvi6as48mv56-product-list)
- [Store Product LIST](https://apidoc.ideasoft.dev/docs/store-api/qsr9fu2u1lrlh-product-list)
- [HTTP durum kodları](https://apidoc.ideasoft.dev/docs/store-api/nx82fkzkug33y-http-durum-kodlari)
- [IdeaSoft yardım: API kullanımı](https://www.ideasoft.com.tr/yardim/api-kullanimi/)
