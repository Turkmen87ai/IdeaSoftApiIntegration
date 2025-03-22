# Ideashop API

**Versiyon:** 3.0.0

## Açıklama

<div class="apidoc-icons"><div class="apidoc-icons-item"><a href="javascript:void(0)" class="faq-button" title="Sıkça Sorulan Sorular"><div class="apidoc-icons-img"><img src="https://apidoc.ideasoft.com.tr/images/help-icon-4.png" alt="Sıkça Sorulan Sorular"></div><h4>Sıkça Sorulan Sorular</h4></a><p>Sizlerden sıkça gelen sorulan soruları buradan görüntüleyerek, sorularınıza daha hızlı cevap bulabilirsiniz.</p></div><div class="apidoc-icons-item"><a href="mailto:techsupport@ideasoft.com.tr" title="Destek Sistemi"><div class="apidoc-icons-img"><img src="https://apidoc.ideasoft.com.tr/images/help-icon-5.png" alt="Destek Sistemi"></div><h4>Destek Sistemi</h4></a><p>API ile ilgili tüm sorularınız için bizimle <a href="mailto: apisupport@ideasoft.com.tr"> apisupport@ideasoft.com.tr</a> adresimiz üzerinden iletişime geçebilirsiniz. Sizlere yardımcı olmaktan mutluluk duyarız.</p></div></div><p>IdeaSoft API kullanmak için ihtiyaç duyacağınız bilgileri bu dökümanda sizler için topladık. Navigasyon bölmesinden bilgi almak istediğiniz servislere gidebilir örnek istekleri, cevapları ve istek parametrelerini detaylıca görebilirsiniz. Servisin size dönmüş olduğu cevaptaki ilgili nesneyi cevaplar kısmında nesnenin ismine tıklayarak detaylı bir şekilde inceleyebilir her bir özelliğiyle ilgili detaylı açıklamalar bulabilirsiniz.</p>

## İletişim Bilgileri

**İsim:** Ideasoft API Support

**E-posta:** apisupport@ideasoft.com.tr

**URL:** https://www.ideasoft.com.tr/destek

## Sunucular

* **URL:** https://magaza-adiniz.myideasoft.com/admin-api

## Güvenlik

### bearerAuth

**Tip:** http

**Şema:** bearer

### OAuth2

**Tip:** oauth2

**Açıklama:** <a href="#authentication">Yetkilendirme Dökümanı</a> kısmında detaylı açıklama bulabilirsiniz.

**Akışlar:**

* **authorizationCode**
  * Yetkilendirme URL: https://magaza-adiniz.myideasoft.com/panel/auth
  * Token URL: https://magaza-adiniz.myideasoft.com/oauth/v2/token
  * Kapsamlar:
    * `catalog_read`: Katalog okuma izni
    * `catalog_write`: Katalog yazma izni
    * `order_read`: Sipariş okuma izni
    * `order_write`: Sipariş yazma izni
    * `theme_read`: Tema okuma izni
    * `theme_write`: Tema yazma izni
    * `store_read`: Mağaza okuma izni
    * `store_write`: Mağaza yazma izni
    * `report_read`: Rapor okuma izni
    * `report_write`: Rapor yazma izni
    * `member_read`: Üye okuma izni
    * `member_write`: Üye yazma izni
    * `payment_read`: Ödeme okuma izni
    * `payment_write`: Ödeme yazma izni
    * `maillist_read`: Mail Listesi okuma izni
    * `maillist_write`: Mail Listesi yazma izni
    * `payment_gateway_read`: Ödeme Kanalı okuma izni
    * `payment_gateway_write`: Ödeme Kanalı yazma izni
    * `location_read`: Konum okuma izni
    * `location_write`: Konum yazma izni
    * `user_read`: Kullanıcı okuma izni
    * `user_write`: Kullanıcı yazma izni
    * `shipping_read`: Teslimat okuma izni
    * `shipping_write`: Teslimat yazma izni
    * `abandoned_cart_read`: Sepeti terk edilmişleri okuma izni
    * `abandoned_cart_update`: Sepeti terk edilmişleri güncelleme izni
    * `abandoned_order_read`: Siparişi terk edilmişleri okuma izni
    * `abandoned_order_update`: Siparişi terk edilmişleri güncelleme izni
    * `active_cart_read`: Aktif sepetleri okuma izni
    * `payment_setting_read`: Ödeme ayarlarını okuma izni
    * `banner_read`: Bannerları okuma izni
    * `banner_create`: Banner oluşturma izni
    * `banner_update`: Bannerları güncelleme izni
    * `banner_delete`: Bannerları silme izni
    * `order_create`: Sipariş oluşturma izni
    * `order_update`: Sipariş güncelleme izni
    * `blacklist_read`: Kara listeyi okuma izni
    * `blacklist_delete`: Kara listeyi silme izni
    * `block_read`: Engelleri okuma izni
    * `block_create`: Engelleri oluşturma izni
    * `block_update`: Engelleri güncelleme izni
    * `block_delete`: Engelleri silme izni
    * `blog_category_read`: Blog kategorilerini okuma izni
    * `blog_category_create`: Blog kategorisi oluşturma izni
    * `blog_category_update`: Blog kategorilerini güncelleme izni
    * `blog_category_delete`: Blog kategorilerini silme izni
    * `blog_comment_read`: Blog yorumlarını okuma izni
    * `blog_comment_update`: Blog yorumlarını güncelleme izni
    * `blog_read`: Blogları okuma izni
    * `blog_create`: Blog oluşturma izni
    * `blog_update`: Blogları güncelleme izni
    * `blog_delete`: Blogları silme izni
    * `blog_tag_read`: Blog etiketlerini okuma izni
    * `blog_tag_create`: Blog etiketi oluşturma izni
    * `blog_tag_update`: Blog etiketlerini güncelleme izni
    * `blog_tag_delete`: Blog etiketlerini silme izni
    * `brand_read`: Markaları okuma izni
    * `brand_create`: Marka oluşturma izni
    * `brand_update`: Markaları güncelleme izni
    * `brand_delete`: Markaları silme izni
    * `product_showcase_update`: Ürün vitrini güncelleme izni
    * `category_read`: Kategorileri okuma izni
    * `category_create`: Kategori oluşturma izni
    * `category_update`: Kategorileri güncelleme izni
    * `category_delete`: Kategorileri silme izni
    * `checkout_design_pref_read`: Ödeme tasarım tercihlerini okuma izni
    * `checkout_design_pref_update`: Ödeme tasarım tercihlerini güncelleme izni
    * `checkout_design_pref_delete`: Ödeme tasarım tercihlerini silme izni
    * `api_read`: API'leri okuma izni
    * `api_create`: API oluşturma izni
    * `api_update`: API'leri güncelleme izni
    * `api_delete`: API'leri silme izni
    * `app_store_read`: Uygulama mağazalarını okuma izni
    * `product_read`: Ürünleri okuma izni
    * `product_create`: Ürün oluşturma izni
    * `product_update`: Ürünleri güncelleme izni
    * `product_delete`: Ürünleri silme izni
    * `common_pref_read`: Ortak tercihleri okuma izni
    * `common_pref_create`: Ortak tercih oluşturma izni
    * `common_pref_update`: Ortak tercihleri güncelleme izni
    * `common_pref_delete`: Ortak tercihleri silme izni
    * `contract_read`: Sözleşmeleri okuma izni
    * `contract_update`: Sözleşmeleri güncelleme izni
    * `country_read`: Ülkeleri okuma izni
    * `country_update`: Ülkeleri güncelleme izni
    * `coupon_read`: Kuponları okuma izni
    * `coupon_create`: Kupon oluşturma izni
    * `coupon_update`: Kuponları güncelleme izni
    * `coupon_delete`: Kuponları silme izni
    * `currency_read`: Para birimlerini okuma izni
    * `currency_update`: Para birimlerini güncelleme izni
    * `member_create`: Üye oluşturma izni
    * `member_update`: Üyeleri güncelleme izni
    * `member_delete`: Üyeleri silme izni
    * `order_delete`: Siparişleri silme izni
    * `customization_read`: Özelleştirmeleri okuma izni
    * `customization_update`: Özelleştirmeleri güncelleme izni
    * `smtp_pref_update`: SMTP tercihlerini güncelleme izni
    * `seo_pref_update`: SEO tercihlerini güncelleme izni
    * `distributor_read`: Dağıtıcıları okuma izni
    * `distributor_create`: Dağıtıcı oluşturma izni
    * `distributor_update`: Dağıtıcıları güncelleme izni
    * `distributor_delete`: Dağıtıcıları silme izni
    * `dropdown_pref_read`: Açılır menü tercihlerini okuma izni
    * `dropdown_pref_update`: Açılır menü tercihlerini güncelleme izni
    * `extra_info_read`: Ek bilgileri okuma izni
    * `extra_info_create`: Ek bilgi oluşturma izni
    * `extra_info_update`: Ek bilgileri güncelleme izni
    * `extra_info_delete`: Ek bilgileri silme izni
    * `payment_setting_update`: Ödeme ayarlarını güncelleme izni
    * `extra_pref_read`: Ek tercihleri okuma izni
    * `extra_pref_update`: Ek tercihleri güncelleme izni
    * `filter_menu_read`: Filtre menülerini okuma izni
    * `filter_menu_update`: Filtre menülerini güncelleme izni
    * `form_read`: Formları okuma izni
    * `form_create`: Form oluşturma izni
    * `form_update`: Formları güncelleme izni
    * `form_delete`: Formları silme izni
    * `fraud_risk_read`: Dolandırıcılık risklerini okuma izni
    * `fraud_risk_create`: Dolandırıcılık riski oluşturma izni
    * `fraud_risk_update`: Dolandırıcılık risklerini güncelleme izni
    * `fraud_risk_delete`: Dolandırıcılık risklerini silme izni
    * `instagram_shop_read`: Instagram mağazalarını okuma izni
    * `instagram_shop_update`: Instagram mağazalarını güncelleme izni
    * `instagram_shop_create`: Instagram mağazası oluşturma izni
    * `instagram_shop_delete`: Instagram mağazalarını silme izni
    * `payment_setting_create`: Ödeme ayarı oluşturma izni
    * `payment_setting_delete`: Ödeme ayarlarını silme izni
    * `invoice_read`: Faturaları okuma izni
    * `invoice_update`: Faturaları güncelleme izni
    * `seo_pref_read`: SEO tercihlerini okuma izni
    * `label_read`: Etiketleri okuma izni
    * `label_create`: Etiket oluşturma izni
    * `label_update`: Etiketleri güncelleme izni
    * `label_delete`: Etiketleri silme izni
    * `language_read`: Dilleri okuma izni
    * `language_update`: Dilleri güncelleme izni
    * `language_delete`: Dilleri silme izni
    * `language_create`: Dil oluşturma izni
    * `location_create`: Konum oluşturma izni
    * `location_update`: Konumları güncelleme izni
    * `location_delete`: Konumları silme izni
    * `mail_content_read`: Posta içeriklerini okuma izni
    * `mail_content_update`: Posta içeriklerini güncelleme izni
    * `mail_content_delete`: Posta içeriklerini silme izni
    * `mail_content_create`: Posta içerikleri oluşturma izni
    * `maillist_create`: Posta listesi oluşturma izni
    * `maillist_update`: Posta listelerini güncelleme izni
    * `maillist_delete`: Posta listelerini silme izni
    * `maillist_group_read`: Posta listesi gruplarını okuma izni
    * `maillist_group_create`: Posta listesi grupları oluşturma izni
    * `maillist_group_update`: Posta listesi gruplarını güncelleme izni
    * `maillist_group_delete`: Posta listesi gruplarını silme izni
    * `member_group_read`: Üye gruplarını okuma izni
    * `member_group_create`: Üye grupları oluşturma izni
    * `member_group_update`: Üye gruplarını güncelleme izni
    * `member_group_delete`: Üye gruplarını silme izni
    * `member_group_pos_account_read`: Üye grup POS hesaplarını okuma izni
    * `member_group_pos_account_create`: Üye grup POS hesabı oluşturma izni
    * `member_group_pos_account_update`: Üye grup POS hesaplarını güncelleme izni
    * `member_group_pos_account_delete`: Üye grup POS hesaplarını silme izni
    * `menu_item_read`: Menü öğelerini okuma izni
    * `menu_item_create`: Menü öğesi oluşturma izni
    * `menu_item_update`: Menü öğelerini güncelleme izni
    * `menu_item_delete`: Menü öğelerini silme izni
    * `merchant_poll_read`: Satıcı anketlerini okuma izni
    * `merchant_poll_create`: Satıcı anketi oluşturma izni
    * `merchant_poll_update`: Satıcı anketlerini güncelleme izni
    * `merchant_poll_delete`: Satıcı anketlerini silme izni
    * `net_gsm_read`: Net GSM okuma izni
    * `net_gsm_update`: Net GSM güncelleme izni
    * `option_read`: Seçenekleri okuma izni
    * `option_create`: Seçenek oluşturma izni
    * `option_update`: Seçenekleri güncelleme izni
    * `option_delete`: Seçenekleri silme izni
    * `order_refund_request_read`: Sipariş iadesi taleplerini okuma izni
    * `order_refund_request_create`: Sipariş iadesi talebi oluşturma izni
    * `order_refund_request_update`: Sipariş iadesi taleplerini güncelleme izni
    * `order_refund_request_delete`: Sipariş iadesi taleplerini silme izni
    * `package_read`: Paketleri okuma izni
    * `package_create`: Paket oluşturma izni
    * `package_update`: Paketleri güncelleme izni
    * `package_delete`: Paketleri silme izni
    * `page_read`: Sayfaları okuma izni
    * `page_create`: Sayfa oluşturma izni
    * `page_update`: Sayfaları güncelleme izni
    * `page_delete`: Sayfaları silme izni
    * `partner_ship_read`: İş ortaklıklarını okuma izni
    * `payment_update`: Ödemeleri güncelleme izni
    * `payment_delete`: Ödemeleri silme izni
    * `linked_account_read`: Bağlı hesapları okuma izni
    * `linked_account_update`: Bağlı hesapları güncelleme izni
    * `point_read`: Puanları okuma izni
    * `point_update`: Puanları güncelleme izni
    * `poll_read`: Anketleri okuma izni
    * `poll_create`: Anket oluşturma izni
    * `poll_update`: Anketleri güncelleme izni
    * `poll_delete`: Anketleri silme izni
    * `popup_create`: Açılır pencere oluşturma izni
    * `popup_update`: Açılır pencereleri güncelleme izni
    * `popup_delete`: Açılır pencereleri silme izni
    * `pos_campaign_read`: POS kampanyalarını okuma izni
    * `pos_campaign_create`: POS kampanyası oluşturma izni
    * `pos_campaign_update`: POS kampanyalarını güncelleme izni
    * `pos_campaign_delete`: POS kampanyalarını silme izni
    * `price_gap_read`: Fiyat farklarını okuma izni
    * `price_gap_create`: Fiyat farkı oluşturma izni
    * `price_gap_update`: Fiyat farklarını güncelleme izni
    * `price_gap_delete`: Fiyat farklarını silme izni
    * `price_rule_read`: Fiyat kurallarını okuma izni
    * `price_rule_create`: Fiyat kuralı oluşturma izni
    * `price_rule_update`: Fiyat kurallarını güncelleme izni
    * `price_rule_delete`: Fiyat kurallarını silme izni
    * `process_log_read`: İşlem günlüklerini okuma izni
    * `product_button_read`: Ürün düğmelerini okuma izni
    * `product_button_create`: Ürün düğmesi oluşturma izni
    * `product_button_update`: Ürün düğmelerini güncelleme izni
    * `product_button_delete`: Ürün düğmelerini silme izni
    * `product_comment_read`: Ürün yorumlarını okuma izni
    * `product_comment_update`: Ürün yorumlarını güncelleme izni
    * `product_comment_delete`: Ürün yorumlarını silme izni
    * `product_customization_read`: Ürün özelleştirmelerini okuma izni
    * `product_customization_create`: Ürün özelleştirmesi oluşturma izni
    * `product_customization_update`: Ürün özelleştirmelerini güncelleme izni
    * `product_customization_delete`: Ürün özelleştirmelerini silme izni
    * `product_feed_read`: Ürün beslemelerini okuma izni
    * `promotion_bar_read`: Promosyon çubuklarını okuma izni
    * `promotion_bar_create`: Promosyon çubuğu oluşturma izni
    * `promotion_bar_update`: Promosyon çubuklarını güncelleme izni
    * `promotion_bar_delete`: Promosyon çubuklarını silme izni
    * `promotion_read`: Promosyonları okuma izni
    * `promotion_create`: Promosyon oluşturma izni
    * `promotion_update`: Promosyonları güncelleme izni
    * `promotion_delete`: Promosyonları silme izni
    * `purchase_limitation_read`: Satın alma sınırlamalarını okuma izni
    * `purchase_limitation_create`: Satın alma sınırı oluşturma izni
    * `purchase_limitation_update`: Satın alma sınırlamalarını güncelleme izni
    * `purchase_limitation_delete`: Satın alma sınırlamalarını silme izni
    * `question_create`: Soru oluşturma izni
    * `question_read`: Soruları okuma izni
    * `question_update`: Soruları güncelleme izni
    * `question_delete`: Soruları silme izni
    * `queue_process_read`: Kuyruk işlemlerini okuma izni
    * `queue_process_update`: Kuyruk işlemlerini güncelleme izni
    * `quick_cart_read`: Hızlı alışveriş sepetini okuma izni
    * `quick_cart_create`: Hızlı alışveriş sepeti oluşturma izni
    * `quick_cart_update`: Hızlı alışveriş sepetini güncelleme izni
    * `quick_cart_delete`: Hızlı alışveriş sepetini silme izni
    * `region_read`: Bölge bilgilerini okuma izni
    * `region_create`: Bölge oluşturma izni
    * `region_update`: Bölge güncelleme izni
    * `region_delete`: Bölge silme izni
    * `selection_read`: Seçimleri okuma izni
    * `selection_create`: Seçim oluşturma izni
    * `selection_update`: Seçimleri güncelleme izni
    * `selection_delete`: Seçimleri silme izni
    * `shipment_pref_read`: Gönderim tercihlerini okuma izni
    * `shipment_pref_create`: Gönderim tercihi oluşturma izni
    * `shipment_pref_update`: Gönderim tercihlerini güncelleme izni
    * `shipment_pref_delete`: Gönderim tercihlerini silme izni
    * `shipping_company_read`: Kargo firmalarını okuma izni
    * `shipping_company_create`: Kargo firması oluşturma izni
    * `shipping_company_update`: Kargo firmalarını güncelleme izni
    * `shipping_company_delete`: Kargo firmalarını silme izni
    * `shipping_provider_read`: Kargo sağlayıcılarını okuma izni
    * `shipping_provider_update`: Kargo sağlayıcılarını güncelleme izni
    * `shopping_experience_read`: Alışveriş deneyimlerini okuma izni
    * `shopping_experience_update`: Alışveriş deneyimlerini güncelleme izni
    * `shopping_experience_delete`: Alışveriş deneyimlerini silme izni
    * `site_content_read`: Site içeriğini okuma izni
    * `site_content_update`: Site içeriğini güncelleme izni
    * `slider_read`: Sliderları okuma izni
    * `slider_create`: Slider oluşturma izni
    * `slider_update`: Sliderları güncelleme izni
    * `slider_delete`: Sliderları silme izni
    * `sms_setting_read`: SMS ayarlarını okuma izni
    * `sms_setting_update`: SMS ayarlarını güncelleme izni
    * `smtp_pref_read`: SMTP tercihlerini okuma izni
    * `spec_read`: Özellikleri okuma izni
    * `spec_create`: Özellik oluşturma izni
    * `spec_update`: Özellikleri güncelleme izni
    * `spec_delete`: Özellikleri silme izni
    * `statistic_read`: İstatistikleri okuma izni
    * `stock_warning_read`: Stok uyarılarını okuma izni
    * `stock_warning_delete`: Stok uyarılarını silme izni
    * `subscription_read`: Abonelikleri okuma izni
    * `subscription_create`: Abonelik oluşturma izni
    * `subscription_update`: Abonelikleri güncelleme izni
    * `subscription_delete`: Abonelikleri silme izni
    * `tag_read`: Etiketleri okuma izni
    * `tag_create`: Etiket oluşturma izni
    * `tag_update`: Etiketleri güncelleme izni
    * `tag_delete`: Etiketleri silme izni
    * `theme_create`: Tema oluşturma izni
    * `theme_update`: Temaları güncelleme izni
    * `theme_delete`: Temaları silme izni
    * `town_read`: Şehirleri okuma izni
    * `town_create`: Şehir oluşturma izni
    * `town_update`: Şehirleri güncelleme izni
    * `town_delete`: Şehirleri silme izni
    * `user_create`: Kullanıcı oluşturma izni
    * `user_update`: Kullanıcıları güncelleme izni
    * `user_delete`: Kullanıcıları silme izni
    * `user_role_read`: Kullanıcı rollerini okuma izni
    * `user_role_create`: Kullanıcı rolü oluşturma izni
    * `user_role_update`: Kullanıcı rollerini güncelleme izni
    * `user_role_delete`: Kullanıcı rollerini silme izni
    * `file_manager_read`: Dosya yöneticisini okuma izni
    * `file_manager_create`: Dosya yöneticisi oluşturma izni
    * `file_manager_delete`: Dosya yöneticisini silme izni
    * `file_manager_webroot_file_write`: Web kök dosyalarına dosya yazma izni
## API Grupları

### AbandonedCart

AbandonedCart

### AbandonedOrder

AbandonedOrder

### AclResource

AclResource

### ActiveCart

ActiveCart

### AppSettingPref

AppSettingPref

### Bank

Bank

### Banner

Banner

### BddkCategory

BddkCategory

### BillingAddress

BillingAddress

### Blacklist

Blacklist

### Block

Block

### BlogCategory

BlogCategory

### BlogCommentPref

BlogCommentPref

### Blog

Blog

### BlogTag

BlogTag

### Brand

Brand

### Cart

Cart

### Category

Category

### CategoryMapping

CategoryMapping

### CheckoutDesignPref

CheckoutDesignPref

### Client

Client

### ClientPermission

ClientPermission

### ClientWebhook

ClientWebhook

### CombineProduct

CombineProduct

### CommonFileTranslation

CommonFileTranslation

### CommonPref

CommonPref

### Contract

Contract

### ContractPlan

ContractPlan

### Country

Country

### Coupon

Coupon

### Currency

Currency

### CurrentAccount

CurrentAccount

### CustomTax

CustomTax

### CustomizationGroup

CustomizationGroup

### Default

Default

### Distributor

Distributor

### DraftOrder

DraftOrder

### DropdownPref

DropdownPref

### ExtraInfo

ExtraInfo

### ExtraInstallment

ExtraInstallment

### ExtraPref

ExtraPref

### FilterMenu

FilterMenu

### Form

Form

### FraudOrder

FraudOrder

### FraudRisk

FraudRisk

### InstagramShop

InstagramShop

### InstagramShopProduct

InstagramShopProduct

### InstagramShopSetting

InstagramShopSetting

### InstalledApplication

InstalledApplication

### InstallmentRate

InstallmentRate

### InvoiceSetting

InvoiceSetting

### Label

Label

### Language

Language

### Location

Location

### MailContent

MailContent

### MailContentTranslation

MailContentTranslation

### Maillist

Maillist

### MaillistGroup

MaillistGroup

### MemberAddress

MemberAddress

### Member

Member

### MemberGroup

MemberGroup

### MemberGroupEmail

MemberGroupEmail

### MemberGroupPosAccount

MemberGroupPosAccount

### MenuItem

MenuItem

### MerchantPoll

MerchantPoll

### MerchantPollPref

MerchantPollPref

### MetaField

MetaField

### Midblock

Midblock

### NetGsm

NetGsm

### NetGsmLog

NetGsmLog

### Notification

Notification

### OfferedProduct

OfferedProduct

### Option

Option

### OptionGroup

OptionGroup

### Order

Order

### OrderCustomTaxLine

OrderCustomTaxLine

### OrderDetail

OrderDetail

### OrderItem

OrderItem

### OrderRefundRequest

OrderRefundRequest

### OrderUserNote

OrderUserNote

### Package

Package

### PackageItem

PackageItem

### PackageItemProduct

PackageItemProduct

### Page

Page

### Partnership

Partnership

### PartnershipUrl

PartnershipUrl

### Payment

Payment

### PaymentGateway

PaymentGateway

### PaymentGatewaySetting

PaymentGatewaySetting

### PaymentProvider

PaymentProvider

### PaymentProviderSetting

PaymentProviderSetting

### PaymentProxy

PaymentProxy

### PaymentProxySetting

PaymentProxySetting

### PaymentType

PaymentType

### PixelSettingPref

PixelSettingPref

### PointLog

PointLog

### PointPref

PointPref

### Poll

Poll

### Popup

Popup

### PosCampaignCategory

PosCampaignCategory

### PosCampaign

PosCampaign

### PosCampaignProduct

PosCampaignProduct

### PreOrderInfo

PreOrderInfo

### Preference

Preference

### PriceGap

PriceGap

### PriceRule

PriceRule

### ProcessLog

ProcessLog

### ProductButton

ProductButton

### ProductCategory

ProductCategory

### ProductComment

ProductComment

### Product

Product

### ProductCountDown

ProductCountDown

### ProductCustomizationGroup

ProductCustomizationGroup

### ProductDetail

ProductDetail

### ProductExtraField

ProductExtraField

### ProductExtraInfo

ProductExtraInfo

### ProductFeed

ProductFeed

### ProductImage

ProductImage

### ProductLabel

ProductLabel

### ProductPrice

ProductPrice

### ProductPriceWarning

ProductPriceWarning

### ProductProtection

ProductProtection

### ProductSpecialInfo

ProductSpecialInfo

### ProductTag

ProductTag

### PromotionBar

PromotionBar

### Promotion

Promotion

### PurchaseLimitation

PurchaseLimitation

### PurchaseLimitationItem

PurchaseLimitationItem

### Question

Question

### QueueProcess

QueueProcess

### QuickCart

QuickCart

### Region

Region

### Report

Report

### ScriptTag

ScriptTag

### SearchEnginePref

SearchEnginePref

### Selection

Selection

### SelectionGroup

SelectionGroup

### SeoPref

SeoPref

### SeoSetting

SeoSetting

### Shipment

Shipment

### ShipmentPref

ShipmentPref

### ShippingAddress

ShippingAddress

### ShippingCompany

ShippingCompany

### ShippingProvider

ShippingProvider

### ShippingProviderSetting

ShippingProviderSetting

### ShippingRate

ShippingRate

### ShoppingExperience

ShoppingExperience

### SiteContent

SiteContent

### Slider

Slider

### SmsConfig

SmsConfig

### SmtpPref

SmtpPref

### SpecGroup

SpecGroup

### SpecName

SpecName

### SpecValue

SpecValue

### Statistic

Statistic

### StockWarning

StockWarning

### Subscription

Subscription

### SubscriptionProduct

SubscriptionProduct

### TabbedMidblock

TabbedMidblock

### TabbedMidblockProduct

TabbedMidblockProduct

### Tag

Tag

### Theme

Theme

### Ticket

Ticket

### Town

Town

### TownGroup

TownGroup

### UrlRouting

UrlRouting

### User

User

### UserRole

UserRole

### UserRolePermission

UserRolePermission

### FileManager

FileManager

### GoogleAnalytics

GoogleAnalytics

## Endpoint'ler

### AbandonedCart

#### AbandonedCart LIST

**Endpoint:** `GET /admin-api/abandoned_carts`

**Açıklama:** AbandonedCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek AbandonedCarts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | string | Member Id |
| firstname | query |  | string | Customer Firstname |
| surname | query |  | string | Customer Surname |
| email | query |  | string | Customer Email |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | AbandonedCart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AbandonedCart](#schema-abandonedcart)

---

#### AbandonedCart COUNT

**Endpoint:** `GET /admin-api/abandoned_carts/count`

**Açıklama:** AbandonedCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek AbandonedCarts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | string | Member Id |
| firstname | query |  | string | Customer Firstname |
| surname | query |  | string | Customer Surname |
| email | query |  | string | Customer Email |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | AbandonedCart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AbandonedCart](#schema-abandonedcart)

---

### AbandonedOrder

#### AbandonedOrder LIST

**Endpoint:** `GET /admin-api/abandoned_orders`

**Açıklama:** AbandonedOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek AbandonedCarts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | string | Member Id |
| visitorType | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `member`, `customer` |
| firstname | query |  | string | Customer Firstname |
| surname | query |  | string | Customer Surname |
| email | query |  | string | Customer Email |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | AbandonedCart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AbandonedOrder](#schema-abandonedorder)

---

#### AbandonedOrder COUNT

**Endpoint:** `GET /admin-api/abandoned_orders/count`

**Açıklama:** AbandonedOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek AbandonedCarts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | string | Member Id |
| visitorType | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `member`, `customer` |
| firstname | query |  | string | Customer Firstname |
| surname | query |  | string | Customer Surname |
| email | query |  | string | Customer Email |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | AbandonedCart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AbandonedOrder](#schema-abandonedorder)

---

### AclResource

#### AclResource LIST

**Endpoint:** `GET /admin-api/acl_resources`

**Açıklama:** AclResource cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### ActiveCart

#### ActiveCart LIST

**Endpoint:** `GET /admin-api/active_carts`

**Açıklama:** ActiveCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested AbandonedCarts per page |
| page | query |  | integer | Which page to start from |
| customerFirstname | query |  | string | Customer Firstname |
| customerSurname | query |  | string | Customer Surname |
| customerEmail | query |  | string | Customer Email |
| state | query |  | string | Aşama |
| q | query |  | string | AbandonedCart search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ActiveCart](#schema-activecart)

---

#### ActiveCart COUNT

**Endpoint:** `GET /admin-api/active_carts/count`

**Açıklama:** ActiveCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested AbandonedCarts per page |
| page | query |  | integer | Which page to start from |
| customerFirstname | query |  | string | Customer Firstname |
| customerSurname | query |  | string | Customer Surname |
| customerEmail | query |  | string | Customer Email |
| state | query |  | string | Aşama |
| q | query |  | string | AbandonedCart search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ActiveCart](#schema-activecart)

---

### AppSettingPref

#### AppSettingPref LIST

**Endpoint:** `GET /admin-api/app_setting_pref`

**Açıklama:** AppSettingPref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AppSettingPref](#schema-appsettingpref)

---

#### AppSettingPref PUT

**Endpoint:** `PUT /admin-api/app_setting_pref`

**Açıklama:** AppSettingPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [AppSettingPref](#schema-appsettingpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [AppSettingPref](#schema-appsettingpref)

---

### Bank

#### Bank LIST

**Endpoint:** `GET /admin-api/banks`

**Açıklama:** Bank cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blacklists adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Blacklist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Bank](#schema-bank)

---

#### Bank COUNT

**Endpoint:** `GET /admin-api/banks/count`

**Açıklama:** Bank cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blacklists adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Blacklist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Bank](#schema-bank)

---

#### Bank GET

**Endpoint:** `GET /admin-api/banks/{id}`

**Açıklama:** Bank getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Bank](#schema-bank)

---

### Banner

#### Banner LIST

**Endpoint:** `GET /admin-api/banners`

**Açıklama:** Banner cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek banners adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | banner arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

#### Banner POST

**Endpoint:** `POST /admin-api/banners`

**Açıklama:** Banner postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

#### Banner COUNT

**Endpoint:** `GET /admin-api/banners/count`

**Açıklama:** Banner cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek banners adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | banner arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

#### Banner GET

**Endpoint:** `GET /admin-api/banners/{id}`

**Açıklama:** Banner getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

#### Banner PUT

**Endpoint:** `PUT /admin-api/banners/{id}`

**Açıklama:** Banner putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

#### Banner DELETE

**Endpoint:** `DELETE /admin-api/banners/{id}`

**Açıklama:** Banner deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Banner](#schema-banner)

---

### BddkCategory

#### BddkCategory PutRemotelyAction PUT

**Endpoint:** `PUT /admin-api/bddk_categories/update_remotely`

**Açıklama:** BddkCategory putRemotelyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| paymentProvider | query | ✓ | integer | Payment gateway id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### BillingAddress

#### BillingAddress LIST

**Endpoint:** `GET /admin-api/billing_addresses`

**Açıklama:** BillingAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Billing Address adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | BillingAddress arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)

---

#### BillingAddress POST

**Endpoint:** `POST /admin-api/billing_addresses`

**Açıklama:** BillingAddress postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)

---

#### BillingAddress COUNT

**Endpoint:** `GET /admin-api/billing_addresses/count`

**Açıklama:** BillingAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Billing Address adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | BillingAddress arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)

---

#### BillingAddress GET

**Endpoint:** `GET /admin-api/billing_addresses/{id}`

**Açıklama:** BillingAddress getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)

---

#### BillingAddress PUT

**Endpoint:** `PUT /admin-api/billing_addresses/{id}`

**Açıklama:** BillingAddress putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BillingAddress](#schema-billingaddress)

---

### Blacklist

#### Blacklist LIST

**Endpoint:** `GET /admin-api/blacklists`

**Açıklama:** Blacklist cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blacklists adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Blacklist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blacklist](#schema-blacklist)

---

#### Blacklist COUNT

**Endpoint:** `GET /admin-api/blacklists/count`

**Açıklama:** Blacklist cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blacklists adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Blacklist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blacklist](#schema-blacklist)

---

#### Blacklist GET

**Endpoint:** `GET /admin-api/blacklists/{id}`

**Açıklama:** Blacklist getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blacklist](#schema-blacklist)

---

#### Blacklist DELETE

**Endpoint:** `DELETE /admin-api/blacklists/{id}`

**Açıklama:** Blacklist deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blacklist](#schema-blacklist)

---

### Block

#### Block LIST

**Endpoint:** `GET /admin-api/blocks`

**Açıklama:** Block cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

#### Block POST

**Endpoint:** `POST /admin-api/blocks`

**Açıklama:** Block postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

#### Block COUNT

**Endpoint:** `GET /admin-api/blocks/count`

**Açıklama:** Block cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

#### Block GET

**Endpoint:** `GET /admin-api/blocks/{id}`

**Açıklama:** Block getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

#### Block PUT

**Endpoint:** `PUT /admin-api/blocks/{id}`

**Açıklama:** Block putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

#### Block DELETE

**Endpoint:** `DELETE /admin-api/blocks/{id}`

**Açıklama:** Block deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Block](#schema-block)

---

### Blog

#### Blog LIST

**Endpoint:** `GET /admin-api/blogs`

**Açıklama:** Blog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blog adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| blogCategory | query |  | integer | Blog category arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Blog arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

#### Blog POST

**Endpoint:** `POST /admin-api/blogs`

**Açıklama:** Blog postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

#### Blog COUNT

**Endpoint:** `GET /admin-api/blogs/count`

**Açıklama:** Blog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blog adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| blogCategory | query |  | integer | Blog category arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Blog arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

#### Blog GET

**Endpoint:** `GET /admin-api/blogs/{id}`

**Açıklama:** Blog getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

#### Blog PUT

**Endpoint:** `PUT /admin-api/blogs/{id}`

**Açıklama:** Blog putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

#### Blog DELETE

**Endpoint:** `DELETE /admin-api/blogs/{id}`

**Açıklama:** Blog deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Blog](#schema-blog)

---

### BlogCategory

#### BlogCategory LIST

**Endpoint:** `GET /admin-api/blog_categories`

**Açıklama:** BlogCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek BlogCategories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | BlogCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory POST

**Endpoint:** `POST /admin-api/blog_categories`

**Açıklama:** BlogCategory postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory COUNT

**Endpoint:** `GET /admin-api/blog_categories/count`

**Açıklama:** BlogCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek BlogCategories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | BlogCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory GET

**Endpoint:** `GET /admin-api/blog_categories/{id}`

**Açıklama:** BlogCategory getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory PUT

**Endpoint:** `PUT /admin-api/blog_categories/{id}`

**Açıklama:** BlogCategory putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory DELETE

**Endpoint:** `DELETE /admin-api/blog_categories/{id}`

**Açıklama:** BlogCategory deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCategory](#schema-blogcategory)

---

#### BlogCategory TreeAction GET

**Endpoint:** `GET /admin-api/blog_categories/tree`

**Açıklama:** BlogCategory treeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Blog Categories adedi |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Blog arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### BlogCategory SearchTreeAction GET

**Endpoint:** `GET /admin-api/blog_categories/search_tree`

**Açıklama:** BlogCategory searchTreeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Blog Categories adedi |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Blog Category arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| parent | query |  | string | Parent Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### BlogCommentPref

#### BlogCommentPref GET

**Endpoint:** `GET /admin-api/blog_comment_pref`

**Açıklama:** BlogCommentPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCommentPref](#schema-blogcommentpref)

---

#### BlogCommentPref PUT

**Endpoint:** `PUT /admin-api/blog_comment_pref`

**Açıklama:** BlogCommentPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCommentPref](#schema-blogcommentpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogCommentPref](#schema-blogcommentpref)

---

### BlogTag

#### BlogTag LIST

**Endpoint:** `GET /admin-api/blog_tags`

**Açıklama:** BlogTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek BlogTags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | BlogTag arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

#### BlogTag POST

**Endpoint:** `POST /admin-api/blog_tags`

**Açıklama:** BlogTag postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

#### BlogTag COUNT

**Endpoint:** `GET /admin-api/blog_tags/count`

**Açıklama:** BlogTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek BlogTags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | BlogTag arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

#### BlogTag GET

**Endpoint:** `GET /admin-api/blog_tags/{id}`

**Açıklama:** BlogTag getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

#### BlogTag PUT

**Endpoint:** `PUT /admin-api/blog_tags/{id}`

**Açıklama:** BlogTag putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

#### BlogTag DELETE

**Endpoint:** `DELETE /admin-api/blog_tags/{id}`

**Açıklama:** BlogTag deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [BlogTag](#schema-blogtag)

---

### Brand

#### Brand LIST

**Endpoint:** `GET /admin-api/brands`

**Açıklama:** Brand cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Brands adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| distributor | query |  | string | Brand Distributor |
| displayShowcaseContent | query |  | string | displayShowcaseContent can be 0 1 or 2 <br>İzin verilen değerler: `0`, `1`, `2` |
| displayShowcaseFooterContent | query |  | string | displayShowcaseFooterContent can be 0 1 or 2<br>İzin verilen değerler: `0`, `1`, `2` |
| q | query |  | string | Brand arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand POST

**Endpoint:** `POST /admin-api/brands`

**Açıklama:** Brand postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand COUNT

**Endpoint:** `GET /admin-api/brands/count`

**Açıklama:** Brand cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Brands adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| distributor | query |  | string | Brand Distributor |
| displayShowcaseContent | query |  | string | displayShowcaseContent can be 0 1 or 2 <br>İzin verilen değerler: `0`, `1`, `2` |
| displayShowcaseFooterContent | query |  | string | displayShowcaseFooterContent can be 0 1 or 2<br>İzin verilen değerler: `0`, `1`, `2` |
| q | query |  | string | Brand arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand GET

**Endpoint:** `GET /admin-api/brands/{id}`

**Açıklama:** Brand getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand PUT

**Endpoint:** `PUT /admin-api/brands/{id}`

**Açıklama:** Brand putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand DELETE

**Endpoint:** `DELETE /admin-api/brands/{id}`

**Açıklama:** Brand deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Brand](#schema-brand)

---

#### Brand GetUsedIntegrationDistributors GET

**Endpoint:** `GET /admin-api/brands/integration_distributors`

**Açıklama:** Brand getUsedIntegrationDistributors

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Cart

#### Cart GET

**Endpoint:** `GET /admin-api/carts/{id}`

**Açıklama:** Cart getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string | Sepet nesnesinin id değeri |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Cart](#schema-cart)

---

### Category

#### Category LIST

**Endpoint:** `GET /admin-api/categories`

**Açıklama:** Category cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Categories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| displayShowcaseContent | query |  | string | displayShowcaseContent  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| displayShowcaseFooterContent | query |  | string | displayShowcaseFooterContent  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| distributor | query |  | string | Category Distributor |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Category arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category POST

**Endpoint:** `POST /admin-api/categories`

**Açıklama:** Category postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category COUNT

**Endpoint:** `GET /admin-api/categories/count`

**Açıklama:** Category cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Categories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| displayShowcaseContent | query |  | string | displayShowcaseContent  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| displayShowcaseFooterContent | query |  | string | displayShowcaseFooterContent  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| distributor | query |  | string | Category Distributor |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Category arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category GET

**Endpoint:** `GET /admin-api/categories/{id}`

**Açıklama:** Category getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category PUT

**Endpoint:** `PUT /admin-api/categories/{id}`

**Açıklama:** Category putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category DELETE

**Endpoint:** `DELETE /admin-api/categories/{id}`

**Açıklama:** Category deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Category](#schema-category)

---

#### Category SearchTreeAction GET

**Endpoint:** `GET /admin-api/categories/search_tree`

**Açıklama:** Category searchTreeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Categories adedi |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Category arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| parent | query |  | string | Parent Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### CategoryMapping

#### CategoryMapping LIST

**Endpoint:** `GET /admin-api/category_mappings`

**Açıklama:** CategoryMapping cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Product Mappings per page |
| page | query |  | integer | Which page to start from |
| category | query |  | integer | Category Id |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| type | query |  | string | Type Filter. |
| q | query |  | string | CategoryMapping search filter. Usage: q[<valid-query-param>] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)

---

#### CategoryMapping POST

**Endpoint:** `POST /admin-api/category_mappings`

**Açıklama:** CategoryMapping postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)

---

#### CategoryMapping COUNT

**Endpoint:** `GET /admin-api/category_mappings/count`

**Açıklama:** CategoryMapping cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Product Mappings per page |
| page | query |  | integer | Which page to start from |
| category | query |  | integer | Category Id |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| type | query |  | string | Type Filter. |
| q | query |  | string | CategoryMapping search filter. Usage: q[<valid-query-param>] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)

---

#### CategoryMapping GET

**Endpoint:** `GET /admin-api/category_mappings/{id}`

**Açıklama:** CategoryMapping getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)

---

#### CategoryMapping DELETE

**Endpoint:** `DELETE /admin-api/category_mappings/{id}`

**Açıklama:** CategoryMapping deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [CategoryMapping](#schema-categorymapping)

---

### CheckoutDesignPref

#### CheckoutDesignPref LIST

**Endpoint:** `GET /admin-api/checkout_design_pref`

**Açıklama:** CheckoutDesignPref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CheckoutDesignPref](#schema-checkoutdesignpref)

---

#### CheckoutDesignPref PUT

**Endpoint:** `PUT /admin-api/checkout_design_pref`

**Açıklama:** CheckoutDesignPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CheckoutDesignPref](#schema-checkoutdesignpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CheckoutDesignPref](#schema-checkoutdesignpref)

---

#### CheckoutDesignPref DeleteImageAction DELETE

**Endpoint:** `DELETE /admin-api/checkout_design_pref/delete_image/{type}`

**Açıklama:** CheckoutDesignPref deleteImageAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Client

#### Client LIST

**Endpoint:** `GET /admin-api/clients`

**Açıklama:** Client cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| randomId | query |  | string | random_id |
| name | query |  | string | name |
| q | query |  | string | Client arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

#### Client POST

**Endpoint:** `POST /admin-api/clients`

**Açıklama:** Client postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

#### Client COUNT

**Endpoint:** `GET /admin-api/clients/count`

**Açıklama:** Client cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| randomId | query |  | string | random_id |
| name | query |  | string | name |
| q | query |  | string | Client arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

#### Client GET

**Endpoint:** `GET /admin-api/clients/{id}`

**Açıklama:** Client getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

#### Client PUT

**Endpoint:** `PUT /admin-api/clients/{id}`

**Açıklama:** Client putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

#### Client DELETE

**Endpoint:** `DELETE /admin-api/clients/{id}`

**Açıklama:** Client deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Client](#schema-client)

---

### ClientPermission

#### ClientPermission LIST

**Endpoint:** `GET /admin-api/client_permissions`

**Açıklama:** ClientPermission cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| client | query |  | string | Client Id |
| q | query |  | string | ClientPermission arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

#### ClientPermission POST

**Endpoint:** `POST /admin-api/client_permissions`

**Açıklama:** ClientPermission postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

#### ClientPermission COUNT

**Endpoint:** `GET /admin-api/client_permissions/count`

**Açıklama:** ClientPermission cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| client | query |  | string | Client Id |
| q | query |  | string | ClientPermission arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

#### ClientPermission GET

**Endpoint:** `GET /admin-api/client_permissions/{id}`

**Açıklama:** ClientPermission getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

#### ClientPermission PUT

**Endpoint:** `PUT /admin-api/client_permissions/{id}`

**Açıklama:** ClientPermission putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

#### ClientPermission DELETE

**Endpoint:** `DELETE /admin-api/client_permissions/{id}`

**Açıklama:** ClientPermission deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientPermission](#schema-clientpermission)

---

### ClientWebhook

#### ClientWebhook LIST

**Endpoint:** `GET /admin-api/client_webhooks`

**Açıklama:** ClientWebhook cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek webhooks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| topic | query |  | string | Webhook Topic. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

#### ClientWebhook POST

**Endpoint:** `POST /admin-api/client_webhooks`

**Açıklama:** ClientWebhook postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

#### ClientWebhook COUNT

**Endpoint:** `GET /admin-api/client_webhooks/count`

**Açıklama:** ClientWebhook cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek webhooks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| topic | query |  | string | Webhook Topic. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

#### ClientWebhook GET

**Endpoint:** `GET /admin-api/client_webhooks/{id}`

**Açıklama:** ClientWebhook getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

#### ClientWebhook PUT

**Endpoint:** `PUT /admin-api/client_webhooks/{id}`

**Açıklama:** ClientWebhook putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

#### ClientWebhook DELETE

**Endpoint:** `DELETE /admin-api/client_webhooks/{id}`

**Açıklama:** ClientWebhook deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ClientWebhook](#schema-clientwebhook)

---

### CombineProduct

#### CombineProduct LIST

**Endpoint:** `GET /admin-api/combine_products`

**Açıklama:** CombineProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Combine Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| combineProduct | query |  | integer | Combine Product Id |
| q | query |  | string | Combine Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

#### CombineProduct POST

**Endpoint:** `POST /admin-api/combine_products`

**Açıklama:** CombineProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

#### CombineProduct COUNT

**Endpoint:** `GET /admin-api/combine_products/count`

**Açıklama:** CombineProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Combine Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| combineProduct | query |  | integer | Combine Product Id |
| q | query |  | string | Combine Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

#### CombineProduct GET

**Endpoint:** `GET /admin-api/combine_products/{id}`

**Açıklama:** CombineProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

#### CombineProduct PUT

**Endpoint:** `PUT /admin-api/combine_products/{id}`

**Açıklama:** CombineProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

#### CombineProduct DELETE

**Endpoint:** `DELETE /admin-api/combine_products/{id}`

**Açıklama:** CombineProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [CombineProduct](#schema-combineproduct)

---

### CommonFileTranslation

#### CommonFileTranslation LIST

**Endpoint:** `GET /admin-api/common_file_translation`

**Açıklama:** CommonFileTranslation cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| language | query | ✓ | string | Translation Language Code |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonFileTranslation](#schema-commonfiletranslation)

---

#### CommonFileTranslation PUT

**Endpoint:** `PUT /admin-api/common_file_translation`

**Açıklama:** CommonFileTranslation putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonFileTranslation](#schema-commonfiletranslation)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonFileTranslation](#schema-commonfiletranslation)

---

#### CommonFileTranslation POST

**Endpoint:** `POST /admin-api/common_file_translation`

**Açıklama:** CommonFileTranslation postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonFileTranslation](#schema-commonfiletranslation)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonFileTranslation](#schema-commonfiletranslation)

---

#### CommonFileTranslation DeleteFileAction DELETE

**Endpoint:** `DELETE /admin-api/common_file_translation`

**Açıklama:** CommonFileTranslation deleteFileAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| language | query | ✓ | string | Translation Language Code |
| type | query |  | string | File type for delete file action.. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### CommonPref

#### CommonPref LIST

**Endpoint:** `GET /admin-api/common_pref`

**Açıklama:** CommonPref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonPref](#schema-commonpref)

---

#### CommonPref PUT

**Endpoint:** `PUT /admin-api/common_pref`

**Açıklama:** CommonPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonPref](#schema-commonpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CommonPref](#schema-commonpref)

---

#### CommonPref DeleteFileAction DELETE

**Endpoint:** `DELETE /admin-api/common_pref/delete_file`

**Açıklama:** CommonPref deleteFileAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | query | ✓ | string | File type for delete file action..<br>İzin verilen değerler: `mail_logo`, `favicon` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Contract

#### Contract LIST

**Endpoint:** `GET /admin-api/contracts`

**Açıklama:** Contract cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Contracts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Contracts arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| subscription | query |  | integer | Subscription Id |
| productId | query |  | string | Contract product id filtresi. |
| email | query |  | string | Contract email filtresi. |
| periodFrequency | query |  | string | Contract period frequency filtresi. |
| paymentProvider | query |  | string | Contract payment provider filtresi. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Contract](#schema-contract)

---

#### Contract COUNT

**Endpoint:** `GET /admin-api/contracts/count`

**Açıklama:** Contract cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Contracts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Contracts arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| subscription | query |  | integer | Subscription Id |
| productId | query |  | string | Contract product id filtresi. |
| email | query |  | string | Contract email filtresi. |
| periodFrequency | query |  | string | Contract period frequency filtresi. |
| paymentProvider | query |  | string | Contract payment provider filtresi. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Contract](#schema-contract)

---

#### Contract GET

**Endpoint:** `GET /admin-api/contracts/{id}`

**Açıklama:** Contract getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Contract](#schema-contract)

---

#### Contract PUT

**Endpoint:** `PUT /admin-api/contracts/{id}`

**Açıklama:** Contract putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Contract](#schema-contract)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Contract](#schema-contract)

---

### ContractPlan

#### ContractPlan LIST

**Endpoint:** `GET /admin-api/contract_plans`

**Açıklama:** ContractPlan cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Contract Plans adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ContractPlans arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| contract | query |  | integer | Contract Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ContractPlan](#schema-contractplan)

---

#### ContractPlan COUNT

**Endpoint:** `GET /admin-api/contract_plans/count`

**Açıklama:** ContractPlan cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Contract Plans adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ContractPlans arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| contract | query |  | integer | Contract Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ContractPlan](#schema-contractplan)

---

#### ContractPlan GET

**Endpoint:** `GET /admin-api/contract_plans/{id}`

**Açıklama:** ContractPlan getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ContractPlan](#schema-contractplan)

---

### Country

#### Country LIST

**Endpoint:** `GET /admin-api/countries`

**Açıklama:** Country cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Countries adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Country status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Country arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Country](#schema-country)

---

#### Country COUNT

**Endpoint:** `GET /admin-api/countries/count`

**Açıklama:** Country cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Countries adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Country status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Country arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Country](#schema-country)

---

#### Country GET

**Endpoint:** `GET /admin-api/countries/{id}`

**Açıklama:** Country getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Country](#schema-country)

---

#### Country PUT

**Endpoint:** `PUT /admin-api/countries/{id}`

**Açıklama:** Country putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Country](#schema-country)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Country](#schema-country)

---

### Coupon

#### Coupon LIST

**Endpoint:** `GET /admin-api/coupons`

**Açıklama:** Coupon cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Coupon adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| creatorType | query |  | string | Coupon creator type filtresi. |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| status | query |  | string | Coupon status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Coupon arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

#### Coupon POST

**Endpoint:** `POST /admin-api/coupons`

**Açıklama:** Coupon postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

#### Coupon COUNT

**Endpoint:** `GET /admin-api/coupons/count`

**Açıklama:** Coupon cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Coupon adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| creatorType | query |  | string | Coupon creator type filtresi. |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| status | query |  | string | Coupon status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Coupon arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

#### Coupon GET

**Endpoint:** `GET /admin-api/coupons/{id}`

**Açıklama:** Coupon getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

#### Coupon PUT

**Endpoint:** `PUT /admin-api/coupons/{id}`

**Açıklama:** Coupon putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

#### Coupon DELETE

**Endpoint:** `DELETE /admin-api/coupons/{id}`

**Açıklama:** Coupon deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Coupon](#schema-coupon)

---

### Currency

#### Currency LIST

**Endpoint:** `GET /admin-api/currencies`

**Açıklama:** Currency cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Currencies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Currency arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Currency](#schema-currency)

---

#### Currency COUNT

**Endpoint:** `GET /admin-api/currencies/count`

**Açıklama:** Currency cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Currencies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Currency arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Currency](#schema-currency)

---

#### Currency GET

**Endpoint:** `GET /admin-api/currencies/{id}`

**Açıklama:** Currency getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Currency](#schema-currency)

---

#### Currency PUT

**Endpoint:** `PUT /admin-api/currencies/{id}`

**Açıklama:** Currency putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Currency](#schema-currency)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Currency](#schema-currency)

---

### CurrentAccount

#### CurrentAccount LIST

**Endpoint:** `GET /admin-api/current_accounts`

**Açıklama:** CurrentAccount cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Current Accounts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| member | query |  | integer | Member Id |
| q | query |  | string | Current Accounts arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

#### CurrentAccount POST

**Endpoint:** `POST /admin-api/current_accounts`

**Açıklama:** CurrentAccount postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

#### CurrentAccount COUNT

**Endpoint:** `GET /admin-api/current_accounts/count`

**Açıklama:** CurrentAccount cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Current Accounts adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| member | query |  | integer | Member Id |
| q | query |  | string | Current Accounts arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

#### CurrentAccount GET

**Endpoint:** `GET /admin-api/current_accounts/{id}`

**Açıklama:** CurrentAccount getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

#### CurrentAccount PUT

**Endpoint:** `PUT /admin-api/current_accounts/{id}`

**Açıklama:** CurrentAccount putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

#### CurrentAccount DELETE

**Endpoint:** `DELETE /admin-api/current_accounts/{id}`

**Açıklama:** CurrentAccount deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [CurrentAccount](#schema-currentaccount)

---

### CustomTax

#### CustomTax LIST

**Endpoint:** `GET /admin-api/custom_taxes`

**Açıklama:** CustomTax cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek CustomTaxes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Custom tax arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)

---

#### CustomTax POST

**Endpoint:** `POST /admin-api/custom_taxes`

**Açıklama:** CustomTax postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)

---

#### CustomTax GET

**Endpoint:** `GET /admin-api/custom_taxes/{id}`

**Açıklama:** CustomTax getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)

---

#### CustomTax PUT

**Endpoint:** `PUT /admin-api/custom_taxes/{id}`

**Açıklama:** CustomTax putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)

---

#### CustomTax DELETE

**Endpoint:** `DELETE /admin-api/custom_taxes/{id}`

**Açıklama:** CustomTax deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomTax](#schema-customtax)

---

### CustomizationGroup

#### CustomizationGroup GET

**Endpoint:** `GET /admin-api/customization_groups`

**Açıklama:** CustomizationGroup getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomizationGroup](#schema-customizationgroup)

---

#### CustomizationGroup PUT

**Endpoint:** `PUT /admin-api/customization_groups/{id}`

**Açıklama:** CustomizationGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomizationGroup](#schema-customizationgroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [CustomizationGroup](#schema-customizationgroup)

---

### Default

#### Default PageSettingsAction PUT

**Endpoint:** `PUT /admin-api/page_settings`

**Açıklama:** Default pageSettingsAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Default GetHelpPage GET

**Endpoint:** `GET /admin-api/help/{id}`

**Açıklama:** Default getHelpPage

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Distributor

#### Distributor LIST

**Endpoint:** `GET /admin-api/distributors`

**Açıklama:** Distributor cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Distributors adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Distributors arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

#### Distributor POST

**Endpoint:** `POST /admin-api/distributors`

**Açıklama:** Distributor postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

#### Distributor COUNT

**Endpoint:** `GET /admin-api/distributors/count`

**Açıklama:** Distributor cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Distributors adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Distributors arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

#### Distributor GET

**Endpoint:** `GET /admin-api/distributors/{id}`

**Açıklama:** Distributor getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

#### Distributor PUT

**Endpoint:** `PUT /admin-api/distributors/{id}`

**Açıklama:** Distributor putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

#### Distributor DELETE

**Endpoint:** `DELETE /admin-api/distributors/{id}`

**Açıklama:** Distributor deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Distributor](#schema-distributor)

---

### DraftOrder

#### DraftOrder LIST

**Endpoint:** `GET /admin-api/draft_orders`

**Açıklama:** DraftOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| q | query |  | string | Order arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| user | query |  | integer | User Id |
| member | query |  | integer | Member Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

#### DraftOrder POST

**Endpoint:** `POST /admin-api/draft_orders`

**Açıklama:** DraftOrder postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

#### DraftOrder COUNT

**Endpoint:** `GET /admin-api/draft_orders/count`

**Açıklama:** DraftOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| q | query |  | string | Order arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| user | query |  | integer | User Id |
| member | query |  | integer | Member Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

#### DraftOrder GET

**Endpoint:** `GET /admin-api/draft_orders/{id}`

**Açıklama:** DraftOrder getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

#### DraftOrder PUT

**Endpoint:** `PUT /admin-api/draft_orders/{id}`

**Açıklama:** DraftOrder putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

#### DraftOrder DELETE

**Endpoint:** `DELETE /admin-api/draft_orders/{id}`

**Açıklama:** DraftOrder deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [DraftOrder](#schema-draftorder)

---

### DropdownPref

#### DropdownPref GET

**Endpoint:** `GET /admin-api/dropdown_pref`

**Açıklama:** DropdownPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DropdownPref](#schema-dropdownpref)

---

#### DropdownPref PUT

**Endpoint:** `PUT /admin-api/dropdown_pref`

**Açıklama:** DropdownPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [DropdownPref](#schema-dropdownpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [DropdownPref](#schema-dropdownpref)

---

### ExtraInfo

#### ExtraInfo LIST

**Endpoint:** `GET /admin-api/extra_infos`

**Açıklama:** ExtraInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ExtraInfos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ExtraInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

#### ExtraInfo POST

**Endpoint:** `POST /admin-api/extra_infos`

**Açıklama:** ExtraInfo postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

#### ExtraInfo COUNT

**Endpoint:** `GET /admin-api/extra_infos/count`

**Açıklama:** ExtraInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ExtraInfos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ExtraInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

#### ExtraInfo GET

**Endpoint:** `GET /admin-api/extra_infos/{id}`

**Açıklama:** ExtraInfo getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

#### ExtraInfo PUT

**Endpoint:** `PUT /admin-api/extra_infos/{id}`

**Açıklama:** ExtraInfo putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

#### ExtraInfo DELETE

**Endpoint:** `DELETE /admin-api/extra_infos/{id}`

**Açıklama:** ExtraInfo deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInfo](#schema-extrainfo)

---

### ExtraInstallment

#### ExtraInstallment LIST

**Endpoint:** `GET /admin-api/extra_installments`

**Açıklama:** ExtraInstallment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ExtraInstallments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentGateway | query |  | integer | Payment Gateway Id |
| paymentGatewayCode | query |  | string | Payment Gateway Code |
| q | query |  | string | ExtraInstallment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInstallment](#schema-extrainstallment)

---

#### ExtraInstallment COUNT

**Endpoint:** `GET /admin-api/extra_installments/count`

**Açıklama:** ExtraInstallment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ExtraInstallments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentGateway | query |  | integer | Payment Gateway Id |
| paymentGatewayCode | query |  | string | Payment Gateway Code |
| q | query |  | string | ExtraInstallment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInstallment](#schema-extrainstallment)

---

#### ExtraInstallment GET

**Endpoint:** `GET /admin-api/extra_installments/{id}`

**Açıklama:** ExtraInstallment getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInstallment](#schema-extrainstallment)

---

#### ExtraInstallment PUT

**Endpoint:** `PUT /admin-api/extra_installments/{id}`

**Açıklama:** ExtraInstallment putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInstallment](#schema-extrainstallment)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraInstallment](#schema-extrainstallment)

---

### ExtraPref

#### ExtraPref LIST

**Endpoint:** `GET /admin-api/extra_pref`

**Açıklama:** ExtraPref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraPref](#schema-extrapref)

---

#### ExtraPref PUT

**Endpoint:** `PUT /admin-api/extra_pref`

**Açıklama:** ExtraPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraPref](#schema-extrapref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ExtraPref](#schema-extrapref)

---

### FileManager

#### FileManager LIST

**Endpoint:** `GET /admin-api/file_manager/list`

**Açıklama:** FileManager cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager CreateFileAction POST

**Endpoint:** `POST /admin-api/file_manager/create_file`

**Açıklama:** FileManager createFileAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager CreateDirectoryAction POST

**Endpoint:** `POST /admin-api/file_manager/create_directory`

**Açıklama:** FileManager createDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager DeleteFileAction DELETE

**Endpoint:** `DELETE /admin-api/file_manager/delete_file`

**Açıklama:** FileManager deleteFileAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager DeleteDirectoryAction DELETE

**Endpoint:** `DELETE /admin-api/file_manager/delete_directory`

**Açıklama:** FileManager deleteDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager ZipDirectoryAction GET

**Endpoint:** `GET /admin-api/file_manager/zip_directory`

**Açıklama:** FileManager zipDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager LIST

**Endpoint:** `GET /admin-api/editor_file_manager/list`

**Açıklama:** FileManager cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager CreateFileAction POST

**Endpoint:** `POST /admin-api/editor_file_manager/create_file`

**Açıklama:** FileManager createFileAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager CreateDirectoryAction POST

**Endpoint:** `POST /admin-api/editor_file_manager/create_directory`

**Açıklama:** FileManager createDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager DeleteFileAction DELETE

**Endpoint:** `DELETE /admin-api/editor_file_manager/delete_file`

**Açıklama:** FileManager deleteFileAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager DeleteDirectoryAction DELETE

**Endpoint:** `DELETE /admin-api/editor_file_manager/delete_directory`

**Açıklama:** FileManager deleteDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### FileManager ZipDirectoryAction GET

**Endpoint:** `GET /admin-api/editor_file_manager/zip_directory`

**Açıklama:** FileManager zipDirectoryAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### FilterMenu

#### FilterMenu LIST

**Endpoint:** `GET /admin-api/filter_menus`

**Açıklama:** FilterMenu cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| q | query |  | string | FilterMenu arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FilterMenu](#schema-filtermenu)

---

#### FilterMenu COUNT

**Endpoint:** `GET /admin-api/filter_menus/count`

**Açıklama:** FilterMenu cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| q | query |  | string | FilterMenu arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FilterMenu](#schema-filtermenu)

---

#### FilterMenu GET

**Endpoint:** `GET /admin-api/filter_menus/{id}`

**Açıklama:** FilterMenu getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FilterMenu](#schema-filtermenu)

---

#### FilterMenu PUT

**Endpoint:** `PUT /admin-api/filter_menus/{id}`

**Açıklama:** FilterMenu putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [FilterMenu](#schema-filtermenu)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FilterMenu](#schema-filtermenu)

---

### Form

#### Form LIST

**Endpoint:** `GET /admin-api/forms`

**Açıklama:** Form cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Forms adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Form arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| language | query |  | string | Translation Language Code |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

#### Form POST

**Endpoint:** `POST /admin-api/forms`

**Açıklama:** Form postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

#### Form COUNT

**Endpoint:** `GET /admin-api/forms/count`

**Açıklama:** Form cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Forms adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Form arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| language | query |  | string | Translation Language Code |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

#### Form GET

**Endpoint:** `GET /admin-api/forms/{id}`

**Açıklama:** Form getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

#### Form PUT

**Endpoint:** `PUT /admin-api/forms/{id}`

**Açıklama:** Form putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

#### Form DELETE

**Endpoint:** `DELETE /admin-api/forms/{id}`

**Açıklama:** Form deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Form](#schema-form)

---

### FraudOrder

#### FraudOrder LIST

**Endpoint:** `GET /admin-api/fraud_to_orders`

**Açıklama:** FraudOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Fraud Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | FraudOrder arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| fraud | query |  | integer | Fraud Risk Id |
| order | query |  | integer | Order Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudOrder](#schema-fraudorder)

---

#### FraudOrder COUNT

**Endpoint:** `GET /admin-api/fraud_to_orders/count`

**Açıklama:** FraudOrder cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Fraud Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | FraudOrder arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| fraud | query |  | integer | Fraud Risk Id |
| order | query |  | integer | Order Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudOrder](#schema-fraudorder)

---

#### FraudOrder GET

**Endpoint:** `GET /admin-api/fraud_to_orders/{id}`

**Açıklama:** FraudOrder getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudOrder](#schema-fraudorder)

---

### FraudRisk

#### FraudRisk LIST

**Endpoint:** `GET /admin-api/fraud_risks`

**Açıklama:** FraudRisk cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek FraudRisks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | FraudRisk arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

#### FraudRisk POST

**Endpoint:** `POST /admin-api/fraud_risks`

**Açıklama:** FraudRisk postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

#### FraudRisk COUNT

**Endpoint:** `GET /admin-api/fraud_risks/count`

**Açıklama:** FraudRisk cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek FraudRisks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | FraudRisk arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

#### FraudRisk GET

**Endpoint:** `GET /admin-api/fraud_risks/{id}`

**Açıklama:** FraudRisk getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

#### FraudRisk PUT

**Endpoint:** `PUT /admin-api/fraud_risks/{id}`

**Açıklama:** FraudRisk putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

#### FraudRisk DELETE

**Endpoint:** `DELETE /admin-api/fraud_risks/{id}`

**Açıklama:** FraudRisk deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [FraudRisk](#schema-fraudrisk)

---

### GoogleAnalytics

#### GoogleAnalytics GetProductVisitCountAction GET

**Endpoint:** `GET /admin-api/linked_accounts/google_analytics/product_visit_count`

**Açıklama:** GoogleAnalytics getProductVisitCountAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### GoogleAnalytics GetPageViewAndSessionAction GET

**Endpoint:** `GET /admin-api/linked_accounts/google_analytics/visit_and_session_count`

**Açıklama:** GoogleAnalytics getPageViewAndSessionAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### InstagramShop

#### InstagramShop LIST

**Endpoint:** `GET /admin-api/instagram_shops`

**Açıklama:** InstagramShop cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShop adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShop arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShop](#schema-instagramshop)

---

#### InstagramShop COUNT

**Endpoint:** `GET /admin-api/instagram_shops/count`

**Açıklama:** InstagramShop cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShop adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShop arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShop](#schema-instagramshop)

---

#### InstagramShop GET

**Endpoint:** `GET /admin-api/instagram_shops/{id}`

**Açıklama:** InstagramShop getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShop](#schema-instagramshop)

---

#### InstagramShop PUT

**Endpoint:** `PUT /admin-api/instagram_shops/{id}`

**Açıklama:** InstagramShop putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShop](#schema-instagramshop)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShop](#schema-instagramshop)

---

### InstagramShopProduct

#### InstagramShopProduct LIST

**Endpoint:** `GET /admin-api/instagram_shop_to_products`

**Açıklama:** InstagramShopProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShopProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShopProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

#### InstagramShopProduct POST

**Endpoint:** `POST /admin-api/instagram_shop_to_products`

**Açıklama:** InstagramShopProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

#### InstagramShopProduct COUNT

**Endpoint:** `GET /admin-api/instagram_shop_to_products/count`

**Açıklama:** InstagramShopProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShopProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShopProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

#### InstagramShopProduct GET

**Endpoint:** `GET /admin-api/instagram_shop_to_products/{id}`

**Açıklama:** InstagramShopProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

#### InstagramShopProduct PUT

**Endpoint:** `PUT /admin-api/instagram_shop_to_products/{id}`

**Açıklama:** InstagramShopProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

#### InstagramShopProduct DELETE

**Endpoint:** `DELETE /admin-api/instagram_shop_to_products/{id}`

**Açıklama:** InstagramShopProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopProduct](#schema-instagramshopproduct)

---

### InstagramShopSetting

#### InstagramShopSetting LIST

**Endpoint:** `GET /admin-api/instagram_shop_settings`

**Açıklama:** InstagramShopSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShopSetting adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShopSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopSetting](#schema-instagramshopsetting)

---

#### InstagramShopSetting COUNT

**Endpoint:** `GET /admin-api/instagram_shop_settings/count`

**Açıklama:** InstagramShopSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstagramShopSetting adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | InstagramShopSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopSetting](#schema-instagramshopsetting)

---

#### InstagramShopSetting GET

**Endpoint:** `GET /admin-api/instagram_shop_settings/{id}`

**Açıklama:** InstagramShopSetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopSetting](#schema-instagramshopsetting)

---

#### InstagramShopSetting PUT

**Endpoint:** `PUT /admin-api/instagram_shop_settings/{id}`

**Açıklama:** InstagramShopSetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopSetting](#schema-instagramshopsetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstagramShopSetting](#schema-instagramshopsetting)

---

### InstalledApplication

#### InstalledApplication LIST

**Endpoint:** `GET /admin-api/app_store/installed_applications`

**Açıklama:** InstalledApplication cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Installations per page |
| page | query |  | integer | Which page to start from |
| application | query |  | integer | Restrict results to after the specified application id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstalledApplication](#schema-installedapplication)

---

#### InstalledApplication GET

**Endpoint:** `GET /admin-api/app_store/installed_applications/{id}`

**Açıklama:** InstalledApplication getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstalledApplication](#schema-installedapplication)

---

### InstallmentRate

#### InstallmentRate LIST

**Endpoint:** `GET /admin-api/installment_rates`

**Açıklama:** InstallmentRate cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstallmentRates adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentGateway | query |  | integer | Payment Gateway Id |
| paymentGatewayCode | query |  | string | Payment Gateway Code |
| q | query |  | string | InstallmentRate arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate POST

**Endpoint:** `POST /admin-api/installment_rates`

**Açıklama:** InstallmentRate postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate COUNT

**Endpoint:** `GET /admin-api/installment_rates/count`

**Açıklama:** InstallmentRate cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek InstallmentRates adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentGateway | query |  | integer | Payment Gateway Id |
| paymentGatewayCode | query |  | string | Payment Gateway Code |
| q | query |  | string | InstallmentRate arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate GET

**Endpoint:** `GET /admin-api/installment_rates/{id}`

**Açıklama:** InstallmentRate getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate PUT

**Endpoint:** `PUT /admin-api/installment_rates/{id}`

**Açıklama:** InstallmentRate putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate DELETE

**Endpoint:** `DELETE /admin-api/installment_rates/{id}`

**Açıklama:** InstallmentRate deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [InstallmentRate](#schema-installmentrate)

---

#### InstallmentRate PutRemotelyAction PUT

**Endpoint:** `PUT /admin-api/installment_rates/update_remotely`

**Açıklama:** InstallmentRate putRemotelyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| paymentGateway | query | ✓ | integer | Payment gateway id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### InvoiceSetting

#### InvoiceSetting LIST

**Endpoint:** `GET /admin-api/invoice_setting`

**Açıklama:** InvoiceSetting cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InvoiceSetting](#schema-invoicesetting)

---

#### InvoiceSetting PUT

**Endpoint:** `PUT /admin-api/invoice_setting`

**Açıklama:** InvoiceSetting putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [InvoiceSetting](#schema-invoicesetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [InvoiceSetting](#schema-invoicesetting)

---

#### InvoiceSetting LoadDefaultSettings GET

**Endpoint:** `GET /admin-api/invoice_setting/default_settings`

**Açıklama:** InvoiceSetting loadDefaultSettings

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Label

#### Label LIST

**Endpoint:** `GET /admin-api/labels`

**Açıklama:** Label cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Labels adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| root | query |  | string | Label root id<br>İzin verilen değerler: `8`, `9`, `10` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Label arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label POST

**Endpoint:** `POST /admin-api/labels`

**Açıklama:** Label postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label COUNT

**Endpoint:** `GET /admin-api/labels/count`

**Açıklama:** Label cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Labels adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| root | query |  | string | Label root id<br>İzin verilen değerler: `8`, `9`, `10` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Label arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label GET

**Endpoint:** `GET /admin-api/labels/{id}`

**Açıklama:** Label getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label PUT

**Endpoint:** `PUT /admin-api/labels/{id}`

**Açıklama:** Label putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label DELETE

**Endpoint:** `DELETE /admin-api/labels/{id}`

**Açıklama:** Label deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Label](#schema-label)

---

#### Label TreeAction GET

**Endpoint:** `GET /admin-api/labels/tree`

**Açıklama:** Label treeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Labels adedi |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Label arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Label SearchTreeAction GET

**Endpoint:** `GET /admin-api/labels/search_tree`

**Açıklama:** Label searchTreeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Labels adedi |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Label arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| onlyChild | query |  | string | Is only child<br>İzin verilen değerler: `0`, `1` |
| parent | query |  | string | Parent Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Language

#### Language LIST

**Endpoint:** `GET /admin-api/languages`

**Açıklama:** Language cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Languages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| s | query |  | string | Arama değeri filtresi. |
| keys | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Language](#schema-language)

---

#### Language PUT

**Endpoint:** `PUT /admin-api/languages`

**Açıklama:** Language putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Language](#schema-language)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Language](#schema-language)

---

#### Language DELETE

**Endpoint:** `DELETE /admin-api/languages/reset`

**Açıklama:** Language deleteAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Language GetLanguagesAction GET

**Endpoint:** `GET /admin-api/languages/list`

**Açıklama:** Language getLanguagesAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Number of requested Language per page |
| page | query |  | integer | Which page to start from |
| q | query |  | string | Language search filter. Usage: q[<valid-query-param>] |
| status | query |  | string | Language status search filter.<br>İzin verilen değerler: `0`, `1` |
| sort | query |  | string | Example sort=id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Language GetLanguagesAction COUNT

**Endpoint:** `GET /admin-api/languages/count`

**Açıklama:** Language getLanguagesAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Number of requested Language per page |
| page | query |  | integer | Which page to start from |
| q | query |  | string | Language search filter. Usage: q[<valid-query-param>] |
| status | query |  | string | Language status search filter.<br>İzin verilen değerler: `0`, `1` |
| sort | query |  | string | Example sort=id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Language GetLanguageAction GET

**Endpoint:** `GET /admin-api/languages/{id}`

**Açıklama:** Language getLanguageAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Language PutLanguageAction PUT

**Endpoint:** `PUT /admin-api/languages/{id}`

**Açıklama:** Language putLanguageAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Location

#### Location LIST

**Endpoint:** `GET /admin-api/locations`

**Açıklama:** Location cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Locations adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| status | query |  | string | Location status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| country | query |  | integer | Country Id |
| region | query |  | integer | Region Id |
| q | query |  | string | Location arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

#### Location POST

**Endpoint:** `POST /admin-api/locations`

**Açıklama:** Location postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

#### Location COUNT

**Endpoint:** `GET /admin-api/locations/count`

**Açıklama:** Location cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Locations adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| status | query |  | string | Location status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| country | query |  | integer | Country Id |
| region | query |  | integer | Region Id |
| q | query |  | string | Location arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

#### Location GET

**Endpoint:** `GET /admin-api/locations/{id}`

**Açıklama:** Location getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

#### Location PUT

**Endpoint:** `PUT /admin-api/locations/{id}`

**Açıklama:** Location putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

#### Location DELETE

**Endpoint:** `DELETE /admin-api/locations/{id}`

**Açıklama:** Location deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Location](#schema-location)

---

### MailContent

#### MailContent GET

**Endpoint:** `GET /admin-api/mail_contents/{type}`

**Açıklama:** MailContent getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MailContent PUT

**Endpoint:** `PUT /admin-api/mail_contents/{type}`

**Açıklama:** MailContent putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MailContent DELETE

**Endpoint:** `DELETE /admin-api/mail_contents/{type}`

**Açıklama:** MailContent deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### MailContentTranslation

#### MailContentTranslation GET

**Endpoint:** `GET /admin-api/mail_content_translation/{type}`

**Açıklama:** MailContentTranslation getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MailContentTranslation PUT

**Endpoint:** `PUT /admin-api/mail_content_translation/{type}`

**Açıklama:** MailContentTranslation putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MailContentTranslation POST

**Endpoint:** `POST /admin-api/mail_content_translation/{type}`

**Açıklama:** MailContentTranslation postAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MailContentTranslation DELETE

**Endpoint:** `DELETE /admin-api/mail_content_translation/delete_file/{type}`

**Açıklama:** MailContentTranslation deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### Maillist

#### Maillist LIST

**Endpoint:** `GET /admin-api/maillists`

**Açıklama:** Maillist cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Maillist adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Maillist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| maillistGroup | query |  | integer | Sonuçları değere göre al maillist group id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

#### Maillist POST

**Endpoint:** `POST /admin-api/maillists`

**Açıklama:** Maillist postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

#### Maillist COUNT

**Endpoint:** `GET /admin-api/maillists/count`

**Açıklama:** Maillist cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Maillist adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Maillist arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| maillistGroup | query |  | integer | Sonuçları değere göre al maillist group id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

#### Maillist GET

**Endpoint:** `GET /admin-api/maillists/{id}`

**Açıklama:** Maillist getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

#### Maillist PUT

**Endpoint:** `PUT /admin-api/maillists/{id}`

**Açıklama:** Maillist putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

#### Maillist DELETE

**Endpoint:** `DELETE /admin-api/maillists/{id}`

**Açıklama:** Maillist deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Maillist](#schema-maillist)

---

### MaillistGroup

#### MaillistGroup LIST

**Endpoint:** `GET /admin-api/maillist_groups`

**Açıklama:** MaillistGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Maillist Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MaillistGroup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

#### MaillistGroup POST

**Endpoint:** `POST /admin-api/maillist_groups`

**Açıklama:** MaillistGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

#### MaillistGroup COUNT

**Endpoint:** `GET /admin-api/maillist_groups/count`

**Açıklama:** MaillistGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Maillist Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MaillistGroup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

#### MaillistGroup GET

**Endpoint:** `GET /admin-api/maillist_groups/{id}`

**Açıklama:** MaillistGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

#### MaillistGroup PUT

**Endpoint:** `PUT /admin-api/maillist_groups/{id}`

**Açıklama:** MaillistGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

#### MaillistGroup DELETE

**Endpoint:** `DELETE /admin-api/maillist_groups/{id}`

**Açıklama:** MaillistGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MaillistGroup](#schema-maillistgroup)

---

### Member

#### Member LIST

**Endpoint:** `GET /admin-api/members`

**Açıklama:** Member cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Members adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| gender | query |  | string | Gender  alanının alabilceği değerler:  male, female veya unspecified<br>İzin verilen değerler: `male`, `female`, `unspecified` |
| deviceType | query |  | string | Device type  alanının alabilceği değerler:  bilgisayar veya mobil<br>İzin verilen değerler: `bilgisayar`, `mobil` |
| status | query |  | string | Status  alanının alabilceği değerler:  active, passive, queue veya suspended<br>İzin verilen değerler: `active`, `passive`, `queue`, `suspended` |
| kvkkStatus | query |  | string | Kvkk status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToPhone | query |  | string | Allowed to phone  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToCampaigns | query |  | string | Allowed to campaigns  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToSms | query |  | string | Allowed to sms  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| memberGroup | query |  | integer | Member Group Id |
| startBirthDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endBirthDate | query |  | string (date) | Zaman aralığı bitişi |
| birthDateType | query |  | string | birthDateType status  alanının alabilceği değerler:  dd-mm-YYYY veya dd-mm<br>İzin verilen değerler: `dd-mm-YYYY`, `dd-mm` |
| orderStatus | query |  | string | Order status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| startAllowedToCampaignsUpdatedAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAllowedToCampaignsUpdatedAt | query |  | string (date) | Zaman aralığı bitişi |
| startAllowedToPhoneUpdatedAt | query |  | string (date) | Start of the time frame |
| endAllowedToPhoneUpdatedAt | query |  | string (date) | End of the time frame |
| startAllowedToSmsUpdatedAt | query |  | string (date) | Start of the time frame |
| endAllowedToSmsUpdatedAt | query |  | string (date) | End of the time frame |
| iysStatus | query |  | string | Iys status  alanının alabilceği değerler:  0,1,2.<br>İzin verilen değerler: `0`, `1`, `3` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Member POST

**Endpoint:** `POST /admin-api/members`

**Açıklama:** Member postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Member COUNT

**Endpoint:** `GET /admin-api/members/count`

**Açıklama:** Member cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Members adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| gender | query |  | string | Gender  alanının alabilceği değerler:  male, female veya unspecified<br>İzin verilen değerler: `male`, `female`, `unspecified` |
| deviceType | query |  | string | Device type  alanının alabilceği değerler:  bilgisayar veya mobil<br>İzin verilen değerler: `bilgisayar`, `mobil` |
| status | query |  | string | Status  alanının alabilceği değerler:  active, passive, queue veya suspended<br>İzin verilen değerler: `active`, `passive`, `queue`, `suspended` |
| kvkkStatus | query |  | string | Kvkk status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToPhone | query |  | string | Allowed to phone  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToCampaigns | query |  | string | Allowed to campaigns  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| allowedToSms | query |  | string | Allowed to sms  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| memberGroup | query |  | integer | Member Group Id |
| startBirthDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endBirthDate | query |  | string (date) | Zaman aralığı bitişi |
| birthDateType | query |  | string | birthDateType status  alanının alabilceği değerler:  dd-mm-YYYY veya dd-mm<br>İzin verilen değerler: `dd-mm-YYYY`, `dd-mm` |
| orderStatus | query |  | string | Order status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| startAllowedToCampaignsUpdatedAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAllowedToCampaignsUpdatedAt | query |  | string (date) | Zaman aralığı bitişi |
| startAllowedToPhoneUpdatedAt | query |  | string (date) | Start of the time frame |
| endAllowedToPhoneUpdatedAt | query |  | string (date) | End of the time frame |
| startAllowedToSmsUpdatedAt | query |  | string (date) | Start of the time frame |
| endAllowedToSmsUpdatedAt | query |  | string (date) | End of the time frame |
| iysStatus | query |  | string | Iys status  alanının alabilceği değerler:  0,1,2.<br>İzin verilen değerler: `0`, `1`, `3` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Member GET

**Endpoint:** `GET /admin-api/members/{id}`

**Açıklama:** Member getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Member PUT

**Endpoint:** `PUT /admin-api/members/{id}`

**Açıklama:** Member putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Member DELETE

**Endpoint:** `DELETE /admin-api/members/{id}`

**Açıklama:** Member deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

### MemberAddress

#### MemberAddress LIST

**Endpoint:** `GET /admin-api/member_addresses`

**Açıklama:** MemberAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek MemberAddress adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| member | query |  | integer | Member Id |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

#### MemberAddress POST

**Endpoint:** `POST /admin-api/member_addresses`

**Açıklama:** MemberAddress postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

#### MemberAddress COUNT

**Endpoint:** `GET /admin-api/member_addresses/count`

**Açıklama:** MemberAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek MemberAddress adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| member | query |  | integer | Member Id |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

#### MemberAddress GET

**Endpoint:** `GET /admin-api/member_addresses/{id}`

**Açıklama:** MemberAddress getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

#### MemberAddress PUT

**Endpoint:** `PUT /admin-api/member_addresses/{id}`

**Açıklama:** MemberAddress putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

#### MemberAddress DELETE

**Endpoint:** `DELETE /admin-api/member_addresses/{id}`

**Açıklama:** MemberAddress deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberAddress](#schema-memberaddress)

---

### MemberGroup

#### MemberGroup LIST

**Endpoint:** `GET /admin-api/member_groups`

**Açıklama:** MemberGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MemberGroup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

#### MemberGroup POST

**Endpoint:** `POST /admin-api/member_groups`

**Açıklama:** MemberGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

#### MemberGroup COUNT

**Endpoint:** `GET /admin-api/member_groups/count`

**Açıklama:** MemberGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MemberGroup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

#### MemberGroup GET

**Endpoint:** `GET /admin-api/member_groups/{id}`

**Açıklama:** MemberGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

#### MemberGroup PUT

**Endpoint:** `PUT /admin-api/member_groups/{id}`

**Açıklama:** MemberGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

#### MemberGroup DELETE

**Endpoint:** `DELETE /admin-api/member_groups/{id}`

**Açıklama:** MemberGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroup](#schema-membergroup)

---

### MemberGroupEmail

#### MemberGroupEmail LIST

**Endpoint:** `GET /admin-api/member_group_emails`

**Açıklama:** MemberGroupEmail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Member Group Email adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MemberGroupEmail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| memberGroup | query |  | integer | Member Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

#### MemberGroupEmail POST

**Endpoint:** `POST /admin-api/member_group_emails`

**Açıklama:** MemberGroupEmail postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

#### MemberGroupEmail COUNT

**Endpoint:** `GET /admin-api/member_group_emails/count`

**Açıklama:** MemberGroupEmail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Member Group Email adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MemberGroupEmail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| memberGroup | query |  | integer | Member Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

#### MemberGroupEmail GET

**Endpoint:** `GET /admin-api/member_group_emails/{id}`

**Açıklama:** MemberGroupEmail getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

#### MemberGroupEmail PUT

**Endpoint:** `PUT /admin-api/member_group_emails/{id}`

**Açıklama:** MemberGroupEmail putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

#### MemberGroupEmail DELETE

**Endpoint:** `DELETE /admin-api/member_group_emails/{id}`

**Açıklama:** MemberGroupEmail deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupEmail](#schema-membergroupemail)

---

### MemberGroupPosAccount

#### MemberGroupPosAccount LIST

**Endpoint:** `GET /admin-api/member_group_to_pos_accounts`

**Açıklama:** MemberGroupPosAccount cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| memberGroup | query |  | integer | Member Group Id |
| limit | query |  | integer | Bir sayfada gelecek MemberGroupPosAccount adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | MemberGroupPosAccount arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

#### MemberGroupPosAccount POST

**Endpoint:** `POST /admin-api/member_group_to_pos_accounts`

**Açıklama:** MemberGroupPosAccount postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

#### MemberGroupPosAccount COUNT

**Endpoint:** `GET /admin-api/member_group_to_pos_accounts/count`

**Açıklama:** MemberGroupPosAccount cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| memberGroup | query |  | integer | Member Group Id |
| limit | query |  | integer | Bir sayfada gelecek MemberGroupPosAccount adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | MemberGroupPosAccount arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

#### MemberGroupPosAccount GET

**Endpoint:** `GET /admin-api/member_group_to_pos_accounts/{id}`

**Açıklama:** MemberGroupPosAccount getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

#### MemberGroupPosAccount PUT

**Endpoint:** `PUT /admin-api/member_group_to_pos_accounts/{id}`

**Açıklama:** MemberGroupPosAccount putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

#### MemberGroupPosAccount DELETE

**Endpoint:** `DELETE /admin-api/member_group_to_pos_accounts/{id}`

**Açıklama:** MemberGroupPosAccount deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberGroupPosAccount](#schema-membergroupposaccount)

---

### MenuItem

#### MenuItem LIST

**Endpoint:** `GET /admin-api/menu_items`

**Açıklama:** MenuItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek menu item adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| parent | query |  | string | Parent Id |
| q | query |  | string | Menu item arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| level | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem POST

**Endpoint:** `POST /admin-api/menu_items`

**Açıklama:** MenuItem postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem COUNT

**Endpoint:** `GET /admin-api/menu_items/count`

**Açıklama:** MenuItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek menu item adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| parent | query |  | string | Parent Id |
| q | query |  | string | Menu item arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| level | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem GET

**Endpoint:** `GET /admin-api/menu_items/{id}`

**Açıklama:** MenuItem getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem PUT

**Endpoint:** `PUT /admin-api/menu_items/{id}`

**Açıklama:** MenuItem putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem DELETE

**Endpoint:** `DELETE /admin-api/menu_items/{id}`

**Açıklama:** MenuItem deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MenuItem](#schema-menuitem)

---

#### MenuItem TreeAction GET

**Endpoint:** `GET /admin-api/menu_items/tree`

**Açıklama:** MenuItem treeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Number of requested Categories per page |
| id | query |  | integer | Get result by id |
| q | query |  | string | Category search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### MenuItem SearchTreeAction GET

**Endpoint:** `GET /admin-api/menu_items/search_tree`

**Açıklama:** MenuItem searchTreeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Number of requested Categories per page |
| id | query |  | integer | Get result by id |
| q | query |  | string | Category search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
| parent | query |  | string | Parent Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### MerchantPoll

#### MerchantPoll LIST

**Endpoint:** `GET /admin-api/merchant_polls`

**Açıklama:** MerchantPoll cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek merhant poll adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | merhant poll arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| category | query |  | integer | Merchant poll category arama filtresi. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

#### MerchantPoll POST

**Endpoint:** `POST /admin-api/merchant_polls`

**Açıklama:** MerchantPoll postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

#### MerchantPoll COUNT

**Endpoint:** `GET /admin-api/merchant_polls/count`

**Açıklama:** MerchantPoll cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek merhant poll adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | merhant poll arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| category | query |  | integer | Merchant poll category arama filtresi. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

#### MerchantPoll GET

**Endpoint:** `GET /admin-api/merchant_polls/{id}`

**Açıklama:** MerchantPoll getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

#### MerchantPoll PUT

**Endpoint:** `PUT /admin-api/merchant_polls/{id}`

**Açıklama:** MerchantPoll putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

#### MerchantPoll DELETE

**Endpoint:** `DELETE /admin-api/merchant_polls/{id}`

**Açıklama:** MerchantPoll deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPoll](#schema-merchantpoll)

---

### MerchantPollPref

#### MerchantPollPref GET

**Endpoint:** `GET /admin-api/merchant_poll_pref`

**Açıklama:** MerchantPollPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPollPref](#schema-merchantpollpref)

---

#### MerchantPollPref PUT

**Endpoint:** `PUT /admin-api/merchant_poll_pref`

**Açıklama:** MerchantPollPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPollPref](#schema-merchantpollpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPollPref](#schema-merchantpollpref)

---

#### MerchantPollPref GET

**Endpoint:** `GET /admin-api/merchant_poll_pref/count`

**Açıklama:** MerchantPollPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MerchantPollPref](#schema-merchantpollpref)

---

### MetaField

#### MetaField LIST

**Endpoint:** `GET /admin-api/metafields`

**Açıklama:** MetaField cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Metafields adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | MetaField arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| varKey | query |  | string | MetaField arama filtresi. |
| type | query |  | string | MetaField type filtresi. |
| context | query |  | string | MetaField context filtresi. |
| contextItemId | query |  | string | MetaField contextItemId filtresi. |
| contextItemIds | query |  | string | MetaField contextItemIds filtresi. |
| varKeys | query |  | string | MetaField varKeys filtresi. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)

---

#### MetaField POST

**Endpoint:** `POST /admin-api/metafields`

**Açıklama:** MetaField postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)

---

#### MetaField GET

**Endpoint:** `GET /admin-api/metafields/{id}`

**Açıklama:** MetaField getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)

---

#### MetaField PUT

**Endpoint:** `PUT /admin-api/metafields/{id}`

**Açıklama:** MetaField putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)

---

#### MetaField DELETE

**Endpoint:** `DELETE /admin-api/metafields/{id}`

**Açıklama:** MetaField deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [MetaField](#schema-metafield)

---

### Midblock

#### Midblock LIST

**Endpoint:** `GET /admin-api/midblocks`

**Açıklama:** Midblock cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Mid Blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Mid Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

#### Midblock POST

**Endpoint:** `POST /admin-api/midblocks`

**Açıklama:** Midblock postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

#### Midblock COUNT

**Endpoint:** `GET /admin-api/midblocks/count`

**Açıklama:** Midblock cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Mid Blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Mid Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

#### Midblock GET

**Endpoint:** `GET /admin-api/midblocks/{id}`

**Açıklama:** Midblock getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

#### Midblock PUT

**Endpoint:** `PUT /admin-api/midblocks/{id}`

**Açıklama:** Midblock putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

#### Midblock DELETE

**Endpoint:** `DELETE /admin-api/midblocks/{id}`

**Açıklama:** Midblock deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Midblock](#schema-midblock)

---

### NetGsm

#### NetGsm GET

**Endpoint:** `GET /admin-api/net_gsm`

**Açıklama:** NetGsm getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsm](#schema-netgsm)

---

#### NetGsm PUT

**Endpoint:** `PUT /admin-api/net_gsm`

**Açıklama:** NetGsm putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsm](#schema-netgsm)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsm](#schema-netgsm)

---

#### NetGsm MemberBulkUploadAction POST

**Endpoint:** `POST /admin-api/net_gsm/member_bulk_upload`

**Açıklama:** NetGsm memberBulkUploadAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### NetGsmLog

#### NetGsmLog LIST

**Endpoint:** `GET /admin-api/net_gsm_logs`

**Açıklama:** NetGsmLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested NetGsm log per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsmLog](#schema-netgsmlog)

---

#### NetGsmLog COUNT

**Endpoint:** `GET /admin-api/net_gsm_logs/count`

**Açıklama:** NetGsmLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested NetGsm log per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsmLog](#schema-netgsmlog)

---

#### NetGsmLog PUT

**Endpoint:** `PUT /admin-api/net_gsm_logs/{id}`

**Açıklama:** NetGsmLog putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsmLog](#schema-netgsmlog)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [NetGsmLog](#schema-netgsmlog)

---

### Notification

#### Notification LIST

**Endpoint:** `GET /admin-api/notifications`

**Açıklama:** Notification cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Notification adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| unreadNotifiedUser | query |  | string | User Id for unread user. |
| notifiedUser | query |  | string | Notified user Id |
| q | query |  | string | Notification arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

#### Notification POST

**Endpoint:** `POST /admin-api/notifications`

**Açıklama:** Notification postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

#### Notification COUNT

**Endpoint:** `GET /admin-api/notifications/count`

**Açıklama:** Notification cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Notification adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| unreadNotifiedUser | query |  | string | User Id for unread user. |
| notifiedUser | query |  | string | Notified user Id |
| q | query |  | string | Notification arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

#### Notification GET

**Endpoint:** `GET /admin-api/notifications/{id}`

**Açıklama:** Notification getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

#### Notification PUT

**Endpoint:** `PUT /admin-api/notifications/{id}`

**Açıklama:** Notification putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

#### Notification DELETE

**Endpoint:** `DELETE /admin-api/notifications/{id}`

**Açıklama:** Notification deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Notification](#schema-notification)

---

### OfferedProduct

#### OfferedProduct LIST

**Endpoint:** `GET /admin-api/offered_products`

**Açıklama:** OfferedProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Offered Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| offeredProduct | query |  | integer | Offered Product Id |
| q | query |  | string | Offered Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

#### OfferedProduct POST

**Endpoint:** `POST /admin-api/offered_products`

**Açıklama:** OfferedProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

#### OfferedProduct COUNT

**Endpoint:** `GET /admin-api/offered_products/count`

**Açıklama:** OfferedProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Offered Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| offeredProduct | query |  | integer | Offered Product Id |
| q | query |  | string | Offered Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

#### OfferedProduct GET

**Endpoint:** `GET /admin-api/offered_products/{id}`

**Açıklama:** OfferedProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

#### OfferedProduct PUT

**Endpoint:** `PUT /admin-api/offered_products/{id}`

**Açıklama:** OfferedProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

#### OfferedProduct DELETE

**Endpoint:** `DELETE /admin-api/offered_products/{id}`

**Açıklama:** OfferedProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [OfferedProduct](#schema-offeredproduct)

---

### Option

#### Option LIST

**Endpoint:** `GET /admin-api/options`

**Açıklama:** Option cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Options adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Option arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| optionGroup | query |  | integer | Option Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

#### Option POST

**Endpoint:** `POST /admin-api/options`

**Açıklama:** Option postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

#### Option COUNT

**Endpoint:** `GET /admin-api/options/count`

**Açıklama:** Option cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Options adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Option arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| optionGroup | query |  | integer | Option Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

#### Option GET

**Endpoint:** `GET /admin-api/options/{id}`

**Açıklama:** Option getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

#### Option PUT

**Endpoint:** `PUT /admin-api/options/{id}`

**Açıklama:** Option putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

#### Option DELETE

**Endpoint:** `DELETE /admin-api/options/{id}`

**Açıklama:** Option deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Option](#schema-option)

---

### OptionGroup

#### OptionGroup LIST

**Endpoint:** `GET /admin-api/option_groups`

**Açıklama:** OptionGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Option Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Option Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

#### OptionGroup POST

**Endpoint:** `POST /admin-api/option_groups`

**Açıklama:** OptionGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

#### OptionGroup COUNT

**Endpoint:** `GET /admin-api/option_groups/count`

**Açıklama:** OptionGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Option Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Option Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

#### OptionGroup GET

**Endpoint:** `GET /admin-api/option_groups/{id}`

**Açıklama:** OptionGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

#### OptionGroup PUT

**Endpoint:** `PUT /admin-api/option_groups/{id}`

**Açıklama:** OptionGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

#### OptionGroup DELETE

**Endpoint:** `DELETE /admin-api/option_groups/{id}`

**Açıklama:** OptionGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [OptionGroup](#schema-optiongroup)

---

### Order

#### Order LIST

**Endpoint:** `GET /admin-api/orders`

**Açıklama:** Order cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| status | query |  | string | Order status filtresi.<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3` |
| paymentStatus | query |  | string | Order payment status filtresi.<br>İzin verilen değerler: `success`, `in_transaction`, `failed` |
| paymentTypeName | query |  | string | Order payment type name filtresi.<br>İzin verilen değerler: `Havale`, `Özel Ödeme Sistemi`, `Kredi Kartı`, `Paypal`, `GarantiPay`, `Mail Order`, `BKM Express`, `Kapıda Ödeme Nakit`, `Kapıda Ödeme Kredi Kartı`, `İş Bankası Alternatif Ödeme`, `Stripe`, `Iyzico ile Öde`, `Alışveriş Kredisi`, `FastPass`, `Hepsipay ile Öde` |
| shippingProviderCode | query |  | string | Order shipping provider code filtresi. |
| shippingCompany | query |  | string | Order shipping company code filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| filterCurrency | query |  | integer | Currency filtresi. |
| minPrice | query |  | string | Order min price arama filtresi. |
| maxPrice | query |  | string | Order max price arama filtresi. |
| member | query |  | integer | Member filtresi. |
| memberGroup | query |  | integer | Member group filtresi. |
| billingFullname | query |  | string | Order billing fullname filtresi. |
| billingLocation | query |  | string | Order location filtresi. |
| customerFullname | query |  | string | Order customer fullname filtresi. |
| productName | query |  | string | Order product name filtresi. |
| productId | query |  | string | Order product id filtresi. |
| productSku | query |  | string | Order product sku filtresi. |
| shippingMobilePhoneNumber | query |  | string | Order mobile phone number filtresi. |
| referrer | query |  | string | Order referrer filtresi. |
| deviceType | query |  | string | Device type filtresi.<br>İzin verilen değerler: `desktop`, `mobile` |
| paidFromCurrentAccount | query |  | string | Paid from current account filtresi.<br>İzin verilen değerler: `0`, `1` |
| cardSavingSystem | query |  | string | Card saving system filtresi.<br>İzin verilen değerler: `Masterpass` |
| startShippingDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endShippingDate | query |  | string (date) | Zaman aralığı bitişi |
| cargoTrackingCodeNonExisting | query |  | string | Cargo Tracking Code Non Existing filtresi.<br>İzin verilen değerler: `yurtici`, `mng`, `jetizz`, `aras` |
| couponCode | query |  | string | Coupon code filtresi. |
| couponUsage | query |  | string | Coupon code usage filter. |
| gatewayCode | query |  | string | Gateway Code filtresi.<br>İzin verilen değerler: `anadolubank`, `axess`, `bonus_card`, `cardfinans`, `denizbank_bonus`, `halkbank_paraf`, `hsbc_advantage_kart`, `ing_bank`, `kuveyt_turk_kredi_karti`, `maximum_kart`, `param_card`, `t_finans_kredi_karti`, `teb`, `vakifbank_worldcard`, `world_card`, `ziraat_maximum` |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Order COUNT

**Endpoint:** `GET /admin-api/orders/count`

**Açıklama:** Order cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Orders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| status | query |  | string | Order status filtresi.<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3` |
| paymentStatus | query |  | string | Order payment status filtresi.<br>İzin verilen değerler: `success`, `in_transaction`, `failed` |
| paymentTypeName | query |  | string | Order payment type name filtresi.<br>İzin verilen değerler: `Havale`, `Özel Ödeme Sistemi`, `Kredi Kartı`, `Paypal`, `GarantiPay`, `Mail Order`, `BKM Express`, `Kapıda Ödeme Nakit`, `Kapıda Ödeme Kredi Kartı`, `İş Bankası Alternatif Ödeme`, `Stripe`, `Iyzico ile Öde`, `Alışveriş Kredisi`, `FastPass`, `Hepsipay ile Öde` |
| shippingProviderCode | query |  | string | Order shipping provider code filtresi. |
| shippingCompany | query |  | string | Order shipping company code filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| filterCurrency | query |  | integer | Currency filtresi. |
| minPrice | query |  | string | Order min price arama filtresi. |
| maxPrice | query |  | string | Order max price arama filtresi. |
| member | query |  | integer | Member filtresi. |
| memberGroup | query |  | integer | Member group filtresi. |
| billingFullname | query |  | string | Order billing fullname filtresi. |
| billingLocation | query |  | string | Order location filtresi. |
| customerFullname | query |  | string | Order customer fullname filtresi. |
| productName | query |  | string | Order product name filtresi. |
| productId | query |  | string | Order product id filtresi. |
| productSku | query |  | string | Order product sku filtresi. |
| shippingMobilePhoneNumber | query |  | string | Order mobile phone number filtresi. |
| referrer | query |  | string | Order referrer filtresi. |
| deviceType | query |  | string | Device type filtresi.<br>İzin verilen değerler: `desktop`, `mobile` |
| paidFromCurrentAccount | query |  | string | Paid from current account filtresi.<br>İzin verilen değerler: `0`, `1` |
| cardSavingSystem | query |  | string | Card saving system filtresi.<br>İzin verilen değerler: `Masterpass` |
| startShippingDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endShippingDate | query |  | string (date) | Zaman aralığı bitişi |
| cargoTrackingCodeNonExisting | query |  | string | Cargo Tracking Code Non Existing filtresi.<br>İzin verilen değerler: `yurtici`, `mng`, `jetizz`, `aras` |
| couponCode | query |  | string | Coupon code filtresi. |
| couponUsage | query |  | string | Coupon code usage filter. |
| gatewayCode | query |  | string | Gateway Code filtresi.<br>İzin verilen değerler: `anadolubank`, `axess`, `bonus_card`, `cardfinans`, `denizbank_bonus`, `halkbank_paraf`, `hsbc_advantage_kart`, `ing_bank`, `kuveyt_turk_kredi_karti`, `maximum_kart`, `param_card`, `t_finans_kredi_karti`, `teb`, `vakifbank_worldcard`, `world_card`, `ziraat_maximum` |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Order GET

**Endpoint:** `GET /admin-api/orders/{id}`

**Açıklama:** Order getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Order PUT

**Endpoint:** `PUT /admin-api/orders/{id}`

**Açıklama:** Order putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Order DELETE

**Endpoint:** `DELETE /admin-api/orders/{id}`

**Açıklama:** Order deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

### OrderCustomTaxLine

#### OrderCustomTaxLine LIST

**Endpoint:** `GET /admin-api/order_custom_tax_lines`

**Açıklama:** OrderCustomTaxLine cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderCustomTaxLines adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | OrderCustomTaxLines arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderCustomTaxLine](#schema-ordercustomtaxline)

---

#### OrderCustomTaxLine GET

**Endpoint:** `GET /admin-api/order_custom_tax_lines/{id}`

**Açıklama:** OrderCustomTaxLine getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderCustomTaxLine](#schema-ordercustomtaxline)

---

### OrderDetail

#### OrderDetail LIST

**Endpoint:** `GET /admin-api/order_details`

**Açıklama:** OrderDetail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderDetail adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | OrderDetail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderDetail](#schema-orderdetail)

---

#### OrderDetail COUNT

**Endpoint:** `GET /admin-api/order_details/count`

**Açıklama:** OrderDetail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderDetail adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | OrderDetail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderDetail](#schema-orderdetail)

---

#### OrderDetail GET

**Endpoint:** `GET /admin-api/order_details/{id}`

**Açıklama:** OrderDetail getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderDetail](#schema-orderdetail)

---

### OrderItem

#### OrderItem LIST

**Endpoint:** `GET /admin-api/order_items`

**Açıklama:** OrderItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderItem adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | OrderItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderItem](#schema-orderitem)

---

#### OrderItem COUNT

**Endpoint:** `GET /admin-api/order_items/count`

**Açıklama:** OrderItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderItem adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | OrderItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderItem](#schema-orderitem)

---

#### OrderItem GET

**Endpoint:** `GET /admin-api/order_items/{id}`

**Açıklama:** OrderItem getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderItem](#schema-orderitem)

---

### OrderRefundRequest

#### OrderRefundRequest LIST

**Endpoint:** `GET /admin-api/order_refund_requests`

**Açıklama:** OrderRefundRequest cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Order Refund Request adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order Refund Request arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| status | query |  | string | Status  alanının alabilceği değerler:  approved veya waiting_for_approval veya cancelled<br>İzin verilen değerler: `approved`, `waiting_for_approval`, `cancelled` |
| member | query |  | integer | Member Id |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

#### OrderRefundRequest POST

**Endpoint:** `POST /admin-api/order_refund_requests`

**Açıklama:** OrderRefundRequest postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

#### OrderRefundRequest COUNT

**Endpoint:** `GET /admin-api/order_refund_requests/count`

**Açıklama:** OrderRefundRequest cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Order Refund Request adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order Refund Request arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| status | query |  | string | Status  alanının alabilceği değerler:  approved veya waiting_for_approval veya cancelled<br>İzin verilen değerler: `approved`, `waiting_for_approval`, `cancelled` |
| member | query |  | integer | Member Id |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

#### OrderRefundRequest GET

**Endpoint:** `GET /admin-api/order_refund_requests/{id}`

**Açıklama:** OrderRefundRequest getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

#### OrderRefundRequest PUT

**Endpoint:** `PUT /admin-api/order_refund_requests/{id}`

**Açıklama:** OrderRefundRequest putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

#### OrderRefundRequest DELETE

**Endpoint:** `DELETE /admin-api/order_refund_requests/{id}`

**Açıklama:** OrderRefundRequest deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderRefundRequest](#schema-orderrefundrequest)

---

### OrderUserNote

#### OrderUserNote LIST

**Endpoint:** `GET /admin-api/order_user_notes`

**Açıklama:** OrderUserNote cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderUserNotes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order User Note arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| user | query |  | string | Order Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

#### OrderUserNote POST

**Endpoint:** `POST /admin-api/order_user_notes`

**Açıklama:** OrderUserNote postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

#### OrderUserNote COUNT

**Endpoint:** `GET /admin-api/order_user_notes/count`

**Açıklama:** OrderUserNote cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek OrderUserNotes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Order User Note arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| user | query |  | string | Order Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

#### OrderUserNote GET

**Endpoint:** `GET /admin-api/order_user_notes/{id}`

**Açıklama:** OrderUserNote getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

#### OrderUserNote PUT

**Endpoint:** `PUT /admin-api/order_user_notes/{id}`

**Açıklama:** OrderUserNote putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

#### OrderUserNote DELETE

**Endpoint:** `DELETE /admin-api/order_user_notes/{id}`

**Açıklama:** OrderUserNote deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderUserNote](#schema-orderusernote)

---

### Package

#### Package LIST

**Endpoint:** `GET /admin-api/packages`

**Açıklama:** Package cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Package adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Package arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

#### Package POST

**Endpoint:** `POST /admin-api/packages`

**Açıklama:** Package postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

#### Package COUNT

**Endpoint:** `GET /admin-api/packages/count`

**Açıklama:** Package cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Package adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Package arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

#### Package GET

**Endpoint:** `GET /admin-api/packages/{id}`

**Açıklama:** Package getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

#### Package PUT

**Endpoint:** `PUT /admin-api/packages/{id}`

**Açıklama:** Package putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

#### Package DELETE

**Endpoint:** `DELETE /admin-api/packages/{id}`

**Açıklama:** Package deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Package](#schema-package)

---

### PackageItem

#### PackageItem LIST

**Endpoint:** `GET /admin-api/package_items`

**Açıklama:** PackageItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PackageItem adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| package | query |  | integer | Package arama filtresi. |
| q | query |  | string | PackageItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

#### PackageItem POST

**Endpoint:** `POST /admin-api/package_items`

**Açıklama:** PackageItem postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

#### PackageItem COUNT

**Endpoint:** `GET /admin-api/package_items/count`

**Açıklama:** PackageItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PackageItem adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| package | query |  | integer | Package arama filtresi. |
| q | query |  | string | PackageItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

#### PackageItem GET

**Endpoint:** `GET /admin-api/package_items/{id}`

**Açıklama:** PackageItem getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

#### PackageItem PUT

**Endpoint:** `PUT /admin-api/package_items/{id}`

**Açıklama:** PackageItem putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

#### PackageItem DELETE

**Endpoint:** `DELETE /admin-api/package_items/{id}`

**Açıklama:** PackageItem deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItem](#schema-packageitem)

---

### PackageItemProduct

#### PackageItemProduct LIST

**Endpoint:** `GET /admin-api/package_item_to_products`

**Açıklama:** PackageItemProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PackageItemToProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| package | query |  | integer | Package arama filtresi. |
| packageItem | query |  | integer | Package arama filtresi. |
| product | query |  | integer | Product arama filtresi. |
| q | query |  | string | PackageItemToProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

#### PackageItemProduct POST

**Endpoint:** `POST /admin-api/package_item_to_products`

**Açıklama:** PackageItemProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

#### PackageItemProduct COUNT

**Endpoint:** `GET /admin-api/package_item_to_products/count`

**Açıklama:** PackageItemProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PackageItemToProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| package | query |  | integer | Package arama filtresi. |
| packageItem | query |  | integer | Package arama filtresi. |
| product | query |  | integer | Product arama filtresi. |
| q | query |  | string | PackageItemToProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

#### PackageItemProduct GET

**Endpoint:** `GET /admin-api/package_item_to_products/{id}`

**Açıklama:** PackageItemProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

#### PackageItemProduct PUT

**Endpoint:** `PUT /admin-api/package_item_to_products/{id}`

**Açıklama:** PackageItemProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

#### PackageItemProduct DELETE

**Endpoint:** `DELETE /admin-api/package_item_to_products/{id}`

**Açıklama:** PackageItemProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PackageItemProduct](#schema-packageitemproduct)

---

### Page

#### Page LIST

**Endpoint:** `GET /admin-api/pages`

**Açıklama:** Page cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| type | query |  | string | Page type.<br>İzin verilen değerler: `page`, `article` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Page arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

#### Page POST

**Endpoint:** `POST /admin-api/pages`

**Açıklama:** Page postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

#### Page COUNT

**Endpoint:** `GET /admin-api/pages/count`

**Açıklama:** Page cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Pages adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| type | query |  | string | Page type.<br>İzin verilen değerler: `page`, `article` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Page arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

#### Page GET

**Endpoint:** `GET /admin-api/pages/{id}`

**Açıklama:** Page getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

#### Page PUT

**Endpoint:** `PUT /admin-api/pages/{id}`

**Açıklama:** Page putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

#### Page DELETE

**Endpoint:** `DELETE /admin-api/pages/{id}`

**Açıklama:** Page deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Page](#schema-page)

---

### Partnership

#### Partnership LIST

**Endpoint:** `GET /admin-api/partnerships`

**Açıklama:** Partnership cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Bir sayfada gelecek Partnerships per partnership |
| page | query |  | integer | Hangi sayfadan başlanacağı |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Partnership](#schema-partnership)

---

#### Partnership POST

**Endpoint:** `POST /admin-api/partnerships`

**Açıklama:** Partnership postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Partnership](#schema-partnership)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Partnership](#schema-partnership)

---

#### Partnership GET

**Endpoint:** `GET /admin-api/partnerships/{id}`

**Açıklama:** Partnership getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Partnership](#schema-partnership)

---

### PartnershipUrl

#### PartnershipUrl GET

**Endpoint:** `GET /admin-api/partnership_url`

**Açıklama:** PartnershipUrl getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PartnershipUrl](#schema-partnershipurl)

---

### Payment

#### Payment LIST

**Endpoint:** `GET /admin-api/payments`

**Açıklama:** Payment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Payments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| transactionId | query |  | string | Transaction id. |
| memberFullName | query |  | string | Member full name. |
| memberGroup | query |  | integer | Member Group id |
| status | query |  | string | Status  alanının alabilceği değerler:  waiting_for_approval, approved, fulfilled, cancelled, delivered, on_accumulation, waiting_for_payment, being_prepared, refunded, personal_status_1, personal_status_2, personal_status_3, deleted, failed, veya in_transaction<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3`, `deleted`, `failed`, `in_transaction` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| member | query |  | integer | Member Id |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| deviceType | query |  | string | Device type filtresi.<br>İzin verilen değerler: `mobile`, `desktop` |
| gatewayCode | query |  | string | Gateway Code filtresi.<br>İzin verilen değerler: `anadolubank`, `axess`, `bonus_card`, `cardfinans`, `denizbank_bonus`, `halkbank_paraf`, `hsbc_advantage_kart`, `ing_bank`, `kuveyt_turk_kredi_karti`, `maximum_kart`, `param_card`, `t_finans_kredi_karti`, `teb`, `vakifbank_worldcard`, `world_card`, `ziraat_maximum` |
| filterCurrency | query |  | string | Currency filtresi.<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8` |
| minPrice | query |  | string | MinPrice arama filtresi. |
| maxPrice | query |  | string | MaxPrice arama filtresi. |
| q | query |  | string | Payment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Payment COUNT

**Endpoint:** `GET /admin-api/payments/count`

**Açıklama:** Payment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Payments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| transactionId | query |  | string | Transaction id. |
| memberFullName | query |  | string | Member full name. |
| memberGroup | query |  | integer | Member Group id |
| status | query |  | string | Status  alanının alabilceği değerler:  waiting_for_approval, approved, fulfilled, cancelled, delivered, on_accumulation, waiting_for_payment, being_prepared, refunded, personal_status_1, personal_status_2, personal_status_3, deleted, failed, veya in_transaction<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3`, `deleted`, `failed`, `in_transaction` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| member | query |  | integer | Member Id |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| deviceType | query |  | string | Device type filtresi.<br>İzin verilen değerler: `mobile`, `desktop` |
| gatewayCode | query |  | string | Gateway Code filtresi.<br>İzin verilen değerler: `anadolubank`, `axess`, `bonus_card`, `cardfinans`, `denizbank_bonus`, `halkbank_paraf`, `hsbc_advantage_kart`, `ing_bank`, `kuveyt_turk_kredi_karti`, `maximum_kart`, `param_card`, `t_finans_kredi_karti`, `teb`, `vakifbank_worldcard`, `world_card`, `ziraat_maximum` |
| filterCurrency | query |  | string | Currency filtresi.<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8` |
| minPrice | query |  | string | MinPrice arama filtresi. |
| maxPrice | query |  | string | MaxPrice arama filtresi. |
| q | query |  | string | Payment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Payment GET

**Endpoint:** `GET /admin-api/payments/{id}`

**Açıklama:** Payment getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Payment PUT

**Endpoint:** `PUT /admin-api/payments/{id}`

**Açıklama:** Payment putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Payment DELETE

**Endpoint:** `DELETE /admin-api/payments/{id}`

**Açıklama:** Payment deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

### PaymentGateway

#### PaymentGateway LIST

**Endpoint:** `GET /admin-api/payment_gateways`

**Açıklama:** PaymentGateway cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentGateways adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentProvider | query |  | integer | Payment Provider Id |
| paymentProviderCode | query |  | string | Payment Provider Code |
| q | query |  | string | PaymentGateway arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

#### PaymentGateway POST

**Endpoint:** `POST /admin-api/payment_gateways`

**Açıklama:** PaymentGateway postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

#### PaymentGateway COUNT

**Endpoint:** `GET /admin-api/payment_gateways/count`

**Açıklama:** PaymentGateway cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentGateways adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentProvider | query |  | integer | Payment Provider Id |
| paymentProviderCode | query |  | string | Payment Provider Code |
| q | query |  | string | PaymentGateway arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

#### PaymentGateway GET

**Endpoint:** `GET /admin-api/payment_gateways/{id}`

**Açıklama:** PaymentGateway getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

#### PaymentGateway PUT

**Endpoint:** `PUT /admin-api/payment_gateways/{id}`

**Açıklama:** PaymentGateway putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

#### PaymentGateway DELETE

**Endpoint:** `DELETE /admin-api/payment_gateways/{id}`

**Açıklama:** PaymentGateway deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGateway](#schema-paymentgateway)

---

### PaymentGatewaySetting

#### PaymentGatewaySetting LIST

**Endpoint:** `GET /admin-api/payment_gateway_settings`

**Açıklama:** PaymentGatewaySetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentGatewaySettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentGateway | query |  | integer | Payment Provider Id |
| paymentGatewayCode | query |  | string | Payment Gateway code. |
| q | query |  | string | PaymentGatewaySetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

#### PaymentGatewaySetting POST

**Endpoint:** `POST /admin-api/payment_gateway_settings`

**Açıklama:** PaymentGatewaySetting postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

#### PaymentGatewaySetting COUNT

**Endpoint:** `GET /admin-api/payment_gateway_settings/count`

**Açıklama:** PaymentGatewaySetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentGatewaySettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentGateway | query |  | integer | Payment Provider Id |
| paymentGatewayCode | query |  | string | Payment Gateway code. |
| q | query |  | string | PaymentGatewaySetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

#### PaymentGatewaySetting GET

**Endpoint:** `GET /admin-api/payment_gateway_settings/{id}`

**Açıklama:** PaymentGatewaySetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

#### PaymentGatewaySetting PUT

**Endpoint:** `PUT /admin-api/payment_gateway_settings/{id}`

**Açıklama:** PaymentGatewaySetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

#### PaymentGatewaySetting DELETE

**Endpoint:** `DELETE /admin-api/payment_gateway_settings/{id}`

**Açıklama:** PaymentGatewaySetting deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentGatewaySetting](#schema-paymentgatewaysetting)

---

### PaymentProvider

#### PaymentProvider LIST

**Endpoint:** `GET /admin-api/payment_providers`

**Açıklama:** PaymentProvider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProviders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentType | query |  | integer | Payment Type Id |
| paymentTypeName | query |  | string | Payment Type name. |
| q | query |  | string | PaymentProvider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProvider](#schema-paymentprovider)

---

#### PaymentProvider COUNT

**Endpoint:** `GET /admin-api/payment_providers/count`

**Açıklama:** PaymentProvider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProviders adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| paymentType | query |  | integer | Payment Type Id |
| paymentTypeName | query |  | string | Payment Type name. |
| q | query |  | string | PaymentProvider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProvider](#schema-paymentprovider)

---

#### PaymentProvider GET

**Endpoint:** `GET /admin-api/payment_providers/{id}`

**Açıklama:** PaymentProvider getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProvider](#schema-paymentprovider)

---

#### PaymentProvider PUT

**Endpoint:** `PUT /admin-api/payment_providers/{id}`

**Açıklama:** PaymentProvider putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProvider](#schema-paymentprovider)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProvider](#schema-paymentprovider)

---

### PaymentProviderSetting

#### PaymentProviderSetting LIST

**Endpoint:** `GET /admin-api/payment_provider_settings`

**Açıklama:** PaymentProviderSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProviderSettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentProvider | query |  | integer | Payment Provider Id |
| paymentProviderCode | query |  | string | Payment Provider code. |
| q | query |  | string | PaymentProviderSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProviderSetting](#schema-paymentprovidersetting)

---

#### PaymentProviderSetting COUNT

**Endpoint:** `GET /admin-api/payment_provider_settings/count`

**Açıklama:** PaymentProviderSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProviderSettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentProvider | query |  | integer | Payment Provider Id |
| paymentProviderCode | query |  | string | Payment Provider code. |
| q | query |  | string | PaymentProviderSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProviderSetting](#schema-paymentprovidersetting)

---

#### PaymentProviderSetting GET

**Endpoint:** `GET /admin-api/payment_provider_settings/{id}`

**Açıklama:** PaymentProviderSetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProviderSetting](#schema-paymentprovidersetting)

---

#### PaymentProviderSetting PUT

**Endpoint:** `PUT /admin-api/payment_provider_settings/{id}`

**Açıklama:** PaymentProviderSetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProviderSetting](#schema-paymentprovidersetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProviderSetting](#schema-paymentprovidersetting)

---

### PaymentProxy

#### PaymentProxy LIST

**Endpoint:** `GET /admin-api/payment_proxies`

**Açıklama:** PaymentProxy cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProxies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PaymentProxy arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxy](#schema-paymentproxy)

---

#### PaymentProxy COUNT

**Endpoint:** `GET /admin-api/payment_proxies/count`

**Açıklama:** PaymentProxy cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProxies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PaymentProxy arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxy](#schema-paymentproxy)

---

#### PaymentProxy GET

**Endpoint:** `GET /admin-api/payment_proxies/{id}`

**Açıklama:** PaymentProxy getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxy](#schema-paymentproxy)

---

#### PaymentProxy PUT

**Endpoint:** `PUT /admin-api/payment_proxies/{id}`

**Açıklama:** PaymentProxy putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxy](#schema-paymentproxy)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxy](#schema-paymentproxy)

---

### PaymentProxySetting

#### PaymentProxySetting LIST

**Endpoint:** `GET /admin-api/payment_proxy_settings`

**Açıklama:** PaymentProxySetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProxySettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentProxy | query |  | integer | Payment Proxy Id |
| paymentProxyCode | query |  | string | Payment Proxy code. |
| q | query |  | string | PaymentProxySetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxySetting](#schema-paymentproxysetting)

---

#### PaymentProxySetting COUNT

**Endpoint:** `GET /admin-api/payment_proxy_settings/count`

**Açıklama:** PaymentProxySetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentProxySettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| paymentProxy | query |  | integer | Payment Proxy Id |
| paymentProxyCode | query |  | string | Payment Proxy code. |
| q | query |  | string | PaymentProxySetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxySetting](#schema-paymentproxysetting)

---

#### PaymentProxySetting GET

**Endpoint:** `GET /admin-api/payment_proxy_settings/{id}`

**Açıklama:** PaymentProxySetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxySetting](#schema-paymentproxysetting)

---

#### PaymentProxySetting PUT

**Endpoint:** `PUT /admin-api/payment_proxy_settings/{id}`

**Açıklama:** PaymentProxySetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxySetting](#schema-paymentproxysetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentProxySetting](#schema-paymentproxysetting)

---

### PaymentType

#### PaymentType LIST

**Endpoint:** `GET /admin-api/payment_types`

**Açıklama:** PaymentType cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentTypes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PaymentType arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentType](#schema-paymenttype)

---

#### PaymentType COUNT

**Endpoint:** `GET /admin-api/payment_types/count`

**Açıklama:** PaymentType cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PaymentTypes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PaymentType arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentType](#schema-paymenttype)

---

#### PaymentType GET

**Endpoint:** `GET /admin-api/payment_types/{id}`

**Açıklama:** PaymentType getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentType](#schema-paymenttype)

---

#### PaymentType PUT

**Endpoint:** `PUT /admin-api/payment_types/{id}`

**Açıklama:** PaymentType putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentType](#schema-paymenttype)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PaymentType](#schema-paymenttype)

---

### PixelSettingPref

#### PixelSettingPref GET

**Endpoint:** `GET /admin-api/pixel_setting_pref`

**Açıklama:** PixelSettingPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PixelSettingPref](#schema-pixelsettingpref)

---

#### PixelSettingPref PUT

**Endpoint:** `PUT /admin-api/pixel_setting_pref`

**Açıklama:** PixelSettingPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PixelSettingPref](#schema-pixelsettingpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PixelSettingPref](#schema-pixelsettingpref)

---

### PointLog

#### PointLog LIST

**Endpoint:** `GET /admin-api/point_logs`

**Açıklama:** PointLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Point log adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| event | query |  | string | Event name<br>İzin verilen değerler: `advice`, `comment`, `shopping`, `shoppingcancel`, `signup`, `vote`, `token_production`, `payment`, `paymentcancel`, `invitedshopping`, `invitedshoppingcancel`, `admincancel` |
| memberEmail | query |  | string | Member email. |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointLog](#schema-pointlog)

---

#### PointLog COUNT

**Endpoint:** `GET /admin-api/point_logs/count`

**Açıklama:** PointLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Point log adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| event | query |  | string | Event name<br>İzin verilen değerler: `advice`, `comment`, `shopping`, `shoppingcancel`, `signup`, `vote`, `token_production`, `payment`, `paymentcancel`, `invitedshopping`, `invitedshoppingcancel`, `admincancel` |
| memberEmail | query |  | string | Member email. |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointLog](#schema-pointlog)

---

#### PointLog GET

**Endpoint:** `GET /admin-api/point_logs/{id}`

**Açıklama:** PointLog getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointLog](#schema-pointlog)

---

### PointPref

#### PointPref GET

**Endpoint:** `GET /admin-api/point_pref`

**Açıklama:** PointPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointPref](#schema-pointpref)

---

#### PointPref PUT

**Endpoint:** `PUT /admin-api/point_pref`

**Açıklama:** PointPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointPref](#schema-pointpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PointPref](#schema-pointpref)

---

### Poll

#### Poll LIST

**Endpoint:** `GET /admin-api/polls`

**Açıklama:** Poll cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Polls adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Poll arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

#### Poll POST

**Endpoint:** `POST /admin-api/polls`

**Açıklama:** Poll postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

#### Poll COUNT

**Endpoint:** `GET /admin-api/polls/count`

**Açıklama:** Poll cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Polls adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Poll arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

#### Poll GET

**Endpoint:** `GET /admin-api/polls/{id}`

**Açıklama:** Poll getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

#### Poll PUT

**Endpoint:** `PUT /admin-api/polls/{id}`

**Açıklama:** Poll putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

#### Poll DELETE

**Endpoint:** `DELETE /admin-api/polls/{id}`

**Açıklama:** Poll deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Poll](#schema-poll)

---

### Popup

#### Popup LIST

**Endpoint:** `GET /admin-api/popups`

**Açıklama:** Popup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Popups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| q | query |  | string | Popup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

#### Popup POST

**Endpoint:** `POST /admin-api/popups`

**Açıklama:** Popup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

#### Popup COUNT

**Endpoint:** `GET /admin-api/popups/count`

**Açıklama:** Popup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Popups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| q | query |  | string | Popup arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

#### Popup GET

**Endpoint:** `GET /admin-api/popups/{id}`

**Açıklama:** Popup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

#### Popup PUT

**Endpoint:** `PUT /admin-api/popups/{id}`

**Açıklama:** Popup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

#### Popup DELETE

**Endpoint:** `DELETE /admin-api/popups/{id}`

**Açıklama:** Popup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Popup](#schema-popup)

---

### PosCampaign

#### PosCampaign LIST

**Endpoint:** `GET /admin-api/pos_campaigns`

**Açıklama:** PosCampaign cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaign adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PosCampaign arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| label | query |  | string | PosCampaign Name. |
| posAccount | query |  | string | PosCampaign PosAccount. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

#### PosCampaign POST

**Endpoint:** `POST /admin-api/pos_campaigns`

**Açıklama:** PosCampaign postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

#### PosCampaign COUNT

**Endpoint:** `GET /admin-api/pos_campaigns/count`

**Açıklama:** PosCampaign cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaign adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PosCampaign arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| label | query |  | string | PosCampaign Name. |
| posAccount | query |  | string | PosCampaign PosAccount. |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

#### PosCampaign GET

**Endpoint:** `GET /admin-api/pos_campaigns/{id}`

**Açıklama:** PosCampaign getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

#### PosCampaign PUT

**Endpoint:** `PUT /admin-api/pos_campaigns/{id}`

**Açıklama:** PosCampaign putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

#### PosCampaign DELETE

**Endpoint:** `DELETE /admin-api/pos_campaigns/{id}`

**Açıklama:** PosCampaign deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaign](#schema-poscampaign)

---

### PosCampaignCategory

#### PosCampaignCategory LIST

**Endpoint:** `GET /admin-api/pos_campaign_to_categories`

**Açıklama:** PosCampaignCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaignCategory adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | PosCampaignCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| posCampaign | query |  | integer | Pos Campaign Id |
| category | query |  | integer | Category Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

#### PosCampaignCategory POST

**Endpoint:** `POST /admin-api/pos_campaign_to_categories`

**Açıklama:** PosCampaignCategory postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

#### PosCampaignCategory COUNT

**Endpoint:** `GET /admin-api/pos_campaign_to_categories/count`

**Açıklama:** PosCampaignCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaignCategory adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | PosCampaignCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| posCampaign | query |  | integer | Pos Campaign Id |
| category | query |  | integer | Category Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

#### PosCampaignCategory GET

**Endpoint:** `GET /admin-api/pos_campaign_to_categories/{id}`

**Açıklama:** PosCampaignCategory getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

#### PosCampaignCategory PUT

**Endpoint:** `PUT /admin-api/pos_campaign_to_categories/{id}`

**Açıklama:** PosCampaignCategory putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

#### PosCampaignCategory DELETE

**Endpoint:** `DELETE /admin-api/pos_campaign_to_categories/{id}`

**Açıklama:** PosCampaignCategory deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignCategory](#schema-poscampaigncategory)

---

### PosCampaignProduct

#### PosCampaignProduct LIST

**Endpoint:** `GET /admin-api/pos_campaign_to_products`

**Açıklama:** PosCampaignProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaignProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | PosCampaignProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| posCampaign | query |  | integer | Pos Campaign Id |
| product | query |  | integer | Product Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

#### PosCampaignProduct POST

**Endpoint:** `POST /admin-api/pos_campaign_to_products`

**Açıklama:** PosCampaignProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

#### PosCampaignProduct COUNT

**Endpoint:** `GET /admin-api/pos_campaign_to_products/count`

**Açıklama:** PosCampaignProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek PosCampaignProduct adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| q | query |  | string | PosCampaignProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| posCampaign | query |  | integer | Pos Campaign Id |
| product | query |  | integer | Product Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

#### PosCampaignProduct GET

**Endpoint:** `GET /admin-api/pos_campaign_to_products/{id}`

**Açıklama:** PosCampaignProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

#### PosCampaignProduct PUT

**Endpoint:** `PUT /admin-api/pos_campaign_to_products/{id}`

**Açıklama:** PosCampaignProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

#### PosCampaignProduct DELETE

**Endpoint:** `DELETE /admin-api/pos_campaign_to_products/{id}`

**Açıklama:** PosCampaignProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PosCampaignProduct](#schema-poscampaignproduct)

---

### PreOrderInfo

#### PreOrderInfo LIST

**Endpoint:** `GET /admin-api/pre_order_infos`

**Açıklama:** PreOrderInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blog adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Pre Order Info arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| shippingCountry | query |  | integer | Shipping Country Id |
| billingCountry | query |  | integer | Billing Country Id |
| shippingLocation | query |  | integer | Shipping Location Id |
| billingLocation | query |  | integer | Billing Location Id |
| shippingCompany | query |  | integer | Shipping Company Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PreOrderInfo](#schema-preorderinfo)

---

#### PreOrderInfo COUNT

**Endpoint:** `GET /admin-api/pre_order_infos/count`

**Açıklama:** PreOrderInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Blog adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Pre Order Info arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| shippingCountry | query |  | integer | Shipping Country Id |
| billingCountry | query |  | integer | Billing Country Id |
| shippingLocation | query |  | integer | Shipping Location Id |
| billingLocation | query |  | integer | Billing Location Id |
| shippingCompany | query |  | integer | Shipping Company Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PreOrderInfo](#schema-preorderinfo)

---

#### PreOrderInfo GET

**Endpoint:** `GET /admin-api/pre_order_infos/{id}`

**Açıklama:** PreOrderInfo getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PreOrderInfo](#schema-preorderinfo)

---

### Preference

#### Preference LIST

**Endpoint:** `GET /admin-api/preferences`

**Açıklama:** Preference cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Preference adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| q | query |  | string | Preference arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| varKeys | query |  | string | Preference varKeys filtresi. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Preference](#schema-preference)

---

#### Preference COUNT

**Endpoint:** `GET /admin-api/preferences/count`

**Açıklama:** Preference cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Preference adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| q | query |  | string | Preference arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| varKeys | query |  | string | Preference varKeys filtresi. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Preference](#schema-preference)

---

#### Preference GET

**Endpoint:** `GET /admin-api/preferences/{id}`

**Açıklama:** Preference getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Preference](#schema-preference)

---

#### Preference PUT

**Endpoint:** `PUT /admin-api/preferences/{id}`

**Açıklama:** Preference putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Preference](#schema-preference)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Preference](#schema-preference)

---

### PriceGap

#### PriceGap LIST

**Endpoint:** `GET /admin-api/price_gaps`

**Açıklama:** PriceGap cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Price Gap adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PriceGap arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

#### PriceGap POST

**Endpoint:** `POST /admin-api/price_gaps`

**Açıklama:** PriceGap postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

#### PriceGap COUNT

**Endpoint:** `GET /admin-api/price_gaps/count`

**Açıklama:** PriceGap cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Price Gap adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PriceGap arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

#### PriceGap GET

**Endpoint:** `GET /admin-api/price_gaps/{id}`

**Açıklama:** PriceGap getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

#### PriceGap PUT

**Endpoint:** `PUT /admin-api/price_gaps/{id}`

**Açıklama:** PriceGap putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

#### PriceGap DELETE

**Endpoint:** `DELETE /admin-api/price_gaps/{id}`

**Açıklama:** PriceGap deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceGap](#schema-pricegap)

---

### PriceRule

#### PriceRule LIST

**Endpoint:** `GET /admin-api/price_rules`

**Açıklama:** PriceRule cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested PriceRule per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | PriceRule search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

#### PriceRule POST

**Endpoint:** `POST /admin-api/price_rules`

**Açıklama:** PriceRule postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

#### PriceRule COUNT

**Endpoint:** `GET /admin-api/price_rules/count`

**Açıklama:** PriceRule cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested PriceRule per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | PriceRule search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

#### PriceRule GET

**Endpoint:** `GET /admin-api/price_rules/{id}`

**Açıklama:** PriceRule getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

#### PriceRule PUT

**Endpoint:** `PUT /admin-api/price_rules/{id}`

**Açıklama:** PriceRule putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

#### PriceRule DELETE

**Endpoint:** `DELETE /admin-api/price_rules/{id}`

**Açıklama:** PriceRule deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PriceRule](#schema-pricerule)

---

### ProcessLog

#### ProcessLog LIST

**Endpoint:** `GET /admin-api/process_logs`

**Açıklama:** ProcessLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Process Log adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| recordId | query |  | string | RecordId arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| username | query |  | string | Processlog username arama alanı |
| moduleNameVerbose | query |  | string | Processlog username arama alanı |
| q | query |  | string | Process log arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProcessLog](#schema-processlog)

---

#### ProcessLog COUNT

**Endpoint:** `GET /admin-api/process_logs/count`

**Açıklama:** ProcessLog cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Process Log adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| recordId | query |  | string | RecordId arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| username | query |  | string | Processlog username arama alanı |
| moduleNameVerbose | query |  | string | Processlog username arama alanı |
| q | query |  | string | Process log arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProcessLog](#schema-processlog)

---

#### ProcessLog GET

**Endpoint:** `GET /admin-api/process_logs/{id}`

**Açıklama:** ProcessLog getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProcessLog](#schema-processlog)

---

### Product

#### Product LIST

**Endpoint:** `GET /admin-api/products`

**Açıklama:** Product cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Sonuçları değere göre al product id |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| brand | query |  | integer | Brand Id |
| category | query |  | integer | Product category arama filtresi. |
| categoryIds | query |  | string | Çoklu listeleme için virgülle ayrılmış değerler category ids |
| midblock | query |  | integer | Product midblock arama filtresi. |
| selfDistributor | query |  | integer | Product self distributor arama filtresi. |
| distributor | query |  | string | Search key filter. |
| specialty | query |  | string | Product specialty arama filtresi. |
| hasOption | query |  | string | Product hasOption search filter. |
| status | query |  | string | Product status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| specValue | query |  | integer | Product spec value arama filtresi. |
| specName | query |  | integer | Product spec name arama filtresi. |
| specGroup | query |  | integer | Product spec group arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date-time) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| startCountDownDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endCountDownDate | query |  | string (date) | Zaman aralığı bitişi |
| filterCurrency | query |  | integer | Currency filtresi. |
| buttonType | query |  | string | Currency filtresi.<br>İzin verilen değerler: `fastShipping`, `sameDayShipping`, `threeDaysDelivery`, `fiveDaysDelivery`, `sevenDaysDelivery`, `freeShipping`, `deliveryFromStock`, `preOrderedProduct`, `limitedStock`, `askStock`, `campaignedProduct` |
| minPrice | query |  | string | Product min price arama filtresi. |
| maxPrice | query |  | string | Product max price arama filtresi. |
| criticalStock | query |  | string | Product critical stock amount arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| stockAmount | query |  | integer | Product stock amount arama filtresi. |
| stockExpr | query |  | string | Product stock expr arama filtresi.<br>İzin verilen değerler: `eq`, `gte`, `lte` |
| currency | query |  | string | Product currency abbr filter. |
| currencyExpr | query |  | string | Product currency abbr condition filter.<br>İzin verilen değerler: `eq`, `neq` |
| q | query |  | string | Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product POST

**Endpoint:** `POST /admin-api/products`

**Açıklama:** Product postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product COUNT

**Endpoint:** `GET /admin-api/products/count`

**Açıklama:** Product cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Sonuçları değere göre al product id |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| brand | query |  | integer | Brand Id |
| category | query |  | integer | Product category arama filtresi. |
| categoryIds | query |  | string | Çoklu listeleme için virgülle ayrılmış değerler category ids |
| midblock | query |  | integer | Product midblock arama filtresi. |
| selfDistributor | query |  | integer | Product self distributor arama filtresi. |
| distributor | query |  | string | Search key filter. |
| specialty | query |  | string | Product specialty arama filtresi. |
| hasOption | query |  | string | Product hasOption search filter. |
| status | query |  | string | Product status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| specValue | query |  | integer | Product spec value arama filtresi. |
| specName | query |  | integer | Product spec name arama filtresi. |
| specGroup | query |  | integer | Product spec group arama filtresi. |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date-time) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| startCountDownDate | query |  | string (date) | Zaman aralığı başlangıcı |
| endCountDownDate | query |  | string (date) | Zaman aralığı bitişi |
| filterCurrency | query |  | integer | Currency filtresi. |
| buttonType | query |  | string | Currency filtresi.<br>İzin verilen değerler: `fastShipping`, `sameDayShipping`, `threeDaysDelivery`, `fiveDaysDelivery`, `sevenDaysDelivery`, `freeShipping`, `deliveryFromStock`, `preOrderedProduct`, `limitedStock`, `askStock`, `campaignedProduct` |
| minPrice | query |  | string | Product min price arama filtresi. |
| maxPrice | query |  | string | Product max price arama filtresi. |
| criticalStock | query |  | string | Product critical stock amount arama filtresi.<br>İzin verilen değerler: `0`, `1` |
| stockAmount | query |  | integer | Product stock amount arama filtresi. |
| stockExpr | query |  | string | Product stock expr arama filtresi.<br>İzin verilen değerler: `eq`, `gte`, `lte` |
| currency | query |  | string | Product currency abbr filter. |
| currencyExpr | query |  | string | Product currency abbr condition filter.<br>İzin verilen değerler: `eq`, `neq` |
| q | query |  | string | Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product GET

**Endpoint:** `GET /admin-api/products/{id}`

**Açıklama:** Product getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product PUT

**Endpoint:** `PUT /admin-api/products/{id}`

**Açıklama:** Product putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product DELETE

**Endpoint:** `DELETE /admin-api/products/{id}`

**Açıklama:** Product deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Product](#schema-product)

---

#### Product ChangeCategoryAction PUT

**Endpoint:** `PUT /admin-api/products/{id}/change_category`

**Açıklama:** Product changeCategoryAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Product ShowcaseSortOrderUpdateAction PUT

**Endpoint:** `PUT /admin-api/products/showcase_sort_order_update`

**Açıklama:** Product showcaseSortOrderUpdateAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Product GetUsedIntegrationDistributors GET

**Endpoint:** `GET /admin-api/products/integration_distributors`

**Açıklama:** Product getUsedIntegrationDistributors

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### ProductButton

#### ProductButton LIST

**Endpoint:** `GET /admin-api/product_buttons`

**Açıklama:** ProductButton cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Buttons adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductButton arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

#### ProductButton POST

**Endpoint:** `POST /admin-api/product_buttons`

**Açıklama:** ProductButton postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

#### ProductButton COUNT

**Endpoint:** `GET /admin-api/product_buttons/count`

**Açıklama:** ProductButton cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Buttons adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductButton arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

#### ProductButton GET

**Endpoint:** `GET /admin-api/product_buttons/{id}`

**Açıklama:** ProductButton getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

#### ProductButton PUT

**Endpoint:** `PUT /admin-api/product_buttons/{id}`

**Açıklama:** ProductButton putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

#### ProductButton DELETE

**Endpoint:** `DELETE /admin-api/product_buttons/{id}`

**Açıklama:** ProductButton deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductButton](#schema-productbutton)

---

### ProductCategory

#### ProductCategory LIST

**Endpoint:** `GET /admin-api/product_to_categories`

**Açıklama:** ProductCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Categories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| productIds | query |  | string | Çoklu listeleme için virgülle ayrılmış değerler product ids |
| category | query |  | integer | Category Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

#### ProductCategory POST

**Endpoint:** `POST /admin-api/product_to_categories`

**Açıklama:** ProductCategory postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

#### ProductCategory COUNT

**Endpoint:** `GET /admin-api/product_to_categories/count`

**Açıklama:** ProductCategory cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Categories adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| productIds | query |  | string | Çoklu listeleme için virgülle ayrılmış değerler product ids |
| category | query |  | integer | Category Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductCategory arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

#### ProductCategory GET

**Endpoint:** `GET /admin-api/product_to_categories/{id}`

**Açıklama:** ProductCategory getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

#### ProductCategory PUT

**Endpoint:** `PUT /admin-api/product_to_categories/{id}`

**Açıklama:** ProductCategory putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

#### ProductCategory DELETE

**Endpoint:** `DELETE /admin-api/product_to_categories/{id}`

**Açıklama:** ProductCategory deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCategory](#schema-productcategory)

---

### ProductComment

#### ProductComment LIST

**Endpoint:** `GET /admin-api/product_comments`

**Açıklama:** ProductComment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Comments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Product Comment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)

---

#### ProductComment COUNT

**Endpoint:** `GET /admin-api/product_comments/count`

**Açıklama:** ProductComment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Comments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Product Comment arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)

---

#### ProductComment GET

**Endpoint:** `GET /admin-api/product_comments/{id}`

**Açıklama:** ProductComment getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)

---

#### ProductComment PUT

**Endpoint:** `PUT /admin-api/product_comments/{id}`

**Açıklama:** ProductComment putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)

---

#### ProductComment DELETE

**Endpoint:** `DELETE /admin-api/product_comments/{id}`

**Açıklama:** ProductComment deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductComment](#schema-productcomment)

---

### ProductCountDown

#### ProductCountDown LIST

**Endpoint:** `GET /admin-api/product_to_count_downs`

**Açıklama:** ProductCountDown cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Count Downs adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductCountDown arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

#### ProductCountDown POST

**Endpoint:** `POST /admin-api/product_to_count_downs`

**Açıklama:** ProductCountDown postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

#### ProductCountDown COUNT

**Endpoint:** `GET /admin-api/product_to_count_downs/count`

**Açıklama:** ProductCountDown cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Count Downs adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductCountDown arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

#### ProductCountDown GET

**Endpoint:** `GET /admin-api/product_to_count_downs/{id}`

**Açıklama:** ProductCountDown getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

#### ProductCountDown PUT

**Endpoint:** `PUT /admin-api/product_to_count_downs/{id}`

**Açıklama:** ProductCountDown putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

#### ProductCountDown DELETE

**Endpoint:** `DELETE /admin-api/product_to_count_downs/{id}`

**Açıklama:** ProductCountDown deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCountDown](#schema-productcountdown)

---

### ProductCustomizationGroup

#### ProductCustomizationGroup LIST

**Endpoint:** `GET /admin-api/product_customization_groups`

**Açıklama:** ProductCustomizationGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Customization Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Product Customization Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

#### ProductCustomizationGroup POST

**Endpoint:** `POST /admin-api/product_customization_groups`

**Açıklama:** ProductCustomizationGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

#### ProductCustomizationGroup COUNT

**Endpoint:** `GET /admin-api/product_customization_groups/count`

**Açıklama:** ProductCustomizationGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Customization Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| startUpdatedAt | query |  | string (date) | updatedAt değeri için başlangıç tarihi |
| endUpdatedAt | query |  | string (date) | updatedAt değeri için bitiş tarihi |
| q | query |  | string | Product Customization Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

#### ProductCustomizationGroup GET

**Endpoint:** `GET /admin-api/product_customization_groups/{id}`

**Açıklama:** ProductCustomizationGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

#### ProductCustomizationGroup PUT

**Endpoint:** `PUT /admin-api/product_customization_groups/{id}`

**Açıklama:** ProductCustomizationGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

#### ProductCustomizationGroup DELETE

**Endpoint:** `DELETE /admin-api/product_customization_groups/{id}`

**Açıklama:** ProductCustomizationGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductCustomizationGroup](#schema-productcustomizationgroup)

---

### ProductDetail

#### ProductDetail LIST

**Endpoint:** `GET /admin-api/product_details`

**Açıklama:** ProductDetail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Details adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductDetail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

#### ProductDetail POST

**Endpoint:** `POST /admin-api/product_details`

**Açıklama:** ProductDetail postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

#### ProductDetail COUNT

**Endpoint:** `GET /admin-api/product_details/count`

**Açıklama:** ProductDetail cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Details adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductDetail arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

#### ProductDetail GET

**Endpoint:** `GET /admin-api/product_details/{id}`

**Açıklama:** ProductDetail getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

#### ProductDetail PUT

**Endpoint:** `PUT /admin-api/product_details/{id}`

**Açıklama:** ProductDetail putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

#### ProductDetail DELETE

**Endpoint:** `DELETE /admin-api/product_details/{id}`

**Açıklama:** ProductDetail deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductDetail](#schema-productdetail)

---

### ProductExtraField

#### ProductExtraField LIST

**Endpoint:** `GET /admin-api/product_extra_fields`

**Açıklama:** ProductExtraField cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Product Extra Fields per page |
| page | query |  | integer | Which page to start from |
| product | query |  | integer | Product Id |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | ProductExtraField search filter. Usage: q[<valid-query-param>] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

#### ProductExtraField POST

**Endpoint:** `POST /admin-api/product_extra_fields`

**Açıklama:** ProductExtraField postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

#### ProductExtraField COUNT

**Endpoint:** `GET /admin-api/product_extra_fields/count`

**Açıklama:** ProductExtraField cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Product Extra Fields per page |
| page | query |  | integer | Which page to start from |
| product | query |  | integer | Product Id |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | ProductExtraField search filter. Usage: q[<valid-query-param>] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

#### ProductExtraField GET

**Endpoint:** `GET /admin-api/product_extra_fields/{id}`

**Açıklama:** ProductExtraField getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

#### ProductExtraField PUT

**Endpoint:** `PUT /admin-api/product_extra_fields/{id}`

**Açıklama:** ProductExtraField putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

#### ProductExtraField DELETE

**Endpoint:** `DELETE /admin-api/product_extra_fields/{id}`

**Açıklama:** ProductExtraField deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraField](#schema-productextrafield)

---

### ProductExtraInfo

#### ProductExtraInfo LIST

**Endpoint:** `GET /admin-api/extra_info_to_products`

**Açıklama:** ProductExtraInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Special Infos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductExtraInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

#### ProductExtraInfo POST

**Endpoint:** `POST /admin-api/extra_info_to_products`

**Açıklama:** ProductExtraInfo postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

#### ProductExtraInfo COUNT

**Endpoint:** `GET /admin-api/extra_info_to_products/count`

**Açıklama:** ProductExtraInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Special Infos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductExtraInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

#### ProductExtraInfo GET

**Endpoint:** `GET /admin-api/extra_info_to_products/{id}`

**Açıklama:** ProductExtraInfo getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

#### ProductExtraInfo PUT

**Endpoint:** `PUT /admin-api/extra_info_to_products/{id}`

**Açıklama:** ProductExtraInfo putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

#### ProductExtraInfo DELETE

**Endpoint:** `DELETE /admin-api/extra_info_to_products/{id}`

**Açıklama:** ProductExtraInfo deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductExtraInfo](#schema-productextrainfo)

---

### ProductFeed

#### ProductFeed LIST

**Endpoint:** `GET /admin-api/product_feeds`

**Açıklama:** ProductFeed cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Feeds adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Product Feed arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductFeed](#schema-productfeed)

---

#### ProductFeed COUNT

**Endpoint:** `GET /admin-api/product_feeds/count`

**Açıklama:** ProductFeed cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Feeds adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Product Feed arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductFeed](#schema-productfeed)

---

#### ProductFeed GET

**Endpoint:** `GET /admin-api/product_feeds/{id}`

**Açıklama:** ProductFeed getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductFeed](#schema-productfeed)

---

### ProductImage

#### ProductImage LIST

**Endpoint:** `GET /admin-api/product_images`

**Açıklama:** ProductImage cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Images adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| q | query |  | string | ProductImage arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)

---

#### ProductImage POST

**Endpoint:** `POST /admin-api/product_images`

**Açıklama:** ProductImage postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)

---

#### ProductImage COUNT

**Endpoint:** `GET /admin-api/product_images/count`

**Açıklama:** ProductImage cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Images adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| q | query |  | string | ProductImage arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)

---

#### ProductImage GET

**Endpoint:** `GET /admin-api/product_images/{id}`

**Açıklama:** ProductImage getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)

---

#### ProductImage DELETE

**Endpoint:** `DELETE /admin-api/product_images/{id}`

**Açıklama:** ProductImage deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductImage](#schema-productimage)

---

### ProductLabel

#### ProductLabel LIST

**Endpoint:** `GET /admin-api/label_to_products`

**Açıklama:** ProductLabel cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Label Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| label | query |  | integer | Label Id |
| q | query |  | string | Label Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

#### ProductLabel POST

**Endpoint:** `POST /admin-api/label_to_products`

**Açıklama:** ProductLabel postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

#### ProductLabel COUNT

**Endpoint:** `GET /admin-api/label_to_products/count`

**Açıklama:** ProductLabel cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Label Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| product | query |  | integer | Product Id |
| label | query |  | integer | Label Id |
| q | query |  | string | Label Product arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

#### ProductLabel GET

**Endpoint:** `GET /admin-api/label_to_products/{id}`

**Açıklama:** ProductLabel getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

#### ProductLabel PUT

**Endpoint:** `PUT /admin-api/label_to_products/{id}`

**Açıklama:** ProductLabel putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

#### ProductLabel DELETE

**Endpoint:** `DELETE /admin-api/label_to_products/{id}`

**Açıklama:** ProductLabel deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductLabel](#schema-productlabel)

---

### ProductPrice

#### ProductPrice LIST

**Endpoint:** `GET /admin-api/product_prices`

**Açıklama:** ProductPrice cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Prices adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductPrice arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

#### ProductPrice POST

**Endpoint:** `POST /admin-api/product_prices`

**Açıklama:** ProductPrice postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

#### ProductPrice COUNT

**Endpoint:** `GET /admin-api/product_prices/count`

**Açıklama:** ProductPrice cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Prices adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductPrice arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

#### ProductPrice GET

**Endpoint:** `GET /admin-api/product_prices/{id}`

**Açıklama:** ProductPrice getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

#### ProductPrice PUT

**Endpoint:** `PUT /admin-api/product_prices/{id}`

**Açıklama:** ProductPrice putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

#### ProductPrice DELETE

**Endpoint:** `DELETE /admin-api/product_prices/{id}`

**Açıklama:** ProductPrice deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPrice](#schema-productprice)

---

### ProductPriceWarning

#### ProductPriceWarning LIST

**Endpoint:** `GET /admin-api/product_price_warnings`

**Açıklama:** ProductPriceWarning cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product PriceWarnings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductPriceWarning arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPriceWarning](#schema-productpricewarning)

---

#### ProductPriceWarning COUNT

**Endpoint:** `GET /admin-api/product_price_warnings/count`

**Açıklama:** ProductPriceWarning cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product PriceWarnings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductPriceWarning arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPriceWarning](#schema-productpricewarning)

---

#### ProductPriceWarning DELETE

**Endpoint:** `DELETE /admin-api/product_price_warnings/{id}`

**Açıklama:** ProductPriceWarning deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductPriceWarning](#schema-productpricewarning)

---

### ProductProtection

#### ProductProtection LIST

**Endpoint:** `GET /admin-api/product_protections`

**Açıklama:** ProductProtection cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Protections adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductProtection arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

#### ProductProtection POST

**Endpoint:** `POST /admin-api/product_protections`

**Açıklama:** ProductProtection postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

#### ProductProtection COUNT

**Endpoint:** `GET /admin-api/product_protections/count`

**Açıklama:** ProductProtection cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Protections adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductProtection arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

#### ProductProtection GET

**Endpoint:** `GET /admin-api/product_protections/{id}`

**Açıklama:** ProductProtection getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

#### ProductProtection PUT

**Endpoint:** `PUT /admin-api/product_protections/{id}`

**Açıklama:** ProductProtection putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

#### ProductProtection DELETE

**Endpoint:** `DELETE /admin-api/product_protections/{id}`

**Açıklama:** ProductProtection deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductProtection](#schema-productprotection)

---

### ProductSpecialInfo

#### ProductSpecialInfo LIST

**Endpoint:** `GET /admin-api/product_special_infos`

**Açıklama:** ProductSpecialInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Special Infos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductSpecialInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

#### ProductSpecialInfo POST

**Endpoint:** `POST /admin-api/product_special_infos`

**Açıklama:** ProductSpecialInfo postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

#### ProductSpecialInfo COUNT

**Endpoint:** `GET /admin-api/product_special_infos/count`

**Açıklama:** ProductSpecialInfo cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Special Infos adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ProductSpecialInfo arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

#### ProductSpecialInfo GET

**Endpoint:** `GET /admin-api/product_special_infos/{id}`

**Açıklama:** ProductSpecialInfo getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

#### ProductSpecialInfo PUT

**Endpoint:** `PUT /admin-api/product_special_infos/{id}`

**Açıklama:** ProductSpecialInfo putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

#### ProductSpecialInfo DELETE

**Endpoint:** `DELETE /admin-api/product_special_infos/{id}`

**Açıklama:** ProductSpecialInfo deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductSpecialInfo](#schema-productspecialinfo)

---

### ProductTag

#### ProductTag LIST

**Endpoint:** `GET /admin-api/product_to_tags`

**Açıklama:** ProductTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Tags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| tag | query |  | integer | Tag Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

#### ProductTag POST

**Endpoint:** `POST /admin-api/product_to_tags`

**Açıklama:** ProductTag postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

#### ProductTag COUNT

**Endpoint:** `GET /admin-api/product_to_tags/count`

**Açıklama:** ProductTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Product Tags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| tag | query |  | integer | Tag Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

#### ProductTag GET

**Endpoint:** `GET /admin-api/product_to_tags/{id}`

**Açıklama:** ProductTag getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

#### ProductTag PUT

**Endpoint:** `PUT /admin-api/product_to_tags/{id}`

**Açıklama:** ProductTag putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

#### ProductTag DELETE

**Endpoint:** `DELETE /admin-api/product_to_tags/{id}`

**Açıklama:** ProductTag deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductTag](#schema-producttag)

---

### Promotion

#### Promotion LIST

**Endpoint:** `GET /admin-api/promotions`

**Açıklama:** Promotion cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Promotion adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| type | query |  | string | Promotion type<br>İzin verilen değerler: `cart`, `product`, `category_and_brand` |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| q | query |  | string | Promotion arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| specialty | query |  | string | Specialty List<br>İzin verilen değerler: `campaign` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion POST

**Endpoint:** `POST /admin-api/promotions`

**Açıklama:** Promotion postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion COUNT

**Endpoint:** `GET /admin-api/promotions/count`

**Açıklama:** Promotion cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Promotion adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| startDate | query |  | string (date) | Zaman aralığı başlangıcı |
| type | query |  | string | Promotion type<br>İzin verilen değerler: `cart`, `product`, `category_and_brand` |
| endDate | query |  | string (date) | Zaman aralığı bitişi |
| q | query |  | string | Promotion arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| specialty | query |  | string | Specialty List<br>İzin verilen değerler: `campaign` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion GET

**Endpoint:** `GET /admin-api/promotions/{id}`

**Açıklama:** Promotion getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion PUT

**Endpoint:** `PUT /admin-api/promotions/{id}`

**Açıklama:** Promotion putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion DELETE

**Endpoint:** `DELETE /admin-api/promotions/{id}`

**Açıklama:** Promotion deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion EligibleAction COUNT

**Endpoint:** `GET /admin-api/promotions/eligible`

**Açıklama:** Promotion eligibleAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| cart | query |  | integer | Cart ID |
| product | query |  | integer | Product ID |
| category | query |  | integer | Category ID |
| brand | query |  | integer | Brand ID |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion ApplyAction PUT

**Endpoint:** `PUT /admin-api/promotions/apply/{id}`

**Açıklama:** Promotion applyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion UnapplyAction PUT

**Endpoint:** `PUT /admin-api/promotions/unapply/{id}`

**Açıklama:** Promotion unapplyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Promotion](#schema-promotion)

---

#### Promotion ShowcaseSortOrderUpdateAction PUT

**Endpoint:** `PUT /admin-api/promotions/showcase_sort_order_update`

**Açıklama:** Promotion showcaseSortOrderUpdateAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Promotion BulkUpdateAction PUT

**Endpoint:** `PUT /admin-api/promotions/bulk_update`

**Açıklama:** Promotion bulkUpdateAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### PromotionBar

#### PromotionBar LIST

**Endpoint:** `GET /admin-api/promotion_bars`

**Açıklama:** PromotionBar cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek promotion bars adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| q | query |  | string | Bar arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

#### PromotionBar POST

**Endpoint:** `POST /admin-api/promotion_bars`

**Açıklama:** PromotionBar postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

#### PromotionBar COUNT

**Endpoint:** `GET /admin-api/promotion_bars/count`

**Açıklama:** PromotionBar cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek promotion bars adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | string | Tekli listeleme için id değeri. |
| q | query |  | string | Bar arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

#### PromotionBar GET

**Endpoint:** `GET /admin-api/promotion_bars/{id}`

**Açıklama:** PromotionBar getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

#### PromotionBar PUT

**Endpoint:** `PUT /admin-api/promotion_bars/{id}`

**Açıklama:** PromotionBar putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

#### PromotionBar DELETE

**Endpoint:** `DELETE /admin-api/promotion_bars/{id}`

**Açıklama:** PromotionBar deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PromotionBar](#schema-promotionbar)

---

### PurchaseLimitation

#### PurchaseLimitation LIST

**Endpoint:** `GET /admin-api/purchase_limitations`

**Açıklama:** PurchaseLimitation cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Purchase Limitation adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PurchaseLimitation arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

#### PurchaseLimitation POST

**Endpoint:** `POST /admin-api/purchase_limitations`

**Açıklama:** PurchaseLimitation postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

#### PurchaseLimitation COUNT

**Endpoint:** `GET /admin-api/purchase_limitations/count`

**Açıklama:** PurchaseLimitation cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Purchase Limitation adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PurchaseLimitation arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

#### PurchaseLimitation GET

**Endpoint:** `GET /admin-api/purchase_limitations/{id}`

**Açıklama:** PurchaseLimitation getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

#### PurchaseLimitation PUT

**Endpoint:** `PUT /admin-api/purchase_limitations/{id}`

**Açıklama:** PurchaseLimitation putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

#### PurchaseLimitation DELETE

**Endpoint:** `DELETE /admin-api/purchase_limitations/{id}`

**Açıklama:** PurchaseLimitation deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitation](#schema-purchaselimitation)

---

### PurchaseLimitationItem

#### PurchaseLimitationItem LIST

**Endpoint:** `GET /admin-api/purchase_limitation_items`

**Açıklama:** PurchaseLimitationItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Purchase Limitation Item adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PurchaseLimitationItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

#### PurchaseLimitationItem POST

**Endpoint:** `POST /admin-api/purchase_limitation_items`

**Açıklama:** PurchaseLimitationItem postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

#### PurchaseLimitationItem COUNT

**Endpoint:** `GET /admin-api/purchase_limitation_items/count`

**Açıklama:** PurchaseLimitationItem cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Purchase Limitation Item adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | PurchaseLimitationItem arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

#### PurchaseLimitationItem GET

**Endpoint:** `GET /admin-api/purchase_limitation_items/{id}`

**Açıklama:** PurchaseLimitationItem getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

#### PurchaseLimitationItem PUT

**Endpoint:** `PUT /admin-api/purchase_limitation_items/{id}`

**Açıklama:** PurchaseLimitationItem putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

#### PurchaseLimitationItem DELETE

**Endpoint:** `DELETE /admin-api/purchase_limitation_items/{id}`

**Açıklama:** PurchaseLimitationItem deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [PurchaseLimitationItem](#schema-purchaselimitationitem)

---

### Question

#### Question LIST

**Endpoint:** `GET /admin-api/questions`

**Açıklama:** Question cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Questions per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | Questions search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
| product | query |  | integer | Product Id |
| member | query |  | string | Member Id |
| status | query |  | string | Country status search filter.<br>İzin verilen değerler: `0`, `1` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

#### Question POST

**Endpoint:** `POST /admin-api/questions`

**Açıklama:** Question postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

#### Question COUNT

**Endpoint:** `GET /admin-api/questions/count`

**Açıklama:** Question cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Example sort=id |
| limit | query |  | integer | Number of requested Questions per page |
| page | query |  | integer | Which page to start from |
| id | query |  | integer | Get result by id |
| ids | query |  | string | Get multiple result by ids |
| sinceId | query |  | integer | Restrict results to after the specified id |
| q | query |  | string | Questions search filter. Usage: q[<valid-query-param>] |
| s | query |  | string | Search key filter. |
| product | query |  | integer | Product Id |
| member | query |  | string | Member Id |
| status | query |  | string | Country status search filter.<br>İzin verilen değerler: `0`, `1` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

#### Question GET

**Endpoint:** `GET /admin-api/questions/{id}`

**Açıklama:** Question getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

#### Question PUT

**Endpoint:** `PUT /admin-api/questions/{id}`

**Açıklama:** Question putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

#### Question DELETE

**Endpoint:** `DELETE /admin-api/questions/{id}`

**Açıklama:** Question deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Question](#schema-question)

---

### QueueProcess

#### QueueProcess LIST

**Endpoint:** `GET /admin-api/queue_processes`

**Açıklama:** QueueProcess cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Queue Process adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| status | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `cancelled`, `started`, `created`, `failed`, `in_queue`, `completed` |
| type | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `export`, `sitemap`, `product_bulk_update`, `order_status_bulk_update`, `report`, `kuveyt_turk_shopping_loan_category_export` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| q | query |  | string | Queue Process arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QueueProcess](#schema-queueprocess)

---

#### QueueProcess COUNT

**Endpoint:** `GET /admin-api/queue_processes/count`

**Açıklama:** QueueProcess cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Queue Process adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| status | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `cancelled`, `started`, `created`, `failed`, `in_queue`, `completed` |
| type | query |  | string | Visitor type arama filtresi.<br>İzin verilen değerler: `export`, `sitemap`, `product_bulk_update`, `order_status_bulk_update`, `report`, `kuveyt_turk_shopping_loan_category_export` |
| startCreatedAt | query |  | string (date) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date) | createdAt değeri için bitiş tarihi |
| q | query |  | string | Queue Process arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QueueProcess](#schema-queueprocess)

---

### QuickCart

#### QuickCart LIST

**Endpoint:** `GET /admin-api/quick_carts`

**Açıklama:** QuickCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Quick Cart adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Quick Cart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

#### QuickCart POST

**Endpoint:** `POST /admin-api/quick_carts`

**Açıklama:** QuickCart postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

#### QuickCart COUNT

**Endpoint:** `GET /admin-api/quick_carts/count`

**Açıklama:** QuickCart cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Quick Cart adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Quick Cart arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

#### QuickCart GET

**Endpoint:** `GET /admin-api/quick_carts/{id}`

**Açıklama:** QuickCart getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

#### QuickCart PUT

**Endpoint:** `PUT /admin-api/quick_carts/{id}`

**Açıklama:** QuickCart putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

#### QuickCart DELETE

**Endpoint:** `DELETE /admin-api/quick_carts/{id}`

**Açıklama:** QuickCart deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [QuickCart](#schema-quickcart)

---

### Region

#### Region LIST

**Endpoint:** `GET /admin-api/regions`

**Açıklama:** Region cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Regions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Region arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| countries | query |  | string | Search by countries. Country ids must be comma separated |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

#### Region POST

**Endpoint:** `POST /admin-api/regions`

**Açıklama:** Region postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

#### Region COUNT

**Endpoint:** `GET /admin-api/regions/count`

**Açıklama:** Region cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Regions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Region arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| countries | query |  | string | Search by countries. Country ids must be comma separated |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

#### Region GET

**Endpoint:** `GET /admin-api/regions/{id}`

**Açıklama:** Region getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

#### Region PUT

**Endpoint:** `PUT /admin-api/regions/{id}`

**Açıklama:** Region putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

#### Region DELETE

**Endpoint:** `DELETE /admin-api/regions/{id}`

**Açıklama:** Region deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Region](#schema-region)

---

### Report

#### Report ProductReportAction GET

**Endpoint:** `GET /admin-api/report/product`

**Açıklama:** Report productReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
| category | query |  | integer | Category Id. |
| brand | query |  | integer | Brand Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report ProductSaleReportAction GET

**Endpoint:** `GET /admin-api/report/product_sale`

**Açıklama:** Report productSaleReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
| category | query |  | integer | Category Id. |
| brand | query |  | integer | Brand Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report ProductCostAnalysisReportAction GET

**Endpoint:** `GET /admin-api/report/product_cost_analysis`

**Açıklama:** Report productCostAnalysisReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
| category | query |  | integer | Category Id. |
| brand | query |  | integer | Brand Id |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report MemberReportAction GET

**Endpoint:** `GET /admin-api/report/member`

**Açıklama:** Report memberReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | query |  | integer | Tekli listeleme için id değeri. |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report MemberBasedOrderReportAction GET

**Endpoint:** `GET /admin-api/report/member_based_order`

**Açıklama:** Report memberBasedOrderReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | query |  | integer | Tekli listeleme için id değeri. |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report MemberBasedPaymentReportAction GET

**Endpoint:** `GET /admin-api/report/member_based_payment`

**Açıklama:** Report memberBasedPaymentReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | query |  | integer | Tekli listeleme için id değeri. |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report MemberBasedProductReportAction GET

**Endpoint:** `GET /admin-api/report/member_based_product/{id}`

**Açıklama:** Report memberBasedProductReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report OrderReportAction GET

**Endpoint:** `GET /admin-api/report/order`

**Açıklama:** Report orderReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| status | query |  | string | Order status filtresi.<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3` |
| paymentType | query |  | integer | Payment Type Id |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report PaymentReportAction GET

**Endpoint:** `GET /admin-api/report/payment`

**Açıklama:** Report paymentReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| status | query |  | string | Status  alanının alabilceği değerler:  waiting_for_approval, approved, fulfilled, cancelled, delivered, on_accumulation, waiting_for_payment, being_prepared, refunded, personal_status_1, personal_status_2, personal_status_3, deleted, failed, veya in_transaction<br>İzin verilen değerler: `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3`, `deleted`, `failed`, `in_transaction` |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report PriceListReportAction GET

**Endpoint:** `GET /admin-api/report/price_list`

**Açıklama:** Report priceListReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| category | query |  | integer | Category Id. |
| brand | query |  | integer | Brand Id. |
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
| priceType | query |  | string | Price Type.<br>İzin verilen değerler: `price1`, `price2`, `price3`, `price4`, `price5`, `buyingPrice` |
| currency | query |  | integer | Convert currency |
| displayNoStock | query |  | string | Order status arama filtresi.<br>İzin verilen değerler: `0`, `1` |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report MaillistReportAction GET

**Endpoint:** `GET /admin-api/report/maillist`

**Açıklama:** Report maillistReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report StockWarningReportAction GET

**Endpoint:** `GET /admin-api/report/stock_warning`

**Açıklama:** Report stockWarningReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Report NoStockProductReportAction GET

**Endpoint:** `GET /admin-api/report/no_stock_product`

**Açıklama:** Report noStockProductReportAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startCreatedAt | query |  | string (date-time) | createdAt değeri için başlangıç tarihi |
| endCreatedAt | query |  | string (date-time) | createdAt değeri için bitiş tarihi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### ScriptTag

#### ScriptTag LIST

**Endpoint:** `GET /admin-api/script_tags`

**Açıklama:** ScriptTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ScriptTags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ScriptTag arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

#### ScriptTag POST

**Endpoint:** `POST /admin-api/script_tags`

**Açıklama:** ScriptTag postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

#### ScriptTag COUNT

**Endpoint:** `GET /admin-api/script_tags/count`

**Açıklama:** ScriptTag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ScriptTags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ScriptTag arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

#### ScriptTag GET

**Endpoint:** `GET /admin-api/script_tags/{id}`

**Açıklama:** ScriptTag getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

#### ScriptTag PUT

**Endpoint:** `PUT /admin-api/script_tags/{id}`

**Açıklama:** ScriptTag putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

#### ScriptTag DELETE

**Endpoint:** `DELETE /admin-api/script_tags/{id}`

**Açıklama:** ScriptTag deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ScriptTag](#schema-scripttag)

---

### SearchEnginePref

#### SearchEnginePref LIST

**Endpoint:** `GET /admin-api/search_engine_pref`

**Açıklama:** SearchEnginePref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SearchEnginePref](#schema-searchenginepref)

---

#### SearchEnginePref PUT

**Endpoint:** `PUT /admin-api/search_engine_pref`

**Açıklama:** SearchEnginePref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SearchEnginePref](#schema-searchenginepref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SearchEnginePref](#schema-searchenginepref)

---

### Selection

#### Selection LIST

**Endpoint:** `GET /admin-api/selections`

**Açıklama:** Selection cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Selections adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Selection arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| selectionGroup | query |  | integer | Selection Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

#### Selection POST

**Endpoint:** `POST /admin-api/selections`

**Açıklama:** Selection postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

#### Selection COUNT

**Endpoint:** `GET /admin-api/selections/count`

**Açıklama:** Selection cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Selections adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Selection arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| selectionGroup | query |  | integer | Selection Group Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

#### Selection GET

**Endpoint:** `GET /admin-api/selections/{id}`

**Açıklama:** Selection getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

#### Selection PUT

**Endpoint:** `PUT /admin-api/selections/{id}`

**Açıklama:** Selection putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

#### Selection DELETE

**Endpoint:** `DELETE /admin-api/selections/{id}`

**Açıklama:** Selection deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Selection](#schema-selection)

---

### SelectionGroup

#### SelectionGroup LIST

**Endpoint:** `GET /admin-api/selection_groups`

**Açıklama:** SelectionGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Selection Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Selection Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

#### SelectionGroup POST

**Endpoint:** `POST /admin-api/selection_groups`

**Açıklama:** SelectionGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

#### SelectionGroup COUNT

**Endpoint:** `GET /admin-api/selection_groups/count`

**Açıklama:** SelectionGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Selection Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Selection Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

#### SelectionGroup GET

**Endpoint:** `GET /admin-api/selection_groups/{id}`

**Açıklama:** SelectionGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

#### SelectionGroup PUT

**Endpoint:** `PUT /admin-api/selection_groups/{id}`

**Açıklama:** SelectionGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

#### SelectionGroup DELETE

**Endpoint:** `DELETE /admin-api/selection_groups/{id}`

**Açıklama:** SelectionGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SelectionGroup](#schema-selectiongroup)

---

### SeoPref

#### SeoPref LIST

**Endpoint:** `GET /admin-api/seo_pref`

**Açıklama:** SeoPref cgetAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoPref](#schema-seopref)

---

#### SeoPref PUT

**Endpoint:** `PUT /admin-api/seo_pref`

**Açıklama:** SeoPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoPref](#schema-seopref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoPref](#schema-seopref)

---

### SeoSetting

#### SeoSetting LIST

**Endpoint:** `GET /admin-api/seo_settings`

**Açıklama:** SeoSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek MemberAddress adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| context | query |  | string | Sonuçları değere göre al context |
| contextItemId | query |  | integer | Sonuçları değere göre al contextItemId |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

#### SeoSetting POST

**Endpoint:** `POST /admin-api/seo_settings`

**Açıklama:** SeoSetting postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

#### SeoSetting COUNT

**Endpoint:** `GET /admin-api/seo_settings/count`

**Açıklama:** SeoSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek MemberAddress adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| context | query |  | string | Sonuçları değere göre al context |
| contextItemId | query |  | integer | Sonuçları değere göre al contextItemId |
| q | query |  | string | Member arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

#### SeoSetting GET

**Endpoint:** `GET /admin-api/seo_settings/{id}`

**Açıklama:** SeoSetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

#### SeoSetting PUT

**Endpoint:** `PUT /admin-api/seo_settings/{id}`

**Açıklama:** SeoSetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

#### SeoSetting DELETE

**Endpoint:** `DELETE /admin-api/seo_settings/{id}`

**Açıklama:** SeoSetting deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SeoSetting](#schema-seosetting)

---

### Shipment

#### Shipment LIST

**Endpoint:** `GET /admin-api/shipments`

**Açıklama:** Shipment cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipment Preferences adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| order | query |  | integer | Order Id |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipment Preferences arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Shipment](#schema-shipment)

---

#### Shipment GET

**Endpoint:** `GET /admin-api/shipments/{id}`

**Açıklama:** Shipment getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Shipment](#schema-shipment)

---

#### Shipment CreateAction PUT

**Endpoint:** `PUT /admin-api/shipments/create/{type}`

**Açıklama:** Shipment createAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Shipment GenerateTrackingCodeAction PUT

**Endpoint:** `PUT /admin-api/shipments/generate-tracking-code/{type}`

**Açıklama:** Shipment generateTrackingCodeAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Shipment CancelAction PUT

**Endpoint:** `PUT /admin-api/shipments/cancel/{type}`

**Açıklama:** Shipment cancelAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| type | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

#### Shipment PrintShippingAction GET

**Endpoint:** `GET /admin-api/shipments/print_shipping/{id}`

**Açıklama:** Shipment printShippingAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### ShipmentPref

#### ShipmentPref LIST

**Endpoint:** `GET /admin-api/shipment_pref`

**Açıklama:** ShipmentPref cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipment Preferences adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipment Preferences arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)

---

#### ShipmentPref POST

**Endpoint:** `POST /admin-api/shipment_pref`

**Açıklama:** ShipmentPref postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)

---

#### ShipmentPref GET

**Endpoint:** `GET /admin-api/shipment_pref/{id}`

**Açıklama:** ShipmentPref getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)

---

#### ShipmentPref PUT

**Endpoint:** `PUT /admin-api/shipment_pref/{id}`

**Açıklama:** ShipmentPref putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)

---

#### ShipmentPref DELETE

**Endpoint:** `DELETE /admin-api/shipment_pref/{id}`

**Açıklama:** ShipmentPref deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShipmentPref](#schema-shipmentpref)

---

### ShippingAddress

#### ShippingAddress LIST

**Endpoint:** `GET /admin-api/shipping_addresses`

**Açıklama:** ShippingAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Address adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ShippingAddress arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)

---

#### ShippingAddress POST

**Endpoint:** `POST /admin-api/shipping_addresses`

**Açıklama:** ShippingAddress postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)

---

#### ShippingAddress COUNT

**Endpoint:** `GET /admin-api/shipping_addresses/count`

**Açıklama:** ShippingAddress cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Address adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | ShippingAddress arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| order | query |  | integer | Order Id |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)

---

#### ShippingAddress GET

**Endpoint:** `GET /admin-api/shipping_addresses/{id}`

**Açıklama:** ShippingAddress getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)

---

#### ShippingAddress PUT

**Endpoint:** `PUT /admin-api/shipping_addresses/{id}`

**Açıklama:** ShippingAddress putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingAddress](#schema-shippingaddress)

---

### ShippingCompany

#### ShippingCompany LIST

**Endpoint:** `GET /admin-api/shipping_companies`

**Açıklama:** ShippingCompany cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Companies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Shipping company status arama filtresi.<br>İzin verilen değerler: `active`, `passive` |
| q | query |  | string | Shipping Company arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| is_abroad | query |  | integer | Search by countries. Country ids must be comma separated |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

#### ShippingCompany POST

**Endpoint:** `POST /admin-api/shipping_companies`

**Açıklama:** ShippingCompany postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

#### ShippingCompany COUNT

**Endpoint:** `GET /admin-api/shipping_companies/count`

**Açıklama:** ShippingCompany cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Companies adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Shipping company status arama filtresi.<br>İzin verilen değerler: `active`, `passive` |
| q | query |  | string | Shipping Company arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
| is_abroad | query |  | integer | Search by countries. Country ids must be comma separated |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

#### ShippingCompany GET

**Endpoint:** `GET /admin-api/shipping_companies/{id}`

**Açıklama:** ShippingCompany getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

#### ShippingCompany PUT

**Endpoint:** `PUT /admin-api/shipping_companies/{id}`

**Açıklama:** ShippingCompany putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

#### ShippingCompany DELETE

**Endpoint:** `DELETE /admin-api/shipping_companies/{id}`

**Açıklama:** ShippingCompany deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingCompany](#schema-shippingcompany)

---

### ShippingProvider

#### ShippingProvider LIST

**Endpoint:** `GET /admin-api/shipping_providers`

**Açıklama:** ShippingProvider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Provider adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipping Provider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProvider](#schema-shippingprovider)

---

#### ShippingProvider COUNT

**Endpoint:** `GET /admin-api/shipping_providers/count`

**Açıklama:** ShippingProvider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Provider adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipping Provider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProvider](#schema-shippingprovider)

---

#### ShippingProvider GET

**Endpoint:** `GET /admin-api/shipping_providers/{id}`

**Açıklama:** ShippingProvider getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProvider](#schema-shippingprovider)

---

#### ShippingProvider PUT

**Endpoint:** `PUT /admin-api/shipping_providers/{id}`

**Açıklama:** ShippingProvider putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProvider](#schema-shippingprovider)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProvider](#schema-shippingprovider)

---

### ShippingProviderSetting

#### ShippingProviderSetting LIST

**Endpoint:** `GET /admin-api/shipping_provider_settings`

**Açıklama:** ShippingProviderSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ShippingProviderSettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| shippingProvider | query |  | integer | Shipping Provider Id |
| q | query |  | string | ShippingProviderSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProviderSetting](#schema-shippingprovidersetting)

---

#### ShippingProviderSetting COUNT

**Endpoint:** `GET /admin-api/shipping_provider_settings/count`

**Açıklama:** ShippingProviderSetting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek ShippingProviderSettings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| shippingProvider | query |  | integer | Shipping Provider Id |
| q | query |  | string | ShippingProviderSetting arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProviderSetting](#schema-shippingprovidersetting)

---

#### ShippingProviderSetting GET

**Endpoint:** `GET /admin-api/shipping_provider_settings/{id}`

**Açıklama:** ShippingProviderSetting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProviderSetting](#schema-shippingprovidersetting)

---

#### ShippingProviderSetting PUT

**Endpoint:** `PUT /admin-api/shipping_provider_settings/{id}`

**Açıklama:** ShippingProviderSetting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProviderSetting](#schema-shippingprovidersetting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingProviderSetting](#schema-shippingprovidersetting)

---

### ShippingRate

#### ShippingRate LIST

**Endpoint:** `GET /admin-api/shipping_rates`

**Açıklama:** ShippingRate cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Rate adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| region | query |  | integer | Region arama filtresi. |
| shippingCompany | query |  | integer | ShippingCompany arama filtresi. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipping Rate arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

#### ShippingRate POST

**Endpoint:** `POST /admin-api/shipping_rates`

**Açıklama:** ShippingRate postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

#### ShippingRate COUNT

**Endpoint:** `GET /admin-api/shipping_rates/count`

**Açıklama:** ShippingRate cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Shipping Rate adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| region | query |  | integer | Region arama filtresi. |
| shippingCompany | query |  | integer | ShippingCompany arama filtresi. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shipping Rate arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

#### ShippingRate GET

**Endpoint:** `GET /admin-api/shipping_rates/{id}`

**Açıklama:** ShippingRate getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

#### ShippingRate PUT

**Endpoint:** `PUT /admin-api/shipping_rates/{id}`

**Açıklama:** ShippingRate putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

#### ShippingRate DELETE

**Endpoint:** `DELETE /admin-api/shipping_rates/{id}`

**Açıklama:** ShippingRate deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShippingRate](#schema-shippingrate)

---

### ShoppingExperience

#### ShoppingExperience LIST

**Endpoint:** `GET /admin-api/shopping_experiences`

**Açıklama:** ShoppingExperience cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Comments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shopping Experience arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)

---

#### ShoppingExperience COUNT

**Endpoint:** `GET /admin-api/shopping_experiences/count`

**Açıklama:** ShoppingExperience cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Comments adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| member | query |  | integer | Member Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Shopping Experience arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)

---

#### ShoppingExperience GET

**Endpoint:** `GET /admin-api/shopping_experiences/{id}`

**Açıklama:** ShoppingExperience getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)

---

#### ShoppingExperience PUT

**Endpoint:** `PUT /admin-api/shopping_experiences/{id}`

**Açıklama:** ShoppingExperience putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)

---

#### ShoppingExperience DELETE

**Endpoint:** `DELETE /admin-api/shopping_experiences/{id}`

**Açıklama:** ShoppingExperience deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [ShoppingExperience](#schema-shoppingexperience)

---

### SiteContent

#### SiteContent GET

**Endpoint:** `GET /admin-api/site_contents`

**Açıklama:** SiteContent getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SiteContent](#schema-sitecontent)

---

#### SiteContent PUT

**Endpoint:** `PUT /admin-api/site_contents`

**Açıklama:** SiteContent putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SiteContent](#schema-sitecontent)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SiteContent](#schema-sitecontent)

---

### Slider

#### Slider LIST

**Endpoint:** `GET /admin-api/sliders`

**Açıklama:** Slider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Slider adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Slider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

#### Slider POST

**Endpoint:** `POST /admin-api/sliders`

**Açıklama:** Slider postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

#### Slider COUNT

**Endpoint:** `GET /admin-api/sliders/count`

**Açıklama:** Slider cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Slider adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Slider arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

#### Slider GET

**Endpoint:** `GET /admin-api/sliders/{id}`

**Açıklama:** Slider getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

#### Slider PUT

**Endpoint:** `PUT /admin-api/sliders/{id}`

**Açıklama:** Slider putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

#### Slider DELETE

**Endpoint:** `DELETE /admin-api/sliders/{id}`

**Açıklama:** Slider deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Slider](#schema-slider)

---

### SmsConfig

#### SmsConfig GET

**Endpoint:** `GET /admin-api/sms_config`

**Açıklama:** SmsConfig getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmsConfig](#schema-smsconfig)

---

#### SmsConfig PUT

**Endpoint:** `PUT /admin-api/sms_config`

**Açıklama:** SmsConfig putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmsConfig](#schema-smsconfig)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmsConfig](#schema-smsconfig)

---

### SmtpPref

#### SmtpPref GET

**Endpoint:** `GET /admin-api/smtp_pref`

**Açıklama:** SmtpPref getAction

##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmtpPref](#schema-smtppref)

---

#### SmtpPref PUT

**Endpoint:** `PUT /admin-api/smtp_pref`

**Açıklama:** SmtpPref putAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmtpPref](#schema-smtppref)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SmtpPref](#schema-smtppref)

---

### SpecGroup

#### SpecGroup LIST

**Endpoint:** `GET /admin-api/spec_groups`

**Açıklama:** SpecGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Spec Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup POST

**Endpoint:** `POST /admin-api/spec_groups`

**Açıklama:** SpecGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup COUNT

**Endpoint:** `GET /admin-api/spec_groups/count`

**Açıklama:** SpecGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Groups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| q | query |  | string | Spec Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup GET

**Endpoint:** `GET /admin-api/spec_groups/{id}`

**Açıklama:** SpecGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup PUT

**Endpoint:** `PUT /admin-api/spec_groups/{id}`

**Açıklama:** SpecGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup DELETE

**Endpoint:** `DELETE /admin-api/spec_groups/{id}`

**Açıklama:** SpecGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecGroup](#schema-specgroup)

---

#### SpecGroup CopyAction POST

**Endpoint:** `POST /admin-api/spec_groups/{id}/copy`

**Açıklama:** SpecGroup copyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### SpecName

#### SpecName LIST

**Endpoint:** `GET /admin-api/spec_names`

**Açıklama:** SpecName cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Names adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| specGroup | query |  | integer | Spec Group Id |
| choiceType | query |  | string | Status  alanının alabilceği değerler:  singular veya plural<br>İzin verilen değerler: `singular`, `plural` |
| q | query |  | string | Spec Name arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

#### SpecName POST

**Endpoint:** `POST /admin-api/spec_names`

**Açıklama:** SpecName postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

#### SpecName COUNT

**Endpoint:** `GET /admin-api/spec_names/count`

**Açıklama:** SpecName cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Names adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| specGroup | query |  | integer | Spec Group Id |
| choiceType | query |  | string | Status  alanının alabilceği değerler:  singular veya plural<br>İzin verilen değerler: `singular`, `plural` |
| q | query |  | string | Spec Name arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

#### SpecName GET

**Endpoint:** `GET /admin-api/spec_names/{id}`

**Açıklama:** SpecName getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

#### SpecName PUT

**Endpoint:** `PUT /admin-api/spec_names/{id}`

**Açıklama:** SpecName putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

#### SpecName DELETE

**Endpoint:** `DELETE /admin-api/spec_names/{id}`

**Açıklama:** SpecName deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecName](#schema-specname)

---

### SpecValue

#### SpecValue LIST

**Endpoint:** `GET /admin-api/spec_values`

**Açıklama:** SpecValue cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Values adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| specName | query |  | integer | Spec Name Id |
| specGroup | query |  | integer | Spec Group Id |
| q | query |  | string | Spec Name arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

#### SpecValue POST

**Endpoint:** `POST /admin-api/spec_values`

**Açıklama:** SpecValue postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

#### SpecValue COUNT

**Endpoint:** `GET /admin-api/spec_values/count`

**Açıklama:** SpecValue cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Spec Values adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| specName | query |  | integer | Spec Name Id |
| specGroup | query |  | integer | Spec Group Id |
| q | query |  | string | Spec Name arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

#### SpecValue GET

**Endpoint:** `GET /admin-api/spec_values/{id}`

**Açıklama:** SpecValue getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

#### SpecValue PUT

**Endpoint:** `PUT /admin-api/spec_values/{id}`

**Açıklama:** SpecValue putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

#### SpecValue DELETE

**Endpoint:** `DELETE /admin-api/spec_values/{id}`

**Açıklama:** SpecValue deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SpecValue](#schema-specvalue)

---

### Statistic

#### Statistic OrderChartsDailyAction GET

**Endpoint:** `GET /admin-api/statistics/daily_orders`

**Açıklama:** Statistic orderChartsDailyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAt | query |  | string (date) | Zaman aralığı bitişi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Statistic OrderChartsMonthlyAction GET

**Endpoint:** `GET /admin-api/statistics/monthly_orders`

**Açıklama:** Statistic orderChartsMonthlyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| year | query | ✓ | integer | Year of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Order](#schema-order)

---

#### Statistic ProductOrdersChartAction GET

**Endpoint:** `GET /admin-api/statistics/product_orders`

**Açıklama:** Statistic productOrdersChartAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| page | query |  | string | Requested page |
| limit | query |  | integer | Limit filtresi. |
| q | query |  | string | Search key filter. |
| sort | query |  | string | Sort results. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductOrder](#schema-productorder)

---

#### Statistic MemberOrderCountChartAction GET

**Endpoint:** `GET /admin-api/statistics/member_order_count`

**Açıklama:** Statistic memberOrderCountChartAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Limit filtresi. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberOrder](#schema-memberorder)

---

#### Statistic MemberOrderPriceChartAction GET

**Endpoint:** `GET /admin-api/statistics/member_order_price`

**Açıklama:** Statistic memberOrderPriceChartAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| limit | query |  | integer | Limit filtresi. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [MemberOrder](#schema-memberorder)

---

#### Statistic BandwidthChartDailyAction GET

**Endpoint:** `GET /admin-api/statistics/daily_bandwidths`

**Açıklama:** Statistic bandwidthChartDailyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAt | query |  | string (date) | Zaman aralığı bitişi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Bandwidth](#schema-bandwidth)

---

#### Statistic BandwidthChartMonthlyAction GET

**Endpoint:** `GET /admin-api/statistics/monthly_bandwidths`

**Açıklama:** Statistic bandwidthChartMonthlyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| year | query | ✓ | integer | Year of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Bandwidth](#schema-bandwidth)

---

#### Statistic ProductRateAction GET

**Endpoint:** `GET /admin-api/statistics/product_rates`

**Açıklama:** Statistic productRateAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| page | query |  | string | Requested page |
| limit | query |  | integer | Limit filtresi. |
| q | query |  | string | Search key filter. |
| sort | query |  | string | Sort results. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductRate](#schema-productrate)

---

#### Statistic PaymentOrderChartsDailyAction GET

**Endpoint:** `GET /admin-api/statistics/daily_payments`

**Açıklama:** Statistic paymentOrderChartsDailyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAt | query |  | string (date) | Zaman aralığı bitişi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Statistic PaymentMonthlyChartsDailyAction GET

**Endpoint:** `GET /admin-api/statistics/monthly_payments`

**Açıklama:** Statistic paymentMonthlyChartsDailyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| year | query | ✓ | integer | Year of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Payment](#schema-payment)

---

#### Statistic OrderPaymentTypeChartsAction GET

**Endpoint:** `GET /admin-api/statistics/order_payment_types`

**Açıklama:** Statistic orderPaymentTypeChartsAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Zaman aralığı başlangıcı |
| endAt | query |  | string (date) | Zaman aralığı bitişi |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderPaymentType](#schema-orderpaymenttype)

---

#### Statistic MemberChartsDaily GET

**Endpoint:** `GET /admin-api/statistics/daily_members`

**Açıklama:** Statistic memberChartsDaily

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Statistic MemberChartsMonthly GET

**Endpoint:** `GET /admin-api/statistics/monthly_members`

**Açıklama:** Statistic memberChartsMonthly

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| year | query | ✓ | integer | Year of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Member](#schema-member)

---

#### Statistic DailyPageViewsChart GET

**Endpoint:** `GET /admin-api/statistics/daily_page_views`

**Açıklama:** Statistic dailyPageViewsChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PageView](#schema-pageview)

---

#### Statistic MonthlyPageViewsChart GET

**Endpoint:** `GET /admin-api/statistics/monthly_page_views`

**Açıklama:** Statistic monthlyPageViewsChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| year | query | ✓ | integer | Year of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [PageView](#schema-pageview)

---

#### Statistic ProductViewsChart GET

**Endpoint:** `GET /admin-api/statistics/product_views`

**Açıklama:** Statistic productViewsChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| limit | query |  | integer | limit filter |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [ProductView](#schema-productview)

---

#### Statistic OrderShippingTypeChart GET

**Endpoint:** `GET /admin-api/statistics/order_shipping_types`

**Açıklama:** Statistic orderShippingTypeChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderShippingType](#schema-ordershippingtype)

---

#### Statistic OrderMemberPercentageChart GET

**Endpoint:** `GET /admin-api/statistics/order_member_percentage`

**Açıklama:** Statistic orderMemberPercentageChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderMemberPercentage](#schema-ordermemberpercentage)

---

#### Statistic SearchStatisticsData GET

**Endpoint:** `GET /admin-api/statistics/search_statistics`

**Açıklama:** Statistic searchStatisticsData

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| page | query |  | string | Requested page |
| limit | query |  | integer | Limit filter |
| q | query |  | string | Search key filter. |
| s | query |  | string | Search key filter. |
| sort | query |  | string | Sort results. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SearchAnalytic](#schema-searchanalytic)

---

#### Statistic RefundedProductsChart GET

**Endpoint:** `GET /admin-api/statistics/refunded_products`

**Açıklama:** Statistic refundedProductsChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| page | query |  | string | Requested page |
| limit | query |  | integer | Limit filter |
| q | query |  | string | Search key filter. |
| sort | query |  | string | Sort results. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [RefundedProduct](#schema-refundedproduct)

---

#### Statistic OrderDeviceTypeChart GET

**Endpoint:** `GET /admin-api/statistics/order_device_types`

**Açıklama:** Statistic orderDeviceTypeChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderDeviceType](#schema-orderdevicetype)

---

#### Statistic OrderLocationChart GET

**Endpoint:** `GET /admin-api/statistics/order_locations`

**Açıklama:** Statistic orderLocationChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| limit | query |  | integer | limit filter |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [OrderLocation](#schema-orderlocation)

---

#### Statistic SaleSourceChart GET

**Endpoint:** `GET /admin-api/statistics/sale_sources`

**Açıklama:** Statistic saleSourceChart

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| startAt | query |  | string (date) | Start of the time frame |
| endAt | query |  | string (date) | End of the time frame |
| limit | query |  | integer | limit filter |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SaleSource](#schema-salesource)

---

### StockWarning

#### StockWarning LIST

**Endpoint:** `GET /admin-api/stock_warnings`

**Açıklama:** StockWarning cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Stock Warnings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [StockWarning](#schema-stockwarning)

---

#### StockWarning COUNT

**Endpoint:** `GET /admin-api/stock_warnings/count`

**Açıklama:** StockWarning cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Stock Warnings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [StockWarning](#schema-stockwarning)

---

#### StockWarning DELETE

**Endpoint:** `DELETE /admin-api/stock_warnings/{id}`

**Açıklama:** StockWarning deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [StockWarning](#schema-stockwarning)

---

### Subscription

#### Subscription LIST

**Endpoint:** `GET /admin-api/subscriptions`

**Açıklama:** Subscription cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Subscriptions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Subscription  arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

#### Subscription POST

**Endpoint:** `POST /admin-api/subscriptions`

**Açıklama:** Subscription postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

#### Subscription COUNT

**Endpoint:** `GET /admin-api/subscriptions/count`

**Açıklama:** Subscription cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Subscriptions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Subscription  arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

#### Subscription GET

**Endpoint:** `GET /admin-api/subscriptions/{id}`

**Açıklama:** Subscription getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

#### Subscription PUT

**Endpoint:** `PUT /admin-api/subscriptions/{id}`

**Açıklama:** Subscription putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

#### Subscription DELETE

**Endpoint:** `DELETE /admin-api/subscriptions/{id}`

**Açıklama:** Subscription deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Subscription](#schema-subscription)

---

### SubscriptionProduct

#### SubscriptionProduct LIST

**Endpoint:** `GET /admin-api/subscription_to_products`

**Açıklama:** SubscriptionProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Subscription Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| subscription | query |  | integer | Subscription Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Subscription Product  arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

#### SubscriptionProduct POST

**Endpoint:** `POST /admin-api/subscription_to_products`

**Açıklama:** SubscriptionProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

#### SubscriptionProduct COUNT

**Endpoint:** `GET /admin-api/subscription_to_products/count`

**Açıklama:** SubscriptionProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Subscription Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| product | query |  | integer | Product Id |
| subscription | query |  | integer | Subscription Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Subscription Product  arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

#### SubscriptionProduct GET

**Endpoint:** `GET /admin-api/subscription_to_products/{id}`

**Açıklama:** SubscriptionProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

#### SubscriptionProduct PUT

**Endpoint:** `PUT /admin-api/subscription_to_products/{id}`

**Açıklama:** SubscriptionProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

#### SubscriptionProduct DELETE

**Endpoint:** `DELETE /admin-api/subscription_to_products/{id}`

**Açıklama:** SubscriptionProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [SubscriptionProduct](#schema-subscriptionproduct)

---

### TabbedMidblock

#### TabbedMidblock LIST

**Endpoint:** `GET /admin-api/tabbed_midblocks`

**Açıklama:** TabbedMidblock cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tabbed Mid Blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Tabbed Mid Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

#### TabbedMidblock POST

**Endpoint:** `POST /admin-api/tabbed_midblocks`

**Açıklama:** TabbedMidblock postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

#### TabbedMidblock COUNT

**Endpoint:** `GET /admin-api/tabbed_midblocks/count`

**Açıklama:** TabbedMidblock cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tabbed Mid Blocks adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | Tabbed Mid Block arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

#### TabbedMidblock GET

**Endpoint:** `GET /admin-api/tabbed_midblocks/{id}`

**Açıklama:** TabbedMidblock getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

#### TabbedMidblock PUT

**Endpoint:** `PUT /admin-api/tabbed_midblocks/{id}`

**Açıklama:** TabbedMidblock putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

#### TabbedMidblock DELETE

**Endpoint:** `DELETE /admin-api/tabbed_midblocks/{id}`

**Açıklama:** TabbedMidblock deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblock](#schema-tabbedmidblock)

---

### TabbedMidblockProduct

#### TabbedMidblockProduct LIST

**Endpoint:** `GET /admin-api/tabbed_midblock_to_products`

**Açıklama:** TabbedMidblockProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tabbed Mid Block Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| tabbedMidblock | query |  | integer | Tabbed Mid Block Id |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | TabbedMidblockProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

#### TabbedMidblockProduct POST

**Endpoint:** `POST /admin-api/tabbed_midblock_to_products`

**Açıklama:** TabbedMidblockProduct postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

#### TabbedMidblockProduct COUNT

**Endpoint:** `GET /admin-api/tabbed_midblock_to_products/count`

**Açıklama:** TabbedMidblockProduct cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tabbed Mid Block Products adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| tabbedMidblock | query |  | integer | Tabbed Mid Block Id |
| product | query |  | integer | Product Id |
| id | query |  | integer | Tekli listeleme için id değeri. |
| q | query |  | string | TabbedMidblockProduct arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

#### TabbedMidblockProduct GET

**Endpoint:** `GET /admin-api/tabbed_midblock_to_products/{id}`

**Açıklama:** TabbedMidblockProduct getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

#### TabbedMidblockProduct PUT

**Endpoint:** `PUT /admin-api/tabbed_midblock_to_products/{id}`

**Açıklama:** TabbedMidblockProduct putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

#### TabbedMidblockProduct DELETE

**Endpoint:** `DELETE /admin-api/tabbed_midblock_to_products/{id}`

**Açıklama:** TabbedMidblockProduct deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [TabbedMidblockProduct](#schema-tabbedmidblockproduct)

---

### Tag

#### Tag LIST

**Endpoint:** `GET /admin-api/tags`

**Açıklama:** Tag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Tags arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

#### Tag POST

**Endpoint:** `POST /admin-api/tags`

**Açıklama:** Tag postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

#### Tag COUNT

**Endpoint:** `GET /admin-api/tags/count`

**Açıklama:** Tag cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tags adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Tags arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

#### Tag GET

**Endpoint:** `GET /admin-api/tags/{id}`

**Açıklama:** Tag getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

#### Tag PUT

**Endpoint:** `PUT /admin-api/tags/{id}`

**Açıklama:** Tag putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

#### Tag DELETE

**Endpoint:** `DELETE /admin-api/tags/{id}`

**Açıklama:** Tag deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Tag](#schema-tag)

---

### Theme

#### Theme LIST

**Endpoint:** `GET /admin-api/themes`

**Açıklama:** Theme cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Themes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Theme status<br>İzin verilen değerler: `0`, `1` |
| version | query |  | string | Theme version<br>İzin verilen değerler: `1`, `2` |
| platform | query |  | string | Platform type<br>İzin verilen değerler: `desktop`, `mobile` |
| type | query |  | string | Theme type<br>İzin verilen değerler: `self`, `standard` |
| q | query |  | string | Theme arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme POST

**Endpoint:** `POST /admin-api/themes`

**Açıklama:** Theme postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme COUNT

**Endpoint:** `GET /admin-api/themes/count`

**Açıklama:** Theme cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Themes adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Theme status<br>İzin verilen değerler: `0`, `1` |
| version | query |  | string | Theme version<br>İzin verilen değerler: `1`, `2` |
| platform | query |  | string | Platform type<br>İzin verilen değerler: `desktop`, `mobile` |
| type | query |  | string | Theme type<br>İzin verilen değerler: `self`, `standard` |
| q | query |  | string | Theme arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme GET

**Endpoint:** `GET /admin-api/themes/{id}`

**Açıklama:** Theme getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme PUT

**Endpoint:** `PUT /admin-api/themes/{id}`

**Açıklama:** Theme putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme DELETE

**Endpoint:** `DELETE /admin-api/themes/{id}`

**Açıklama:** Theme deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Theme](#schema-theme)

---

#### Theme CgetAssetAction GET

**Endpoint:** `GET /admin-api/themes/{id}/assets`

**Açıklama:** Theme cgetAssetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| key | query |  | string | Asset key. |
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Asset](#schema-asset)

---

#### Theme PutAssetAction PUT

**Endpoint:** `PUT /admin-api/themes/{id}/assets`

**Açıklama:** Theme putAssetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Asset](#schema-asset)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Asset](#schema-asset)

---

#### Theme DeleteAssetAction DELETE

**Endpoint:** `DELETE /admin-api/themes/{id}/assets`

**Açıklama:** Theme deleteAssetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| key | query | ✓ | string | Asset key. |
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Asset](#schema-asset)

---

### Ticket

#### Ticket LIST

**Endpoint:** `GET /admin-api/tickets`

**Açıklama:** Ticket cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tickets adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| code | query |  | string | Ticket Code |
| email | query |  | string | Member Email |
| status | query |  | string | status |
| q | query |  | string | Ticket arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

#### Ticket POST

**Endpoint:** `POST /admin-api/tickets`

**Açıklama:** Ticket postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

#### Ticket COUNT

**Endpoint:** `GET /admin-api/tickets/count`

**Açıklama:** Ticket cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Tickets adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| parent | query |  | string | Parent Id |
| code | query |  | string | Ticket Code |
| email | query |  | string | Member Email |
| status | query |  | string | status |
| q | query |  | string | Ticket arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

#### Ticket GET

**Endpoint:** `GET /admin-api/tickets/{id}`

**Açıklama:** Ticket getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

#### Ticket PUT

**Endpoint:** `PUT /admin-api/tickets/{id}`

**Açıklama:** Ticket putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

#### Ticket DELETE

**Endpoint:** `DELETE /admin-api/tickets/{id}`

**Açıklama:** Ticket deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Ticket](#schema-ticket)

---

### Town

#### Town LIST

**Endpoint:** `GET /admin-api/towns`

**Açıklama:** Town cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Towns adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| location | query |  | integer | Location id |
| townGroup | query |  | integer | Town Group id |
| q | query |  | string | Town arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

#### Town POST

**Endpoint:** `POST /admin-api/towns`

**Açıklama:** Town postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

#### Town COUNT

**Endpoint:** `GET /admin-api/towns/count`

**Açıklama:** Town cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Towns adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| status | query |  | string | Status  alanının alabilceği değerler:  0 veya 1<br>İzin verilen değerler: `0`, `1` |
| location | query |  | integer | Location id |
| townGroup | query |  | integer | Town Group id |
| q | query |  | string | Town arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

#### Town GET

**Endpoint:** `GET /admin-api/towns/{id}`

**Açıklama:** Town getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

#### Town PUT

**Endpoint:** `PUT /admin-api/towns/{id}`

**Açıklama:** Town putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

#### Town DELETE

**Endpoint:** `DELETE /admin-api/towns/{id}`

**Açıklama:** Town deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [Town](#schema-town)

---

### TownGroup

#### TownGroup LIST

**Endpoint:** `GET /admin-api/town_groups`

**Açıklama:** TownGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek TownGroups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Town Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup POST

**Endpoint:** `POST /admin-api/town_groups`

**Açıklama:** TownGroup postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup COUNT

**Endpoint:** `GET /admin-api/town_groups/count`

**Açıklama:** TownGroup cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek TownGroups adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | Town Group arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup GET

**Endpoint:** `GET /admin-api/town_groups/{id}`

**Açıklama:** TownGroup getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup PUT

**Endpoint:** `PUT /admin-api/town_groups/{id}`

**Açıklama:** TownGroup putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup DELETE

**Endpoint:** `DELETE /admin-api/town_groups/{id}`

**Açıklama:** TownGroup deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [TownGroup](#schema-towngroup)

---

#### TownGroup CopyAction POST

**Endpoint:** `POST /admin-api/town_groups/{id}/copy`

**Açıklama:** TownGroup copyAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.


---

### UrlRouting

#### UrlRouting LIST

**Endpoint:** `GET /admin-api/url_routings`

**Açıklama:** UrlRouting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek url routings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | url routings arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

#### UrlRouting POST

**Endpoint:** `POST /admin-api/url_routings`

**Açıklama:** UrlRouting postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

#### UrlRouting COUNT

**Endpoint:** `GET /admin-api/url_routings/count`

**Açıklama:** UrlRouting cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek url routings adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | url routings arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

#### UrlRouting GET

**Endpoint:** `GET /admin-api/url_routings/{id}`

**Açıklama:** UrlRouting getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

#### UrlRouting PUT

**Endpoint:** `PUT /admin-api/url_routings/{id}`

**Açıklama:** UrlRouting putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

#### UrlRouting DELETE

**Endpoint:** `DELETE /admin-api/url_routings/{id}`

**Açıklama:** UrlRouting deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [UrlRouting](#schema-urlrouting)

---

### User

#### User LIST

**Endpoint:** `GET /admin-api/users`

**Açıklama:** User cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Users adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | User arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

#### User POST

**Endpoint:** `POST /admin-api/users`

**Açıklama:** User postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

#### User COUNT

**Endpoint:** `GET /admin-api/users/count`

**Açıklama:** User cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek Users adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | User arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

#### User GET

**Endpoint:** `GET /admin-api/users/{id}`

**Açıklama:** User getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

#### User PUT

**Endpoint:** `PUT /admin-api/users/{id}`

**Açıklama:** User putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

#### User DELETE

**Endpoint:** `DELETE /admin-api/users/{id}`

**Açıklama:** User deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [User](#schema-user)

---

### UserRole

#### UserRole LIST

**Endpoint:** `GET /admin-api/user_roles`

**Açıklama:** UserRole cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek User Roles adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | User Role arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

#### UserRole POST

**Endpoint:** `POST /admin-api/user_roles`

**Açıklama:** UserRole postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

#### UserRole COUNT

**Endpoint:** `GET /admin-api/user_roles/count`

**Açıklama:** UserRole cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek User Roles adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| q | query |  | string | User Role arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

#### UserRole GET

**Endpoint:** `GET /admin-api/user_roles/{id}`

**Açıklama:** UserRole getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

#### UserRole PUT

**Endpoint:** `PUT /admin-api/user_roles/{id}`

**Açıklama:** UserRole putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

#### UserRole DELETE

**Endpoint:** `DELETE /admin-api/user_roles/{id}`

**Açıklama:** UserRole deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRole](#schema-userrole)

---

### UserRolePermission

#### UserRolePermission LIST

**Endpoint:** `GET /admin-api/user_role_permissions`

**Açıklama:** UserRolePermission cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek User Role Permissions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| userRole | query |  | integer | User Role Id |
| q | query |  | string | User Role Permission arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

#### UserRolePermission POST

**Endpoint:** `POST /admin-api/user_role_permissions`

**Açıklama:** UserRolePermission postAction

##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)
##### Yanıtlar

###### 201 - Oluşturma işlemi (POST) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

#### UserRolePermission COUNT

**Endpoint:** `GET /admin-api/user_role_permissions/count`

**Açıklama:** UserRolePermission cgetAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| sort | query |  | string | Sıralama değeri. Örnek: Artan sıra için <code>sort=id</code> azalan sıra için <code>sort=-id</code> |
| limit | query |  | integer | Bir sayfada gelecek User Role Permissions adedi |
| page | query |  | integer | Hangi sayfadan başlanacağı |
| id | query |  | integer | Tekli listeleme için id değeri. |
| ids | query |  | string | Çoklu listeleme için virgülle ayrılmış id değerleri. <code>ids=1,2,3,4</code> |
| sinceId | query |  | integer | Yalnızca belirtilen id değerinden sonraki kayıtları getirir  |
| userRole | query |  | integer | User Role Id |
| q | query |  | string | User Role Permission arama filtresi. Kullanımı: q[&lt;geçerli-query-parametresi&gt;] |
| s | query |  | string | Arama anahtarı ile filtreleme. |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

#### UserRolePermission GET

**Endpoint:** `GET /admin-api/user_role_permissions/{id}`

**Açıklama:** UserRolePermission getAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

#### UserRolePermission PUT

**Endpoint:** `PUT /admin-api/user_role_permissions/{id}`

**Açıklama:** UserRolePermission putAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Request Body

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)
##### Yanıtlar

###### 200 - İşlem (GET veya PUT) başarı ile sonuçlandı.

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

#### UserRolePermission DELETE

**Endpoint:** `DELETE /admin-api/user_role_permissions/{id}`

**Açıklama:** UserRolePermission deleteAction

##### Parametreler

| Ad | Konum | Gerekli | Tip | Açıklama |
|---|---|:---:|---|---|
| id | path | ✓ | string |  |
##### Yanıtlar

###### 204 - Silme isteği başarı ile sonuçlandı. (cevapta içerik bulunmaz.)

**İçerik Tipleri:**

* `application/json`
  * Şema: [UserRolePermission](#schema-userrolepermission)

---

## Veri Modelleri

<h3 id='schema-productrate'>ProductRate</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| count | integer |  |  |
| rate | number (float) |  |  |

---

<h3 id='schema-productview'>ProductView</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| productUrl | string |  |  |
| count | integer |  |  |

---

<h3 id='schema-memberorder'>MemberOrder</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| firstname | string |  |  |
| surname | string |  |  |
| email | string |  |  |
| count | integer |  |  |
| price | number (float) |  |  |

---

<h3 id='schema-pageview'>PageView</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| totalPageViewCount | integer |  |  |
| totalSessionCount | integer |  |  |
| data | object |  |  |

---

<h3 id='schema-orderlocation'>OrderLocation</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| locationName | string |  |  |
| orderCount | integer |  |  |

---

<h3 id='schema-productorder'>ProductOrder</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| productId | integer |  |  |
| productName | string |  |  |
| productSlug | string |  |  |
| orderCount | integer |  |  |
| orderItemCount | integer |  |  |

---

<h3 id='schema-searchanalytic'>SearchAnalytic</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| keyword | string |  |  |
| searchCount | integer |  |  |

---

<h3 id='schema-orderpaymenttype'>OrderPaymentType</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| type | string |  |  |
| orderCount | integer |  |  |

---

<h3 id='schema-statistic-model-payment'>Statistic-Model-Payment</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| totalApprovedCount | integer |  |  |
| totalCount | integer |  |  |
| totalPrice | number (float) |  |  |
| data | object |  |  |

---

<h3 id='schema-statistic-model-member'>Statistic-Model-Member</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| date | string |  |  |
| count | integer |  |  |

---

<h3 id='schema-orderdevicetype'>OrderDeviceType</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| type | string |  |  |
| orderCount | integer |  |  |

---

<h3 id='schema-refundedproduct'>RefundedProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| refundedQuantity | integer |  |  |

---

<h3 id='schema-bandwidth'>Bandwidth</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| date | string |  |  |
| count | integer |  |  |

---

<h3 id='schema-session'>Session</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| keyword | string |  |  |
| duration | integer |  |  |

---

<h3 id='schema-salesource'>SaleSource</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| source | string |  |  |
| orderCount | integer |  |  |
| totalOrderPrice | number (float) |  |  |
| totalOrderItemQuantity | number (float) |  |  |

---

<h3 id='schema-paymentdata'>PaymentData</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| date | string |  |  |
| approvedCount | integer |  |  |
| count | integer |  |  |
| price | number (float) |  |  |

---

<h3 id='schema-orderdata'>OrderData</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| date | string |  |  |
| approvedCount | integer |  |  |
| count | integer |  |  |
| price | number (float) |  |  |
| orderItemQuantity | number (float) |  |  |

---

<h3 id='schema-pageviewdata'>PageViewData</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| date | string |  |  |
| pageViewCount | integer |  |  |
| sessionCount | integer |  |  |

---

<h3 id='schema-visitordata'>VisitorData</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| keyword | string |  |  |
| totalCount | integer |  |  |
| age | string |  |  |
| avgSessionDuration | string |  |  |
| pageViewsPerSession | string |  |  |
| date | string |  |  |

---

<h3 id='schema-statistic-model-order'>Statistic-Model-Order</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| totalApprovedCount | integer |  |  |
| cancelledCount | integer |  |  |
| totalCount | integer |  |  |
| totalPrice | number (float) |  |  |
| totalOrderItemQuantity | number (float) |  |  |
| data | object |  |  |

---

<h3 id='schema-ordershippingtype'>OrderShippingType</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| type | string |  |  |
| orderCount | integer |  |  |

---

<h3 id='schema-statisticrequest'>StatisticRequest</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| startAt | string |  |  |
| endAt | string |  |  |
| year | integer |  |  |
| limit | integer |  |  |
| page | integer |  |  |
| keyword | string |  |  |
| sort | string |  |  |
| dailyArray | object |  |  |
| monthlyArray | object |  |  |

---

<h3 id='schema-visitor'>Visitor</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| totalCount | integer |  |  |
| newVisitor | number (float) |  |  |
| returningVisitor | number (float) |  |  |
| newVisitorAvgSessionDuration | number (float) |  |  |
| newVisitorPageViewsPerSession | number (float) |  |  |
| returningVisitorAvgSessionDuration | number (float) |  |  |
| returningVisitorPageViewsPerSession | number (float) |  |  |
| totalMaleVisitor | number (float) |  |  |
| totalFemaleVisitor | number (float) |  |  |
| data | object |  |  |

---

<h3 id='schema-ordermemberpercentage'>OrderMemberPercentage</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| totalOrderCountWithMember | integer |  |  |
| totalOrderCountWithoutMember | integer |  |  |
| totalOrderCount | integer |  |  |

---

<h3 id='schema-asset'>Asset</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| key | string | ✓ | Tema Dosyası nesnesi anahtar değeri. |
| contentType | string |  | Tema Dosyası içerik tipi. Geçerli bir MIME Content-Type verilmelidir. |
| createdAt | string |  | Tema Dosyası nesnesinin oluşturulma zamanı. |
| updatedAt | string |  | Tema Dosyası nesnesinin güncellenme zamanı. |
| attachment | string |  | Tema Dosyası içeriği. |

---

<h3 id='schema-contractplan'>ContractPlan</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Abonelik planı nesnesi kimlik değeri. |
| period | integer | ✓ | Abonelik planı nesnesi periyodu |
| status | string | ✓ | Abonelik Planı nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `waiting`, `successful`, `failed`, `canceled` |
| message | string |  | Abonelik planı nesnesi mesaj değeri. |
| periodDate | string (date-time) |  | Abonelik planı nesnesi periyodu  |
| contract | [Contract](#schema-contract) | ✓ |  |
| createdAt | string (date-time) |  | Abonelik planı nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Abonelik planı nesnesinin güncellenme zamanı. |

---

<h3 id='schema-offeredproduct'>OfferedProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Tavsiye ürünler nesnesi kimlik değeri |
| product | [ManualRelation](#schema-manualrelation) | ✓ |  |
| offeredProduct | [ManualRelation](#schema-manualrelation) | ✓ |  |

---

<h3 id='schema-productlabel'>ProductLabel</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün Adı ile ürün nesnesi bağı kimlik değeri. |
| label | [Label](#schema-label) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-client'>Client</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| name | string | ✓ | name |
| randomId | string |  | randomId |
| secret | string |  | secret |
| redirectUris | object | ✓ | redirectUris |
| allowedGrantTypes | object | ✓ | allowedGrantTypes |
| createdAt | string (date-time) |  | createdAt |
| updatedAt | string (date-time) |  | updatedAt |

---

<h3 id='schema-pointlog'>PointLog</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Puan geçmişi nesnesi |
| pointValue | number (float) | ✓ | Puan değeri |
| event | string | ✓ | Puan kazanılan olay<br>İzin verilen değerler: `advice`, `comment`, `shopping`, `shoppingcancel`, `signup`, `vote`, `token_production`, `payment`, `paymentcancel`, `invitedshopping`, `invitedshoppingcancel`, `admincancel` |
| mark | integer | ✓ | Puan Tipi<br>İzin verilen değerler: `0`, `1` |
| member | [Member](#schema-member) | ✓ |  |
| createdAt | string (date-time) |  | Puan geçmişi nesnesi oluşturulma zamanı. |

---

<h3 id='schema-billingaddress'>BillingAddress</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Fatura adresi nesnesi kimlik değeri. |
| firstname | string | ✓ | Müşterinin ismi. |
| surname | string | ✓ | Müşterinin soy ismi. |
| country | string | ✓ | Müşterinin ülke bilgisi. |
| location | string | ✓ | Müşterinin şehir bilgisi. |
| subLocation | string | ✓ | Müşterinin ilçe bilgisi. |
| address | string | ✓ | Müşterinin adres bilgisi. |
| phoneNumber | string |  | Müşterinin telefon numarası. |
| mobilePhoneNumber | string | ✓ | Müşterinin mobil telefon numarası. |
| zipCode | string |  |  |
| order | [Order](#schema-order) | ✓ |  |
| invoiceType | string | ✓ | Fatura tipini belirtir.<br>İzin verilen değerler: `individual`, `corporate` |
| taxNo | string |  | Fatura için vergi numarası. |
| taxOffice | string |  | Fatura için vergi dairesi. |
| identityRegistrationNumber | string |  | Müşterinin TC Kimlik numarası |

---

<h3 id='schema-productcategory'>ProductCategory</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün kategori bağı nesnesi kimlik değeri. |
| product | [Product](#schema-product) | ✓ |  |
| category | [Category](#schema-category) | ✓ |  |
| sortOrder | integer |  | Ürün kategori bağının sıralama değeri. Vitrin sırası belirlememek için null değer atayabilirsiniz. |

---

<h3 id='schema-customizationgroup'>CustomizationGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Özel Form Alanları nesnesi kimlik değeri. |
| name | string |  | Özel Form Alanları nesnesi için isim değeri. |
| type | string | ✓ | Form Türü<br>İzin verilen değerler: `Member` |
| namespace | string | ✓ | Form Alanı<br>İzin verilen değerler: `Signup` |
| sortOrder | integer | ✓ | Özel Form Alanları nesnesi için sıralama değeri. |
| status | integer | ✓ | Özel Form Alanları nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| fields | array[[CustomizationField](#schema-customizationfield)] |  | Form alanları |
| signupPreferences | array[[SignupPreference](#schema-signuppreference)] |  |  |
| updatedAt | string (date-time) |  | Özel Form Alanları nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Özel Form Alanları nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-queueprocess'>QueueProcess</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kuyruk işlemi nesnesi kimlik değeri |
| type | string |  | Kuyruk işlemi tipi |
| model | string |  | model |
| status | string |  | status<br>İzin verilen değerler: `cancelled` |
| output | string |  | output |
| createdAt | string (date-time) |  | createdAt |
| updatedAt | string (date-time) |  | updatedAt |

---

<h3 id='schema-pricerule'>PriceRule</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| name | string |  |  |
| ruleType | string |  |  |
| country | [Country](#schema-country) |  |  |
| currency | [Currency](#schema-currency) |  |  |
| priceType | string |  | <br>İzin verilen değerler: `price1`, `price2`, `price3`, `price4`, `price5` |
| operation | string |  | <br>İzin verilen değerler: `increase`, `decrease` |
| type | string |  | <br>İzin verilen değerler: `percentage`, `regular` |
| value | number (float) |  |  |
| rounding | string |  | <br>İzin verilen değerler: `up`, `down`, `none` |
| status | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  |  |
| updatedAt | string (date-time) |  |  |

---

<h3 id='schema-specvalue'>SpecValue</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ürün özelliği değeri nesnesi kimlik değeri. |
| name | string | ✓ | Ürün özelliği değeri nesnesi adı. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| logo | string |  | Ürün özelliği değeri nesnesi logosu. |
| sortOrder | integer | ✓ | Ürün özelliği değeri nesnesi  sırası. |
| status | integer | ✓ | Ürün özelliği değeri nesnesi aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| imageUrl | string |  | Ürün özelliği değeri nesnesi imajı |
| attachment | string |  | Ürün özelliği değeri nesnesi imajı dosyası. |
| size | integer |  | Boyut<br>İzin verilen değerler: `16`, `24`, `32` |
| specName | [SpecName](#schema-specname) | ✓ |  |
| specGroup | [SpecGroup](#schema-specgroup) | ✓ |  |
| updatedAt | string (date-time) |  | Ürün özelliği değeri nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Ürün özelliği değeri nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-brand'>Brand</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Marka nesnesi kimlik değeri. |
| name | string | ✓ | Marka nesnesi için isim değeri. |
| slug | string |  |  |
| status | integer | ✓ | Marka nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ | Marka nesnesi için sıralama değeri. |
| distributorCode | string |  | Markanın tedarikçi kodu |
| distributor | string |  | Markanın tedarikçisi. |
| imageFile | string |  | Marka nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF |
| showcaseContent | string |  | Marka nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir. |
| displayShowcaseContent | integer | ✓ | Marka nesnesi üst içerik metninin gösterim durumu.<br>İzin verilen değerler: `0`, `1`, `2` |
| showcaseFooterContent | string |  |  |
| displayShowcaseFooterContent | integer | ✓ | <br>İzin verilen değerler: `0`, `1`, `2` |
| pageTitle | string |  | Sayfanın arama motorları tarafından tespit edilebilecek başlık yazısı. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir.. |
| imageUrl | string |  | Marka nesnesinin görselinin url'i. |
| attachment | string |  | Marka nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir. |
| seoSetting | [SeoSetting](#schema-seosetting) |  |  |
| isSearchable | integer |  | <br>İzin verilen değerler: `0`, `1` |
| updatedAt | string (date-time) |  | Marka nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Marka nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-contract'>Contract</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Abonelik nesnesi kimlik değeri. |
| name | string | ✓ | Abonelik nesnesi için isim değeri. |
| status | string | ✓ | Abonelik nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `active`, `passive` |
| description | string | ✓ | Abonelik nesnesinin açıklaması. |
| periods | string | ✓ | Abonelik periyodu |
| periodFrequency | string | ✓ | Abonelik periyodu gönderim aralıkları |
| dispatchCounts | string | ✓ | Periyod içindeki sevk sayısı |
| shippingAmount | number (float) | ✓ | Ek Kargo Ücreti |
| discount | integer | ✓ | İndirim |
| chosenPeriod | integer | ✓ | Seçilmiş Abonelik periyodu |
| chosenDispatchCount | integer | ✓ | Seçilmiş Abonelik Periyodu içindeki sevk sayısı |
| paymentToken | string |  |  |
| firstInstallmentRate | number (float) |  | Abonelik nesnesi taksit oranı |
| orderItem | [OrderItem](#schema-orderitem) | ✓ |  |
| subscription | [Subscription](#schema-subscription) |  |  |
| createdAt | string (date-time) |  | Abonelik nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Abonelik nesnesinin güncellenme zamanı. |

---

<h3 id='schema-productcountdown'>ProductCountDown</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün geri sayım bağı nesnesi kimlik değeri. |
| startDate | string (date-time) |  | Geri sayımın başlangıç tarihi. |
| endDate | string (date-time) |  | Geri sayımın bitiş tarihi. |
| expireDate | string (date-time) |  | Geri sayımın ürün için geçersiz olma tarihi. |
| useCountDown | integer | ✓ | Geri sayımın aktiflik durumu bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-smsconfig'>SmsConfig</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| orderReceived | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| orderApproved | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| orderCancelled | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| orderRefunded | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| orderWaitingPrepare | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| orderWaitingPayment | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| shipmentSent | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| shipmentReceived | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| personalOrderStatus1 | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| personalOrderStatus2 | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| personalOrderStatus3 | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-appsettingpref'>AppSettingPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| appId | string | ✓ |  |
| appScope | object | ✓ |  |

---

<h3 id='schema-towngroup'>TownGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | İlçe grubu nesnesi kimlik değeri. |
| name | string | ✓ | İlçe grubu nesnesi için isim değeri. |
| status | integer | ✓ | İlçe grubunun aktiflik bilgisini içerir.<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-poscampaignproduct'>PosCampaignProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| posCampaign | [PosCampaign](#schema-poscampaign) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-adjacentinterface'>AdjacentInterface</h3>


---

<h3 id='schema-coupon'>Coupon</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Hediye çeki nesnesi kimlik değeri. |
| code | string | ✓ | Hediye çeki nesnesi çek kodu. Minimum 4 maksimum 50 karakter. |
| currentUsage | integer |  | Hediye çeki nesnesi anlık kullanım sayısı |
| maxUsage | integer |  | Hediye çeki kullanım Limiti |
| maxUsagePerMember | integer |  | Hediye çeki kişi Başı Limiti |
| startDate | string (date-time) |  | Hediye çeki Başlangıç Tarihi |
| endDate | string (date-time) |  | Hediye çeki Bitiş Tarihi |
| creator | [Creator](#schema-creator) |  |  |
| minimumCheckoutLimit | number (float) | ✓ | Hediye çeki alışveriş sınırı |
| minimumCheckoutLimitTaxIncluded | integer | ✓ | Hediye çeki alışveriş sınırı vergi durumu<br>İzin verilen değerler: `0`, `1` |
| discountType | string | ✓ | Hediye çeki nesnesi indirim tipi.<br>İzin verilen değerler: `fixed`, `percentage` |
| discountValue | number (float) | ✓ | Hediye çeki nesnesi indirim miktarı. |
| discountTaxIncluded | integer | ✓ | Hediye çeki nesnesi indirip miktarı.<br>İzin verilen değerler: `0`, `1` |
| filterType | string | ✓ | Hediye çeki nesnesi indirime dahil alanlar tipi.<br>İzin verilen değerler: `all`, `product`, `category`, `brand`, `member` |
| products | array[[Product](#schema-product)] |  | Ürün nesnesi |
| categories | array[[Category](#schema-category)] |  | Kategori nesnesi |
| brands | array[[Brand](#schema-brand)] |  | Marka nesnesi |
| members | array[[Member](#schema-member)] |  | Üye nesnesi |
| memberGroup | [MemberGroup](#schema-membergroup) |  |  |
| status | integer | ✓ | Hediye çeki nesnesi aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| cargoFree | integer | ✓ | Hediye çeki nesnesi ücretsiz kargo durumu<br>İzin verilen değerler: `0`, `1` |
| useDiscountedProducts | integer | ✓ | Hediye çeki nesnesi indirimli ürünlerde geçerlilik durumu<br>İzin verilen değerler: `0`, `1` |
| filterValidityType | integer | ✓ | Hediye çeki nesnesi geçerililik durumu<br>İzin verilen değerler: `0`, `1` |
| couponWithoutMembership | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Hediye çeki nesnesi oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Hediye çeki nesnesi  güncellenme zamanı. |

---

<h3 id='schema-userrole'>UserRole</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kullanıcı rolü nesnesi kimlik değeri. |
| name | string | ✓ | Rol Adı |
| predefined | integer |  | Değiştirilemez kulanıcı rolü durumu.<br>İzin verilen değerler: `0`, `1` |
| permissions | array[[UserRolePermission](#schema-userrolepermission)] |  | izinler |
| userCount | integer |  | Role sahip kullanıcı sayısı |
| createdAt | string (date-time) |  | Ürün nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Ürün nesnesinin güncellenme zamanı. |

---

<h3 id='schema-notification'>Notification</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| context | string | ✓ | context |
| contextId | integer | ✓ | contextId |
| messageTitle | string |  | messageTitle |
| messageContent | string |  | messageContent |
| event | string | ✓ | event |
| notifiedUsers | array[[NotifiedUser](#schema-notifieduser)] | ✓ | notifiedUsers |
| createdAt | string (date-time) |  |  nesnesi oluşturulma zamanı. |
| updatedAt | string (date-time) |  |  nesnesi güncellenme zamanı. |

---

<h3 id='schema-productcustomizationfieldsetting'>ProductCustomizationFieldSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün özelleştirme alanı ayarları nesnesi kimlik değeri. |
| varKey | string | ✓ | Ürün özelleştirme alanı ayarları seçeneği<br>İzin verilen değerler: `attributes`, `min_length`, `max_length` |
| varValue | string |  | Ürün özelleştirme alanı ayarları seçeneği değeri |
| productCustomizationField | [ProductCustomizationField](#schema-productcustomizationfield) | ✓ |  |

---

<h3 id='schema-productspecialinfo'>ProductSpecialInfo</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Özel bilgi alanı nesnesi kimlik değeri. |
| title | string | ✓ | Özel bilgi alanı başlığı. |
| content | string | ✓ | Özel bilgi alanı içeriği. |
| status | integer | ✓ | Özel bilgi alanı aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-extrainstallment'>ExtraInstallment</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ekstra taksit seçeneği nesnesi kimlik değeri. |
| minLimit | number (float) | ✓ | Taksit seçeneklerinin aktif olduğu minimum fiyat limit |
| rangeStart | integer | ✓ | Taksit sayısı aralığı alt değer |
| rangeEnd | integer | ✓ | Taksit sayısı aralığı üst değer |
| installment | integer | ✓ | Artı taksit seçeneği. (Bankaların belirli dönemlerde düzenlediği artı vade seçeneği. Banka ile görüşmeden kullanılması durumunda artı taksit ekstrelere yansımayacaktır) |
| paymentGateway | [PaymentGateway](#schema-paymentgateway) |  |  |

---

<h3 id='schema-form'>Form</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Form nesnesi kimlik değeri |
| formKey | string |  |  |
| name | string | ✓ | Form nesnesi ismi |
| fields | array[[FormField](#schema-formfield)] | ✓ | Form alanları |
| info | string |  |  |
| status | integer | ✓ | Form aktifliği<br>İzin verilen değerler: `0`, `1` |
| blockStatus | integer | ✓ | Blok Durumu<br>İzin verilen değerler: `0`, `1` |
| language | string | ✓ |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-shippingcompany'>ShippingCompany</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Kargo firması nesnesi kimlik değeri. |
| name | string | ✓ | Kargo firması nesnesi için isim değeri. |
| status | string | ✓ | Kargo firması nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `active`, `passive` |
| extraPrice | number (float) |  | Kargo firması için sabit ücret. Sabit bir kargo ücreti uygulayacaksanız her sipariş için sabit kargo ücreti girebilirsiniz. Desi bilgilerini kaydetmeniz durumunda desi toplamlarının üzerine sabit ücret eklenecektir. |
| extraVolumetricWeightPrice | number (float) |  | Kargo firması için girmiş olduğunuz desi bilgileri 50 Desiye kadar girilebilmektedir. 50'nin üzeri veya girmiş olduğunuz desi miktarının üzerine her +1 desi için eklenecek olan kargo ücreti. |
| freeShipmentOrderPrice | number (float) |  | Alışveriş sepeti toplamı belirlediğiniz Ücretsiz kargo limitini geçtiğinde müşterileriniz ücretsiz kargo hizmetinden faydalanabilirler.(Örn: X Lira üzeri ücretsiz Kargo!) |
| freeShipmentVolumetricWeightLimit | number (float) |  | Ücretsiz kargo miktarı için maksimum ücretsiz desi miktarıdır. Alışveriş sırasındaki desi miktarı ücretsiz desi miktarından fazlaysa, + Desi miktarını sipariş sırasında sistem müşteriden tahsil eder.(Örn: X TL üzeri ücretsiz kargo! Fakat X desiye kadar)Üzeri müşteriden tahsil edilir. |
| sortOrder | integer |  | Kargo firması nesnesi için sıralama değeri. |
| paymentType | string |  | Kargo firması için ödeme tipi.<br>İzin verilen değerler: `cash_on_delivery`, `standart_delivery`, `not_applicable` |
| companyCode | string |  | API tarafından otomatik oluşturulan kargo firması kodu. |
| shippingProvider | [ShippingProvider](#schema-shippingprovider) | ✓ |  |
| countries | array[[Country](#schema-country)] |  | Ülkeler nesnesi listesi |
| createdAt | string (date-time) |  | Kargo firması nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Kargo firması nesnesinin güncellenme zamanı. |

---

<h3 id='schema-extrapref'>ExtraPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| useBrandSystem | integer |  | Marka Sistemi Kullanımı:<br>İzin verilen değerler: `0`, `1` |
| usePriceSystem | integer |  | Fiyatları Göster. (Üye girişe yapmayanlar için fiyatların görünme durumu)<br>İzin verilen değerler: `0`, `1` |
| useCreditcardSystem | integer |  | Kredi Kartı Modülünü Kullan<br>İzin verilen değerler: `0`, `1` |
| useMailorderSystem | integer |  | Mail Order Sistemini Kullan<br>İzin verilen değerler: `0`, `1` |
| useOrderGiftNote | integer |  | Hediye Notu Seçeneği<br>İzin verilen değerler: `0`, `1` |
| useShippingSystem | integer | ✓ | Kargo Sistemi Kullan<br>İzin verilen değerler: `0`, `1` |
| defaultTaxRate | number (float) |  | Varsayılan KDV Oranı |
| productGroupMenuType | string |  | Ürün grubu menüsü tipi<br>İzin verilen değerler: `right_expand_menu`, `right_expand_menu_with_image`, `collapsable_menu`, `standart_menu`, `accordion_menu`, `two_collapsable_menu` |
| usePaymentAgreement | integer | ✓ | Satış Sözleşmesi Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useBanktransferSystem | integer |  | Havale ile Ödeme Sistemini Kullan<br>İzin verilen değerler: `0`, `1` |
| useExtraRate | integer |  | + Taksit Seçeneğini Kullan<br>İzin verilen değerler: `0`, `1` |
| approveOfflinePayments | integer |  | Sipariş Sistemi Onay Durumu<br>İzin verilen değerler: `0`, `1` |
| displayNostockProduct | integer |  | Stokta Olmayan Ürünlerin Gösterimi<br>İzin verilen değerler: `0`, `1` |
| displayNostockProductView | integer |  | Stokta Olmayan Ürünlerin URL den Gösterimi. Stoksuz ürünlerin gösterimi kapalıyken stosuz ürünleri vitrinde gösteme yada sadece URL üzerindne gidildiğinde gösterme ayarı<br>İzin verilen değerler: `0`, `1` |
| defaultImageSizeOnShowcase | integer |  | Vitrindeki Ürün Resim Boyutları<br>İzin verilen değerler: `120`, `180`, `240`, `300`, `360`, `480`, `600`, `960` |
| productRecordPerPage | integer |  | Her Sayfadaki Ürün Adedi |
| useTabMidblockSystem | integer |  | Vitrin bloklarının tablı olarak kullanılması<br>İzin verilen değerler: `0`, `1` |
| usePointSystem | integer |  | Puan Sistemi Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useInvitationSystem | integer |  | Davet Sistemi Kullanımı<br>İzin verilen değerler: `0`, `1` |
| usePromotionSystem | integer |  | Promosyon Sisteminin Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useTokenSystem | integer |  | Hediye Çeki Kullanımı<br>İzin verilen değerler: `0`, `1` |
| siteStatus | string |  | Site Durumu<br>İzin verilen değerler: `active`, `under_construction` |
| orderWithoutRegistration | integer |  | Üyeliksiz Alışveriş<br>İzin verilen değerler: `0`, `1` |
| memberActivationSystemType | string |  | Aktivasyon Sistemi Kullan<br>İzin verilen değerler: `closed`, `individual`, `admin` |
| memberSignup | integer |  | Yeni Üyelik<br>İzin verilen değerler: `0`, `1` |
| defaultStatusOfProductComment | integer |  | Varsayılan Ürün Yorumu Durumu<br>İzin verilen değerler: `0`, `1` |
| identityNumberRequiredInOrder | integer |  | Tc Kimlik Numarasının Siparişte Gerekliliği<br>İzin verilen değerler: `0`, `1` |
| usePaymentSystem | integer |  | Ödeme Sistemi<br>İzin verilen değerler: `0`, `1` |
| filterMenuDelay | integer |  | Filtre Seçim Gecikmesi<br>İzin verilen değerler: `0`, `1`, `2`, `3` |
| useFilterBlockMenu | integer |  | Filtre Bloğu Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useProductAttributeSystem | integer |  | Ürün Özelliklerinin Kullanımı<br>İzin verilen değerler: `0`, `1` |
| showcaseType | integer |  | Vitrin Görünümü Tipi<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5`, `6` |
| usePrivateShoppingSystem | integer |  | Zorunlu Üyelik Sistemi. Aktif durumda sadece üyeler giriş yaparak sitede gezebilir.<br>İzin verilen değerler: `0`, `1` |
| useSeoTagsSystem | integer |  | SEO+ Etiket Sistemi.<br>İzin verilen değerler: `0`, `1` |
| useCargoTrackingSystem | integer |  | Kargo Takip Modülü<br>İzin verilen değerler: `0`, `1` |
| minimumOrderAmount | number (float) |  | Minimum Sipariş Tutarı |
| minimumOrderAmountTaxStatus | integer |  | Minimum Sipariş Tutarı vergi durumu<br>İzin verilen değerler: `0`, `1` |
| defaultTaxTypeStatus | integer |  | <br>İzin verilen değerler: `0`, `1` |
| criticalStock | [CriticalStock](#schema-criticalstock) |  |  |
| useProductImageOptimization | integer |  | Resim Optimizasyonu<br>İzin verilen değerler: `0`, `1` |
| useCurrencyAutoUpdateSystem | integer |  | Otomatik Kur Güncelleme Servisi<br>İzin verilen değerler: `0`, `1` |
| mainCurrency | [Currency](#schema-currency) | ✓ |  |
| useOfferedProduct | integer |  | Tavsiye Ürünlerin Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useMaximumInstallment | integer |  | Taksit Sınırı Kullanımı. Ürün ve kategori bazlı taksit sınırlaması yapılabilmesini sağlar.<br>İzin verilen değerler: `0`, `1` |
| usePriceDiscountNotificationSystem | integer |  | Fiyatı düşünce haber ver butonun gösterimi<br>İzin verilen değerler: `0`, `1` |
| useOrderImage | integer |  | Sipariş Resmi Kullanımı<br>İzin verilen değerler: `0`, `1` |
| orderRefund | [OrderRefund](#schema-orderrefund) | ✓ |  |
| mobileView | string |  | Mobil Site Kullanımı<br>İzin verilen değerler: `closed`, `phone`, `phone_and_tablet` |
| displayNoImagesProductOnShowcase | integer |  | Resimsiz ürünlerin vitrinde en sonda görüntülenmesi<br>İzin verilen değerler: `0`, `1` |
| filterMenuViewType | string |  | Filtre Menü Kullanım Tipi<br>İzin verilen değerler: `vertical`, `horizontal` |
| watermark | [Watermark](#schema-watermark) |  |  |
| abandonedCart | [AbandonedCart](#schema-abandonedcart) |  |  |
| whatsapp | [Whatsapp](#schema-whatsapp) |  |  |
| facebookMessenger | [FacebookMessenger](#schema-facebookmessenger) |  |  |
| variantDisplayTypeOnShowcase | integer |  | Vitrinde Varyant Gösterim Tipi<br>İzin verilen değerler: `0`, `1`, `2` |
| useCommentExtraDetail | integer |  | Yorumlarda detaylı bilgi alanının zorunluluğu<br>İzin verilen değerler: `0`, `1`, `2` |
| variantCommentsType | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useZipCode | integer |  | Posta Kodu Kullanımı<br>İzin verilen değerler: `0`, `1` |
| useZipCodeRequired | integer |  | Posta Kodu zorunlu olsun<br>İzin verilen değerler: `0`, `1` |
| mercanSuperApp | [MercanSuperApp](#schema-mercansuperapp) |  |  |
| useProductImageForOption | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useDatalayer | integer |  | Datalayer(Veri katmanı)<br>İzin verilen değerler: `0`, `1` |
| defaultStatusOfShoppingExperience | integer |  | Varsayılan Alışveriş Deneyimi Durumu<br>İzin verilen değerler: `0`, `1` |
| memberSuspendAndDelete | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useRedirectLoginPage | integer |  | Üye Giriş Sayfasına Yönlendirme<br>İzin verilen değerler: `0`, `1` |
| excludeTaxAbroad | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useGender | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useGenderRequired | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useRepeatPassword | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useRepeatPasswordRequired | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useKvkk | integer |  | Kişisel Verilerin Korunması Kanunu kullanımı<br>İzin verilen değerler: `0`, `1` |
| useKvkkRequired | integer |  | <br>İzin verilen değerler: `0`, `1` |
| memberSignupBirthdayField | integer |  | Doğum Tarihi Gerekliliği. (Yeni üyelik alanında doğum tarihi alanı aktif hale gelir)<br>İzin verilen değerler: `0`, `1` |
| memberSignupBirthdayFieldRequired | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useTicketSystem | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useCellPhone | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useCellPhoneRequired | integer |  | <br>İzin verilen değerler: `0`, `1` |
| useFeedingVariantImage | integer |  | <br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-membergroupemail'>MemberGroupEmail</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Üye grubu E-maili nesnesi kimlik değeri |
| mailExtension | string | ✓ | E-mail uzantısı |
| memberGroup | [MemberGroup](#schema-membergroup) | ✓ |  |
| createdAt | string (date-time) |  | Üye grubu E-maili nesnesi oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Üye grubu E-maili nesnesi güncellenme zamanı. |

---

<h3 id='schema-tabbedmidblock'>TabbedMidblock</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Tablı vitrin blokları nesnesi kimlik değeri. |
| name | string | ✓ | Blok Adı. |
| status | integer | ✓ | Tablı vitrin bloğu aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ | Sıra No |
| productCountPerRow | integer | ✓ | Satırdaki Ürün Sayısı<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |
| rowCountPerPage | integer | ✓ | Satır Sayısı<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |

---

<h3 id='schema-paymentprovider'>PaymentProvider</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme altyapısı sağlayıcısı nesnesi kimlik değeri. |
| code | string |  | Ödeme altyapısı sağlayıcısı için ön tanımlanmış kod değeri. |
| name | string |  | Ödeme altyapısı sağlayıcısı için isim değeri. |
| status | integer | ✓ | Ödeme altyapısı sağlayıcısının aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| settings | array[[PaymentProviderSetting](#schema-paymentprovidersetting)] |  | Ödeme altyapısı sağlayıcısı ayarı listesi |
| paymentType | [PaymentType](#schema-paymenttype) |  |  |

---

<h3 id='schema-formoption'>FormOption</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| name | string | ✓ | Form alanı seçeneği kimlik değeri. |
| value | string |  | Form alanı seçeneği değeri. |
| marked | integer | ✓ | Form alanı işaretlenme durumu.<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-promotionbar'>PromotionBar</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Promosyon barı nesnesi kimlik değeri. |
| title | string | ✓ | Bar Adı. |
| content | string | ✓ | İçerik. |
| status | integer | ✓ | Bar durumu.<br>İzin verilen değerler: `0`, `1` |
| closeButton | integer |  | Kapat Butonu<br>İzin verilen değerler: `0`, `1` |
| position | string |  | Bar konum.<br>İzin verilen değerler: `top`, `bottom` |
| isStatic | integer |  | Bar.<br>İzin verilen değerler: `0`, `1` |
| backgroundColor | string | ✓ | Arka Plan Rengi. |
| frameColor | string |  | Çerçeve Rengi. |
| frameSize | integer |  | Çerçeve Kalınlığı. Pixel değeri girilmeli. |
| displayHomepage | integer |  | Anasayfada görünme.<br>İzin verilen değerler: `0`, `1` |
| displayProductPage | integer |  | Ürün sayfalarında görünme.<br>İzin verilen değerler: `0`, `1` |
| displayCategoryPage | integer |  | Kategori sayfalarında görünme.<br>İzin verilen değerler: `0`, `1` |
| categories | array[[Category](#schema-category)] |  | Kategori nesnesi. |
| createdAt | string (date-time) |  | Promosyon barı nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Promosyon barı nesnesinin güncellenme zamanı. |

---

<h3 id='schema-activecart'>ActiveCart</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| cart | [Cart](#schema-cart) |  |  |
| preOrderInfo | [PreOrderInfo](#schema-preorderinfo) |  |  |
| member | [Member](#schema-member) |  |  |
| customerFirstname | string | ✓ |  |
| customerSurname | string | ✓ |  |
| customerEmail | string | ✓ |  |
| state | string | ✓ |  |
| priceWithTax | number (float) | ✓ |  |
| updatedAt | string (date-time) |  |  |

---

<h3 id='schema-promotionpricerange'>PromotionPriceRange</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| fromQty | integer |  | Başlangıç adeti |
| toQty | integer |  | Bitiş adeti (Bitiş adeti başlangıç adetinden küçük eşit olamaz.) |
| discountAmount | integer |  | İndirim miktarı |
| createdAt | string (date-time) |  | Promosyon fiyat aralığı nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Promosyon fiyat aralığı nesnesinin güncellenme zamanı. |

---

<h3 id='schema-poscampaign'>PosCampaign</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | id |
| name | string | ✓ | name |
| posAccount | [PosAccount](#schema-posaccount) | ✓ |  |
| installmentRates | array[[InstallmentRate](#schema-installmentrate)] | ✓ | installmentRates |
| status | integer | ✓ | status<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-shippingprovidersetting'>ShippingProviderSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Teslimat hizmeti sağlayıcısı ayarı nesnesi kimlik değeri. |
| varKey | string | ✓ | Teslimat hizmeti sağlayıcısı ayarı nesnesi için değişken anahtarı. |
| varValue | string | ✓ | Teslimat hizmeti sağlayıcısı ayarı nesnesi için değişken değeri. |
| shippingProvider | [ShippingProvider](#schema-shippingprovider) | ✓ |  |

---

<h3 id='schema-shippingrate'>ShippingRate</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kargo oranı nesnesi kimlik değeri. |
| volumetricWeightStart | integer | ✓ | İlgili kargo firması, ilgili bölge ve ilgili orana ait minimum desi değeri. |
| volumetricWeightEnd | integer | ✓ | İlgili kargo firması, ilgili bölge ve ilgili orana ait maximum desi değeri. |
| rate | number (float) | ✓ | Seçili bölge ve kargo firması için kargo oranı. |
| region | [Region](#schema-region) | ✓ |  |
| shippingCompany | [ShippingCompany](#schema-shippingcompany) | ✓ |  |

---

<h3 id='schema-page'>Page</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Sayfa nesnesi kimlik değeri |
| type | string | ✓ | Sayfa nesnesi türü<br>İzin verilen değerler: `page`, `article` |
| title | string | ✓ | Başlık |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| scoop | string |  |  |
| content | string | ✓ | İçerik |
| status | integer | ✓ | Sayfa aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| blockStatus | integer | ✓ | Sayfa blok durumu<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ | Sıra No |
| pageTitle | string |  | Sayfa başlığı |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir. |
| seoSetting | [SeoSetting](#schema-seosetting) |  |  |
| updatedAt | string (date-time) |  | Sayfa nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  | Sayfa nesnesi oluşturulma zamanı. |

---

<h3 id='schema-mailcontent'>MailContent</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| content | string |  | Mail Şablonu içeriği |
| isCustomized | integer |  | Mail Şablonu kişiselleştirilme durumu<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-productpricewarning'>ProductPriceWarning</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün fiyat bildirim sistemi nesnesi kimlik değeri. |
| member | [Member](#schema-member) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |
| price | number (float) | ✓ | price |
| priceIndex | integer | ✓ | Ürünün tanımlı fiyat indeksi<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |
| updatedAt | string (date-time) |  | Ürün fiyat bildirim sistemi nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Ürün fiyat bildirim sistemi nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-blogcommentpref'>BlogCommentPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer | ✓ | Blog Yorum Ayarı nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| appId | string |  | appId |

---

<h3 id='schema-bank'>Bank</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Banka nesnesi kimlik değeri. |
| name | string | ✓ | Banka nesnesi için isim değeri. |

---

<h3 id='schema-paymentproxysetting'>PaymentProxySetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme proxy ayarı nesnesi kimlik değeri. |
| varKey | string |  | Ödeme proxy ayarı nesnesi için değişken anahtarı. |
| varValue | string | ✓ | Ödeme proxy ayarı nesnesi için değişken değeri. |
| paymentProxy | [PaymentProxy](#schema-paymentproxy) |  |  |

---

<h3 id='schema-selectiongroup'>SelectionGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ek özellik grubu nesnesi kimlik değeri. |
| title | string | ✓ | Ek özellik grubu ismi. |
| sortOrder | integer |  | Ek özellik grubu sırası. |
| selections | array[[Selection](#schema-selection)] | ✓ | Ek özellik nesnesi. |

---

<h3 id='schema-admin-model-abandonedcart'>Admin-Model-AbandonedCart</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| cart | [Cart](#schema-cart) |  |  |
| sessionId | string | ✓ |  |
| mailStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| member | [Member](#schema-member) | ✓ |  |
| priceWithTax | number (float) | ✓ |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-categorymapping'>CategoryMapping</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| sourceCategory | [Category](#schema-category) | ✓ |  |
| type | string | ✓ | <br>İzin verilen değerler: `fibabanka`, `payWithIyzico`, `toslaIsimShoppingLoan` |
| targetCategoryId | string | ✓ |  |
| targetCategoryPath | string |  |  |

---

<h3 id='schema-themeextrapref'>ThemeExtraPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| designEdit | integer | ✓ | designEdit<br>İzin verilen değerler: `0`, `1` |
| usePrivateShoppingSystem | integer | ✓ | usePrivateShoppingSystem<br>İzin verilen değerler: `0`, `1` |
| useProductAttributeSystem | integer | ✓ | useProductAttributeSystem<br>İzin verilen değerler: `0`, `1` |
| useProductShortDetails | integer | ✓ | useProductShortDetails<br>İzin verilen değerler: `0`, `1` |
| useDropdownMenuSystem | integer | ✓ | useDropdownMenuSystem<br>İzin verilen değerler: `0`, `1` |
| useHomepageSearchTripleBlock | integer | ✓ | useHomepageSearchTripleBlock<br>İzin verilen değerler: `0`, `1` |
| useBannerSystem | integer | ✓ | useBannerSystem<br>İzin verilen değerler: `0`, `1` |
| useCountdownSystem | integer | ✓ | useCountdownSystem<br>İzin verilen değerler: `0`, `1` |
| useSubMenuItemSystem | integer | ✓ | useSubMenuItemSystem<br>İzin verilen değerler: `0`, `1` |
| useProductExtraField | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| useElasticSearch | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| useShipmentPref | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| useProductSearchPhrase | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-analytics'>Analytics</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| accessToken | string |  | accessToken |
| managementAccount | [ManagementAccount](#schema-managementaccount) | ✓ |  |
| webProperty | [WebProperty](#schema-webproperty) | ✓ |  |

---

<h3 id='schema-pollanswer'>PollAnswer</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Anket cevabı nesnesi |
| name | string | ✓ | Anket cevabı ismi |
| vote | integer |  | Oy sayısı |
| sortOrder | integer |  | Sıra no |
| pollQuestion | [Poll](#schema-poll) | ✓ |  |

---

<h3 id='schema-language'>Language</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| key | string | ✓ | Dil değişkeni alanı |
| value | string | ✓ | Dil değişkeni tanımlanan değeri |
| originalValue | string |  | Dil değişkeni orijinal değeri |

---

<h3 id='schema-slideritem'>SliderItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| index | integer |  | Slider kalemi indeksi. |
| link | string |  | Yönlendirme Linki. |
| sortOrder | integer |  | Slider kalemi sırası. |
| targetBlankStatus | integer |  | Slider kalemi yeni sayfada açılma durumu.<br>İzin verilen değerler: `0`, `1` |
| status | integer |  | Slider kalemi aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| imageUrl | string |  | Slider kalemi imajı. |
| attachment | string |  | Slider kalemi eklenti dosyası. |
| description | string |  | Slider kalemi açıklaması. |

---

<h3 id='schema-customizationfield'>CustomizationField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Özel Form Alanı nesnesi kimlik değeri. |
| name | string | ✓ | Özel Form Alanı nesnesi için isim değeri. |
| sortOrder | integer |  | Özel Form Alanı nesnesi için sıralama değeri. |
| isRequired | integer | ✓ | Bu alan zorunlu olsun mu<br>İzin verilen değerler: `0`, `1` |
| type | string | ✓ | Form alanı tipi<br>İzin verilen değerler: `checkbox`, `dropdown`, `file`, `radio`, `textarea`, `textbox` |
| placeHolder | string |  | Yer tutucu |
| info | string |  | Bilgi alanı |
| customizationGroup | [CustomizationGroup](#schema-customizationgroup) | ✓ |  |
| options | array[[CustomizationFieldOption](#schema-customizationfieldoption)] |  | Özel Form Alanı Seçenekleri nesneleri listesi |
| settings | array[[CustomizationFieldSetting](#schema-customizationfieldsetting)] |  | Özel Form Alanı Ayar nesneleri listesi |
| updatedAt | string (date-time) |  | Özel Form Alanı nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Özel Form Alanı nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-customizationfieldsetting'>CustomizationFieldSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Özel Form Alanı Ayar nesneleri listesi |
| varKey | string | ✓ | varKey<br>İzin verilen değerler: `attributes`, `min_length`, `max_length` |
| varValue | string |  | Nitelik değeri |
| customizationField | [CustomizationField](#schema-customizationfield) | ✓ |  |

---

<h3 id='schema-preorderinfo'>PreOrderInfo</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş öncesi bilgisi nesnesi kimlik değeri. |
| sessionId | string | ✓ | Üyenin son giriş yapma durumunu belirten benzersiz kimlik değeri. |
| customerFirstname | string |  | Müşterinin ismi. |
| customerSurname | string |  | Müşterinin soy ismi. |
| customerEmail | string | ✓ | Müşterinin e-mail adresi. |
| shippingAddressName | string | ✓ |  |
| shippingFirstname | string | ✓ | Teslimat yapılacak kişinin ismi. |
| shippingSurname | string | ✓ | Teslimat yapılacak kişinin soy ismi. |
| shippingAddress | string | ✓ | Teslimat adresi bilgileri. |
| shippingPhoneNumber | string |  | Teslimat yapılacak kişinin telefon numarası. |
| shippingMobilePhoneNumber | string | ✓ | Teslimat yapılacak kişinin mobil telefon numarası. |
| shippingLocationName | string | ✓ | Teslimat şehri. |
| shippingTown | string | ✓ | Teslimat ilçesi. |
| shippingIdentityRegistrationNumber | string |  |  |
| shippingZipCode | string |  |  |
| differentBillingAddress | integer |  | Teslimat adresinden farklı bir fatura adresi olup olmadığını belirten değer.<br>İzin verilen değerler: `0`, `1` |
| billingAddressName | string | ✓ |  |
| billingFirstname | string | ✓ | Fatura kesilen kişinin ismi. |
| billingSurname | string | ✓ | Fatura kesilen kişinin soy ismi. |
| billingAddress | string | ✓ | Fatura adresi bilgileri. |
| billingPhoneNumber | string |  | Fatura kesilen kişinin telefon numarası. |
| billingMobilePhoneNumber | string | ✓ | Fatura kesilen kişinin mobil telefon numarası. |
| billingLocationName | string | ✓ | Fatura adresi şehri |
| billingTown | string | ✓ | Fatura adresi ilçesi. |
| billingInvoiceType | string | ✓ | Fatura tipini belirtir.<br>İzin verilen değerler: `individual`, `corporate` |
| billingIdentityRegistrationNumber | string |  | Fatura kesilen kişinin TC kimlik numarası. |
| billingTaxOffice | string |  | Fatura kesilen kişi/kurumun vergi dairesi. |
| billingTaxNo | string |  | Fatura kesilen kişi/kurum vergi numarası. |
| billingZipCode | string |  |  |
| isEinvoiceUser | integer |  | Yöneticinin(admin) e-fatura kullanıp kullanmadığı bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| useGiftPackage | integer |  | Müşterinin hediye paketi isteyip istemediği bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| giftNote | string |  | Hediye notu bilgisi. |
| imageFile | string |  | Sipariş öncesi bilgisi nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .jpg, .jpeg, .png, .gif |
| deliveryDate | string (date-time) |  | Müşterinin teslimatın gerçekleşmisini istediği tarih. |
| deliveryTime | string |  | API bu değeri otomatik oluşturur. |
| createdAt | string (date-time) |  | Sipariş öncesi bilgisi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Sipariş öncesi bilgisi nesnesinin güncellenme zamanı. |
| billingCountry | [Country](#schema-country) | ✓ |  |
| billingLocation | [Location](#schema-location) |  |  |
| shippingCompany | [ShippingCompany](#schema-shippingcompany) |  |  |
| shippingCountry | [Country](#schema-country) | ✓ |  |
| shippingLocation | [Location](#schema-location) |  |  |
| memberShippingAddress | [MemberAddress](#schema-memberaddress) |  |  |
| memberBillingAddress | [MemberAddress](#schema-memberaddress) |  |  |

---

<h3 id='schema-currency'>Currency</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Kur nesnesi kimlik değeri. |
| label | string |  | Kur etiketi. |
| abbr | string |  | Kurun kısaltması. |
| buyingPrice | number (float) |  | Kurun alış fiyatı. |
| sellingPrice | number (float) |  | Kurun satış fiyatı. |
| status | integer | ✓ | Kur nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| permissionStatus | integer | ✓ | Kur nesnesinin kullanım izni durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| isPrimary | integer | ✓ | Kurun birincil kur olup olmadığı bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| isEffective | integer | ✓ | Kur nesnesinin efektif kur olarak kullanım durumu<br>İzin verilen değerler: `0`, `1` |
| updatedAt | string (date-time) |  | Kur nesnesinin güncellenme zamanı. |

---

<h3 id='schema-productextrainfo'>ProductExtraInfo</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün ekstra bilgi nesnesi |
| value | string | ✓ | Ekstra bilgi değeri |
| extraInfo | [ExtraInfo](#schema-extrainfo) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-slidersetting'>SliderSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| sliderEffect | string | ✓ | Slide Tipi.<br>İzin verilen değerler: `slide`, `fade` |
| sliderWidth | number (float) | ✓ | Slider Genişliği. |
| sliderHeight | number (float) | ✓ | Slider Yüksekliği. |
| autoStartTime | number (float) | ✓ |  Resimlerin Değişme Süresi. Milisaniye cinsinden. |
| effectTime | number (float) | ✓ |  Resmin Görüntülenme Süresi. |
| autoStart | integer | ✓ | Otomatik başlatma durumu.<br>İzin verilen değerler: `0`, `1` |
| definition | integer | ✓ | Açıklama alanı gösterilsin.<br>İzin verilen değerler: `0`, `1` |
| definitionEffectTime | number (float) | ✓ | Açıklama Alanının Oluşturulma Süresi. |
| definitionVerticalPosition | string | ✓ | Açıklama Alanının Dikeydeki Gösterimi.<br>İzin verilen değerler: `top`, `bottom` |
| definitionHorizontalPosition | string | ✓ | Açıklama Alanının Yatayda Gösterimi.<br>İzin verilen değerler: `left`, `right` |
| definitionVerticalSpace | integer | ✓ |  Açıklama Alanının Dikey Kenar Boşluğu.<br>İzin verilen değerler: `5`, `10`, `15`, `20`, `25`, `30` |
| definitionHorizontalSpace | integer | ✓ |  Açıklama Alanının Yatay Kenar Boşluğu.<br>İzin verilen değerler: `5`, `10`, `15`, `20`, `25`, `30` |
| definitionFontFamilySelect | string | ✓ | Açıklama Yazı Karakteri.<br>İzin verilen değerler: `arial`, `tahoma`, `verdana`, `georgia`, `trebuchet`, `courier`, `timesnewroman` |
| definitionFontColorSelect | string | ✓ | Açıklama Yazı Rengi.<br>İzin verilen değerler: `white`, `black`, `red`, `green`, `blue`, `purple`, `yellow`, `silver`, `orange`, `brown`, `cyan` |
| definitionFontFamilySize | integer | ✓ | Açıklama Yazı Fontu. |
| definitionBackgroundColor | string | ✓ | Açıklama Yazı Arkaplan Rengi. |
| showButton | integer | ✓ | İleri-Geri butonları gösterilsin.<br>İzin verilen değerler: `0`, `1` |
| previousNextColor | string | ✓ | İleri-Geri Butonu Rengi. |
| previousNextSize | integer | ✓ |  İleri-Geri Butonu Büyüklüğü. (Piksel cinsiden) |
| previousNextOpacity | integer | ✓ |  İleri-Geri Butonu Şeffaflık Oranı. 1-100 atrası. |
| pagination | integer | ✓ | Slider altında geçiş butonları aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| bulletActiveFontColor | string | ✓ | Geçiş Butonları 'Aktif' Yazı Rengi. |
| bulletPassiveFontColor | string | ✓ | Geçiş Butonları 'Pasif' Yazı Rengi. |
| bulletActiveColor | string | ✓ | Geçiş Butonları 'Aktif' Arka Plan Rengi. |
| bulletPassiveColor | string | ✓ | Geçiş Butonları 'Pasif' Arka Plan Rengi. |
| paginationNumeric | integer | ✓ | Slider altında geçiş butonları numerik olsun mu?<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-paymentgatewaysetting'>PaymentGatewaySetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ödeme kanalı ayarı nesnesi kimlik değeri. |
| varKey | string | ✓ | Ödeme kanalı ayarı nesnesi için değişken anahtarı. |
| varValue | string | ✓ | Ödeme kanalı ayarı nesnesi için değişken değeri. |
| paymentGateway | [PaymentGateway](#schema-paymentgateway) | ✓ |  |

---

<h3 id='schema-location'>Location</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Şehir nesnesi kimlik değeri. |
| name | string |  | Şehir nesnesi için isim değeri. |
| status | integer | ✓ | Şehir nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| country | [Country](#schema-country) |  |  |
| region | [Region](#schema-region) | ✓ |  |

---

<h3 id='schema-processlog'>ProcessLog</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | İşlem Kayıtları nesnesi kimlik değeri |
| userId | integer | ✓ | İşlem yapan kullanıcı kimlik değeri |
| username | string | ✓ | İşlem yapan kullanıcı adı |
| ip | string | ✓ | İşlem yapılan IP |
| createdAt | string (date-time) |  | İşlem Kayıtları nesnesi oluşturulma zamanı. |
| recordId | integer | ✓ | Oluşturulan veya değiştirilen kolonun tablo id numarası |
| module | string | ✓ | İşlem yapılan modül |
| file | string | ✓ | İşlemin yapıldığı dosya ismi |
| act | string | ✓ | Yapılan işlem türü |
| tableName | string | ✓ | İşlem sonucu değişen tablonun adı |
| userType | string | ✓ | Kullanıcı tipi |
| functionName | string | ✓ | Loglanan işlemin tetiklendiği fonksiyon |
| moduleNameVerbose | string | ✓ | Ayrıntılı modül ismi |
| logSentence | string | ✓ | Log cümlesi |

---

<h3 id='schema-poscampaigncategory'>PosCampaignCategory</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| posCampaign | [PosCampaign](#schema-poscampaign) | ✓ |  |
| category | [Category](#schema-category) | ✓ |  |

---

<h3 id='schema-userrolepermission'>UserRolePermission</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kullanıcı rolü nesnesi kimlik değeri. |
| name | string | ✓ | Kullanıcı rolü nesnesi ismi. |
| createPermission | integer | ✓ | Oluşturma izni<br>İzin verilen değerler: `0`, `1` |
| readPermission | integer | ✓ | Okuma izni<br>İzin verilen değerler: `0`, `1` |
| updatePermission | integer | ✓ | Değiştirme izni<br>İzin verilen değerler: `0`, `1` |
| deletePermission | integer | ✓ | Silme izni<br>İzin verilen değerler: `0`, `1` |
| userRole | [UserRole](#schema-userrole) |  |  |
| createdAt | string (date-time) |  |  |
| updatedAt | string (date-time) |  | Ürün nesnesinin güncellenme zamanı. |

---

<h3 id='schema-dropdownpref'>DropdownPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer | ✓ | Aşağı Açılır Menü nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| categoryLimit | integer |  | Menüde Gösterilecek Kategori Sayısı |
| columnWidth | number (float) |  | Satırdaki Kolon Sayısının Toplam Genişliği |
| numberOfColumns | integer |  | Bir Satırda Gösterilecek Kolon Sayısı |
| leftMargin | integer |  | Kenar Boşluğu |
| menuEffect | string |  | Aşağı Açılır Menü eketi<br>İzin verilen değerler: `fade`, `show` |
| openingEffect | string |  | Aşağıya Açılış Efekti<br>İzin verilen değerler: `jswing`, `easeInQuad`, `easeOutQuad`, `easeInOutQuad`, `easeInCubic`, `easeOutCubic`, `easeInOutCubic`, `easeInQuart`, `easeOutQuart`, `easeInOutQuart`, `easeInSine`, `easeOutSine`, `easeInOutSine`, `easeInExpo`, `easeOutExpo`, `easeInOutExpo`, `easeInQuint`, `easeOutQuint`, `easeInOutQuint`, `easeInCirc`, `easeOutCirc`, `easeInOutCirc`, `easeInElastic`, `easeOutElastic`, `easeInOutElastic`, `easeInBack`, `easeOutBack`, `easeInOutBack`, `easeInBounce`, `easeOutBounce`, `easeInOutBounce`, `def` |
| closingEffect | string |  | Yukarı Kapanış Efekti<br>İzin verilen değerler: `jswing`, `easeInQuad`, `easeOutQuad`, `easeInOutQuad`, `easeInCubic`, `easeOutCubic`, `easeInOutCubic`, `easeInQuart`, `easeOutQuart`, `easeInOutQuart`, `easeInSine`, `easeOutSine`, `easeInOutSine`, `easeInExpo`, `easeOutExpo`, `easeInOutExpo`, `easeInQuint`, `easeOutQuint`, `easeInOutQuint`, `easeInCirc`, `easeOutCirc`, `easeInOutCirc`, `easeInElastic`, `easeOutElastic`, `easeInOutElastic`, `easeInBack`, `easeOutBack`, `easeInOutBack`, `easeInBounce`, `easeOutBounce`, `easeInOutBounce`, `def` |
| openingSpeed | number (float) |  | Açılış hızı |
| closingSpeed | number (float) |  | Kapanış hızı |
| useCategoryImage | integer |  | Kategori resmi aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| hideThirdLevelCategories | integer |  | 3.Seviye Kategorileri Göster<br>İzin verilen değerler: `0`, `1` |
| useThirdLevelCategoryLimit | integer |  | 3.Seviye Kategorileri Belirli Sayıda Göster<br>İzin verilen değerler: `0`, `1` |
| thirdLevelCategoryCount | integer |  | Gösterilecek 3.Seviye Kategori Sayısı |

---

<h3 id='schema-membergroup'>MemberGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Üye Grubu nesnesi kimlik değeri. |
| name | string | ✓ | Üye Grubu nesnesi için isim değeri. |
| priceIndex | integer | ✓ | Üye Grubunun fiyat indisi. Örnek Fiyat 2. |
| priceRatio | number (float) | ✓ |  |
| currentAccountStatus | integer |  | Hesap aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| ideapayStatus | integer |  | Ideapay aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| allowedPaymentTypes | object |  | Üye Grubunun izin verilmiş ödeme kanalları. |

---

<h3 id='schema-quickcart'>QuickCart</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Hızlı satın alma nesnesi kimlik değeri. |
| name | string | ✓ | Hızlı satın alma nesnesi ismi |
| url | string |  | Bağlantı Adı |
| products | object | ✓ | Ürünler listesi |
| updatedAt | string (date-time) |  | Hızlı satın alma nesnesi güncellenme zamanı. |
| createdAt | string (date-time) |  | Hızlı satın alma nesnesi oluşturulma zamanı. |

---

<h3 id='schema-merchantpollpref'>MerchantPollPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | string | ✓ | Merchant anketi seçenekleri nesnesi kimliği |
| status | integer | ✓ | Merchant anketi seçenekleri nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-productbutton'>ProductButton</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün ve stok butonu nesnesi kimlik değeri. |
| fastShipping | integer |  | Hızlı gönderi butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| sameDayShipping | integer |  | Aynı gün kargo butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| threeDaysDelivery | integer |  | 3 günde teslimat butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| fiveDaysDelivery | integer |  | 5 günde teslimat butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| sevenDaysDelivery | integer |  | 7 günde teslimat butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| freeShipping | integer |  | Kargo bedava butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| deliveryFromStock | integer |  | Stoktan teslim butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| preOrderedProduct | integer |  | Ön siparişli stok butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| limitedStock | integer |  | Sınırlı stok butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| askStock | integer |  | Stok sorunuz butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| campaignedProduct | integer |  | Kampanyalı stok butonu aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-shipmentpref'>ShipmentPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Teslimat nesnesi ayarı. |
| value | string |  | Teslimat nesnesi değeri. |

---

<h3 id='schema-orderitemcustomization'>OrderItemCustomization</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş kalemi özelleştirme kimlik değeri. |
| productCustomizationGroupId | integer |  | Ürün özelleştirme grubu nesnesi kimlik değeri. |
| productCustomizationGroupName | string |  | Ürün özelleştirme grubu nesnesinin grup adı. |
| productCustomizationGroupSortOrder | integer |  | Ürün özelleştirme grubu nesnesinin sıralaması. |
| productCustomizationFieldId | integer |  | Ürün özelleştirme nesnesi kimlik değeri.. |
| productCustomizationFieldType | string |  | Ürün özelleştirme nesnesinin alan tipi. |
| productCustomizationFieldName | string |  | Ürün özelleştirme nesnesinin alan adı. |
| productCustomizationFieldValue | string |  | Ürün özelleştirme nesnesinin değeri. |
| productCustomizationFieldPath | string |  | Ürün özelleştirme alanı lokasyonu. |
| cartItemAttributeId | integer |  | Sepet kalemi özelliği nesnesi kimlik değeri. |
| isCloudFile | integer |  | Cloud dosyası olma durumu |
| cloudContentUrl | string |  | Cloud içerik URL'i |
| orderItem | [OrderItem](#schema-orderitem) | ✓ |  |

---

<h3 id='schema-menuitem'>MenuItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Menü nesnesi kimlik değeri |
| type | string | ✓ | Menü nesnesi tipi<br>İzin verilen değerler: `url`, `page`, `category` |
| title | string | ✓ | Menü Adı |
| url | string |  | Menü nesnesi bağlantı adresi |
| targetBlankStatus | integer |  | Yeni Sayfada açılma durumu<br>İzin verilen değerler: `0`, `1` |
| rowOrder | integer |  | Satır Sıra No<br>İzin verilen değerler: `1`, `2` |
| sortOrder | integer |  | Sıra No |
| category | [Category](#schema-category) |  |  |
| page | [Page](#schema-page) |  |  |
| hasChildren | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| tree | string |  |  |
| parent | [MenuItem](#schema-menuitem) |  |  |
| children | object |  |  |
| level | integer |  |  |

---

<h3 id='schema-blog'>Blog</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Blog nesnesi kimlik değeri. |
| title | string | ✓ | Blog başlığı. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir.  |
| imageFileName | string |  | Blog nesnesinin görselinin dosya adı. Site hızı ve seo skorunuz için yüklemiş olduğunuz görselin JPG formatında olmasını öneriyoruz. |
| imageExtension | string |  | Imaj dosyası uzantısı.<br>İzin verilen değerler: `jpg`, `png`, `gif`, `jpeg`, `webp`, `avif`, `JPG`, `PNG`, `GIF`, `JPEG`, `WEBP`, `AVIF` |
| imageUrl | string |  | Blog nesnesinin görselinin url'i. |
| excerpt | string | ✓ | Blog Özeti. |
| content | string |  | Blog içeriği. |
| pageTitle | string |  | Blog nesnesi sayfa başlığı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir. |
| blockVisibility | integer | ✓ | Blogların blok durumu.<br>İzin verilen değerler: `0`, `1` |
| status | integer | ✓ | Blog nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| attachment | string |  | Blog nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir. |
| categories | array[[BlogCategory](#schema-blogcategory)] | ✓ | Blog Kategorileri |
| tags | array[[BlogTag](#schema-blogtag)] |  | Blog Etiketleri |
| seoSetting | [SeoSetting](#schema-seosetting) |  |  |
| createdAt | string (date-time) |  | Blog nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Blog nesnesinin güncellenme zamanı. |

---

<h3 id='schema-specgroup'>SpecGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ürün özelliği grubu nesnesi kimlik değeri. |
| name | string | ✓ | Ürün özelliği grubu nesnesi için isim değeri. |
| sortOrder | integer | ✓ | Ürün özelliği grubu nesnesi için sıralama değeri. |
| status | integer | ✓ | Ürün özelliği grubu nesnesi için aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| specNames | array[[SpecName](#schema-specname)] | ✓ | Spec isimleri nesnesi listesi. |

---

<h3 id='schema-currentaccount'>CurrentAccount</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Cari hesap nesnesi kimlik değeri. |
| member | [Member](#schema-member) | ✓ |  |
| code | string |  | Cari hesap için düzenlenebilir bir kod değeri. |
| title | string |  | Cari hesap nesnesinin başlığı. |
| balance | number (float) |  | Cari hesabın bakiyesi. |
| riskLimit | number (float) |  | Cari hesap için belirlenmiş risk limiti. |
| createdAt | string (date-time) |  | Cari hesap nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Cari hesap nesnesinin güncellenme zamanı. |

---

<h3 id='schema-customizationfieldoption'>CustomizationFieldOption</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Özel Form Alanı Seçenekleri nesnesi kimlik değeri. |
| name | string | ✓ | Özel Form Alanı Seçenekleri nesnesi için isim değeri. |
| value | string | ✓ | Özel Form Alanı Seçenekleri nesnesi değeri. |
| customizationField | [CustomizationField](#schema-customizationfield) | ✓ |  |
| updatedAt | string (date-time) |  | Özel Form Alanı Seçenekleri nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Özel Form Alanı Seçenekleri nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-tabbedmidblockproduct'>TabbedMidblockProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Tablı vitrin bloğu ürünü kimlik değeri. |
| product | [Product](#schema-product) | ✓ |  |
| tabbedMidblock | [TabbedMidblock](#schema-tabbedmidblock) | ✓ |  |
| sortOrder | integer | ✓ | Sıra no. |

---

<h3 id='schema-mailcontenttranslation'>MailContentTranslation</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| language | string | ✓ |  |
| content | string |  |  |

---

<h3 id='schema-paymentgateway'>PaymentGateway</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme kanalı nesnesi kimlik değeri. |
| code | string | ✓ | Ödeme kanalı için ön tanımlanmış kod değeri. |
| name | string | ✓ | Ödeme kanalı nesnesi için isim değeri. |
| sortOrder | integer | ✓ | Ödeme kanalı nesnesi için sıralama değeri. |
| status | string | ✓ | Ödeme kanalının aktiflik durumu.<br>İzin verilen değerler: `active`, `passive` |
| paymentProvider | [PaymentProvider](#schema-paymentprovider) | ✓ |  |
| settings | array[[PaymentGatewaySetting](#schema-paymentgatewaysetting)] |  | Ödeme kanalı ayarları nesnesi |
| installmentRates | array[[InstallmentRate](#schema-installmentrate)] |  | Taksit oranları nesnesi |
| extraInstallment | [ExtraInstallment](#schema-extrainstallment) |  |  |
| updatedAt | string (date-time) |  | Ödeme kanalı nesnesi güncellenme zamanı. |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-purchaselimitation'>PurchaseLimitation</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Satın alma limiti nesnesi kimlik değeri. |
| name | string | ✓ | Satın alma limiti nesnesi ismi. |
| minimumLimit | number (float) |  | Minimum satın alma limiti. |
| maximumLimit | number (float) |  | Maksimum satın alma limiti. |
| type | string | ✓ |  Satın Alma Limiti Türü.<br>İzin verilen değerler: `product`, `category`, `brand` |
| status | integer | ✓ | Satın alma limiti aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| purchaseLimitationItems | array[[PurchaseLimitationItem](#schema-purchaselimitationitem)] | ✓ | Satın alma limitli ürünler |
| updatedAt | string (date-time) |  | Satın alma limiti nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Satın alma limiti nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-installmentrate'>InstallmentRate</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Taksit oranı nesnesi kimlik değeri |
| installment | integer | ✓ | Taksit oranı nesnesine ait taksit sayısı |
| rate | number (float) | ✓ | Taksit oranı. (Direkt çarpılır)  |
| paymentGateway | [PaymentGateway](#schema-paymentgateway) | ✓ |  |

---

<h3 id='schema-producttag'>ProductTag</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| tag | [Tag](#schema-tag) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-productdetail'>ProductDetail</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün detayı nesnesi kimlik değeri. |
| sku | string | ✓ | Ürünün stok kodu. |
| details | string | ✓ | Detay bilgisi. |
| extraDetails | string |  | Ürün ekstra detaylı bilgi. |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-poll'>Poll</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Anket nesnesi kimlik değeri |
| name | string | ✓ | Anket nesnesi ismi |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| status | integer | ✓ | Anket nesnesi aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| answers | array[[PollAnswer](#schema-pollanswer)] | ✓ | Anket cevapları nesnesi |
| updatedAt | string (date-time) |  | Anket nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  | Anket nesnesi oluşturulma zamanı. |

---

<h3 id='schema-combineproduct'>CombineProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kombin ürün nesnesi kimlik değeri. |
| product | [ManualRelation](#schema-manualrelation) | ✓ |  |
| combineProduct | [ManualRelation](#schema-manualrelation) | ✓ |  |

---

<h3 id='schema-manualrelation'>ManualRelation</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Nesne ilşkisi nesnesi kimlik değeri. Nesnenin kendi içinde parent veya child olarak kullanılması durumunda bağları tanımlamak için kullanılan ilişki nesnesi |
| name | string |  | Nesne ilşkisi nesnesi ismi |
| title | string |  | Nesne ilşkisi nesnesi başlığı |
| slug | string |  |  |
| hasImage | integer |  |  |

---

<h3 id='schema-packageitemproduct'>PackageItemProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Paket kalemi ürünü nesnesi kimlik değeri |
| packageItem | [PackageItem](#schema-packageitem) | ✓ |  |
| package | [Package](#schema-package) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |
| updatedAt | string (date-time) |  | Paket kalemi ürünü nesnesi güncellenme zamanı. |
| createdAt | string (date-time) |  | Paket kalemi ürünü nesnesi oluşturulma zamanı. |

---

<h3 id='schema-sitecontent'>SiteContent</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| homePageHeadContent | string |  | Anasayfa üst içeriği. |
| footer | string |  | Sayfa alt içeriği. |
| brandListHeadContent | string |  | Markalar üst içeriği. |
| categoryListHeadContent | string |  | Kategoriler üst içeriği. |
| newProductsListHeadContent | string |  | Yeni ürünler üst içeriği. |
| featuredProductsListHeadContent | string |  | Sponsorlu ürünler üst içeriği. |
| rebatedProductsListHeadContent | string |  | İndirimli ürünler üst içeriği. |
| popularProductsListHeadContent | string |  | Popüler ürünler üst içeriği. |
| promotionCampaignListHeadContent | string |  | Kampanyalar Üst İçerik |

---

<h3 id='schema-memberaddress'>MemberAddress</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Üye adresi nesnesinin benzersiz rakamsal kimlik değeri. |
| name | string | ✓ | Üye Adresi adı. |
| type | string | ✓ | Üye Adresi tipi.<br>İzin verilen değerler: `billing`, `shipping` |
| firstname | string | ✓ | Üyenin ismi. |
| surname | string | ✓ | Üyenin soy ismi. |
| address | string | ✓ | Üyenin adres bilgileri. |
| zipCode | string |  |  |
| subLocationName | string |  | İlçe adı. |
| locationName | string |  | Şehir adı. |
| phoneNumber | string |  | Üyenin telefon numarası. |
| mobilePhoneNumber | string | ✓ | Üyenin mobil telefon numarası. |
| tcId | string |  | Üyenin TC kimlik numarası. |
| taxNumber | string |  | Üyenin vergi numarası. |
| taxOffice | string |  | Üyenin vergi dairesi. |
| invoiceType | string | ✓ | Fatura tipini belirtir.<br>İzin verilen değerler: `individual`, `corporate` |
| isEinvoiceUser | boolean | ✓ | Yöneticinin(admin) e-fatura kullanıp kullanmadığı bilgisini belirtir.<br>İzin verilen değerler: `True`, `False` |
| createdAt | string (date-time) |  | Üye adresi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Üye adresi nesnesinin güncellenme zamanı. |
| member | [Member](#schema-member) | ✓ |  |
| country | [Country](#schema-country) | ✓ |  |
| location | [Location](#schema-location) |  |  |
| subLocation | [Town](#schema-town) |  |  |

---

<h3 id='schema-pixelsettingpref'>PixelSettingPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| pixelId | string |  | Facebook Piksel Ayarları nesnesi kimlik değeri |
| capiToken | string |  | Capi token değeri |
| testEventCode | string |  | Test kodu |
| facebookCatalogIdType | string |  | Facebook kategori kimlik değeri tipi<br>İzin verilen değerler: `sku`, `id` |
| isAuthenticated | integer |  | <br>İzin verilen değerler: `0`, `1` |
| errorMessage | string |  |  |

---

<h3 id='schema-distributor'>Distributor</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Kişisel Tedarikçiler  nesnesi kimlik değeri. |
| name | string | ✓ | Tedarikçi Adı |
| email | string |  | Tedarikçi E-mail'i |
| phone | string |  | Tedarikçi telefonu |
| contactPerson | string |  | Yetkili Kişi |

---

<h3 id='schema-metafield'>MetaField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Metafield nesnesi kimlik değeri |
| type | string | ✓ | Metafield nesnesi tipi |
| varKey | string | ✓ | Metafield nesnesi seçeneği |
| varValue | string | ✓ | Metafield nesnesi seçeneği değeri |
| context | string |  | Metafield nesnesi içeriği<br>İzin verilen değerler: `banner`, `product`, `productDetail`, `productSpecialInfo`, `category`, `brand`, `blog`, `blogCategory`, `blogTag`, `extraInfo`, `extraInfoToProduct`, `filterMenu`, `label`, `menuItem`, `optionGroup`, `options`, `page`, `pollQuestion`, `pollAnswer`, `popup`, `promotionBar`, `selection`, `selectionGroup`, `siteContent`, `specGroup`, `specName`, `specValue`, `seoPref`, `syslang`, `tabbedMidBlock`, `tag`, `mailContent`, `priceRule`, `commonPref`, `country`, `currency`, `preference`, `form`, `shippingCompany`, `package`, `packageItem`, `productExtraField` |
| contextItemId | integer | ✓ | Metafield nesnesi içeriği kimlik değeri |
| createdAt | string (date-time) |  | Metafield nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Metafield nesnesinin güncellenme zamanı. |

---

<h3 id='schema-netgsmlog'>NetGsmLog</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| status | integer |  |  |
| jobId | string |  |  |
| phoneNumbers | string |  |  |
| message | string |  |  |
| messageStatus | integer |  |  |
| errorCode | integer |  |  |
| createdAt | string (date-time) |  |  |
| updatedAt | string (date-time) |  |  |

---

<h3 id='schema-popup'>Popup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Popup nesnesi kimlik değeri |
| title | string | ✓ | Başlık |
| content | string | ✓ | İçerik |
| status | integer | ✓ | Popup nesnesi durumu<br>İzin verilen değerler: `0`, `1` |
| exitOffer | integer | ✓ | Çıkış teklifi durumu<br>İzin verilen değerler: `0`, `1` |
| frequency | integer |  | Gösterim Sıklığı |
| displayHomepage | integer |  | Anasayfada gösterim durumu<br>İzin verilen değerler: `0`, `1` |
| displayProductPage | integer |  | Ürün sayfasında gösterim durumu<br>İzin verilen değerler: `0`, `1` |
| displayCategoryPage | integer |  | Kategori sayfasında gösterim durumu<br>İzin verilen değerler: `0`, `1` |
| categories | array[[Category](#schema-category)] |  | Kategori nesnesi |
| createdAt | string (date-time) |  | Popup nesnesi oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Popup nesnesi  güncellenme zamanı. |

---

<h3 id='schema-block'>Block</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Blok nesnesi kimlik değeri. |
| name | string | ✓ | Blok nesnesi için isim değeri. |
| position | string | ✓ | Blok konumu.<br>İzin verilen değerler: `left`, `right` |
| sortOrder | integer |  | Blok nesnesi için sıralama değeri. |
| module | string |  | Blok nesnesinin ait olduğu modül. |
| content | string |  | Blok nesnesi içeriği. |
| frame | integer | ✓ | Blok Çerçevesi.<br>İzin verilen değerler: `0`, `1` |
| status | integer | ✓ | Blok nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| predefined | integer |  | Sitede ön tanımlı blok.<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-customtax'>CustomTax</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Özel vergi oranları nesnesi kimlik değeri. |
| name | string | ✓ | Özel vergi oranları nesnesi için isim değeri. |
| countryCode | string | ✓ | Ülke nesnesi için tanımlı 2 harfli kod. |
| currencyAbbr | string | ✓ | Özel vergi oranları nesnesine ait kurun kısaltması. |
| limitType | string | ✓ | Özel vergi oranları limit tipi<br>İzin verilen değerler: `min`, `max` |
| limitValue | number (float) | ✓ | Özel vergi oranları limit değeri |
| amountType | string | ✓ | Özel vergi oranları miktarı formatı<br>İzin verilen değerler: `percentage`, `fixed` |
| amountValue | number (float) | ✓ | Özel vergi oranları miktarı |
| isShippingValueIncluded | integer | ✓ | Özel vergi oranları kargo bedeli dahillik durumu<br>İzin verilen değerler: `0`, `1` |
| status | integer | ✓ | Özel vergi oranları nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Özel vergi oranları nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Özel vergi oranları nesnesinin güncellenme zamanı. |

---

<h3 id='schema-instagramshopproduct'>InstagramShopProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| product | [Product](#schema-product) | ✓ |  |
| instagramShop | [InstagramShop](#schema-instagramshop) | ✓ |  |
| sortOrder | integer | ✓ |  nesnesi için sıralama değeri. |

---

<h3 id='schema-packageitem'>PackageItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Paket kalemi nesnesi kimlik değeri |
| name | string | ✓ | Paket kalemi nesnesi ismi |
| choiceType | string | ✓ | Paket kalemi nesnesi seçim tipi<br>İzin verilen değerler: `singular`, `plural` |
| isRequired | integer | ✓ | Zorunlu alan durumu<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ | Paket kalemi nesnesi için sıralama değeri. |
| package | [Package](#schema-package) | ✓ |  |
| category | [Category](#schema-category) |  |  |
| products | array[[Product](#schema-product)] |  | Ürün nesnesi listesi |
| updatedAt | string (date-time) |  | Paket kalemi nesnesi güncellenme zamanı. |
| createdAt | string (date-time) |  | Paket kalemi nesnesi oluşturulma zamanı. |

---

<h3 id='schema-clientpermission'>ClientPermission</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| scope | string | ✓ | scope |
| enabledByStore | integer |  | enabledByStore<br>İzin verilen değerler: `0`, `1` |
| installedByAppStore | integer |  | installedByAppStore<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | createdAt |
| updatedAt | string (date-time) |  | updatedAt |
| client | [Client](#schema-client) | ✓ |  |
| user | [User](#schema-user) | ✓ |  |

---

<h3 id='schema-membergroupposaccount'>MemberGroupPosAccount</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Üye Grubu Pos Hesabı nesnesi |
| installmentRates | array[[InstallmentRate](#schema-installmentrate)] | ✓ | Taksit oranı nesnesi listesi |
| extraInstallment | [ExtraInstallment](#schema-extrainstallment) |  |  |
| installmentThreshold | number (float) | ✓ | Minimum Taksit Tutarı |
| status | integer | ✓ | Üye Grubu Pos Hesabı nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| memberGroup | [MemberGroup](#schema-membergroup) | ✓ |  |
| posAccount | [PosAccount](#schema-posaccount) | ✓ |  |

---

<h3 id='schema-specname'>SpecName</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ürün özelliği nesnesi kimlik değeri. |
| name | string | ✓ | Ürün özelliği nesnesi için isim değeri. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| choiceType | string | ✓ | Özellik tipini belirtir.<br>İzin verilen değerler: `singular`, `plural` |
| sortOrder | integer | ✓ | Ürün özelliği sıralama değeri. |
| status | integer | ✓ | Ürün özelliği aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| specGroup | [SpecGroup](#schema-specgroup) |  |  |
| specValues | array[[SpecValue](#schema-specvalue)] | ✓ | specValues |

---

<h3 id='schema-modelfactory'>ModelFactory</h3>


---

<h3 id='schema-paymentproxy'>PaymentProxy</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme yönlendiricisi nesnesi kimlik değeri |
| code | string |  | Ödeme yönlendiricisi nesnesi kodu |
| name | string |  | Ödeme yönlendiricisi nesnesi ismi |
| status | integer | ✓ | Ödeme yönlendiricisi nesnesi durumu<br>İzin verilen değerler: `0`, `1` |
| settings | array[[PaymentProxySetting](#schema-paymentproxysetting)] |  | Ödeme proxy ayarı nesnesi |
| updatedAt | string (date-time) |  | Ödeme yönlendiricisinesnesi güncellenme zamanı. |
| createdAt | string (date-time) |  | Ödeme yönlendiricisi nesnesi oluşturulma zamanı. |

---

<h3 id='schema-orderusernote'>OrderUserNote</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Sipariş yönetici notu nesnesi kimlik değeri. |
| userEmail | string | ✓ | Yöneticinin(admin) e-mail adresi. |
| userFirstname | string | ✓ | Yöneticinin(admin) ismi. |
| userSurname | string | ✓ | Yöneticinin(admin) soy ismi. |
| note | string | ✓ | Yöneticinin(admin) sipariş için girdiği not. |
| updatedAt | string (date-time) |  | Sipariş yönetici notu nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Sipariş yönetici notu nesnesinin oluşturulma zamanı. |
| user | [User](#schema-user) |  |  |
| order | [Order](#schema-order) | ✓ |  |

---

<h3 id='schema-ordercustomtaxline'>OrderCustomTaxLine</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş özel tanımlı vergi nesnesi kimlik değeri |
| name | string | ✓ | Sipariş özel tanımlı vergi nesnesi ismi |
| value | number (float) | ✓ | Sipariş özel tanımlı vergi nesnesi değeri |
| currency | string | ✓ | Para birimi |
| order | [Order](#schema-order) | ✓ |  |

---

<h3 id='schema-payment'>Payment</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ödeme nesnesi kimlik değeri. |
| transactionId | string | ✓ | Siparişin numarası. |
| memberFirstname | string | ✓ | Üyenin ismi. |
| memberSurname | string | ✓ | Üyenin soy ismi. |
| memberEmail | string | ✓ | Üyenin e-mail adresi. |
| memberPhone | string | ✓ | Üyenin telefon numarası. |
| status | string | ✓ | Ödeme durumu<br>İzin verilen değerler: `deleted`, `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3`, `failed`, `in_transaction` |
| statusLang | string |  | Ödeme durumu dili |
| paymentTypeName | string | ✓ | Ödeme tipi |
| paymentProviderCode | string | ✓ | Ödeme hizmeti sağlayıcısı kodu. Bu değer ön tanımlıdır. |
| paymentProviderName | string | ✓ | Ödeme hizmeti sağlayıcısı adı. Bu değer ön tanımlıdır. |
| paymentGatewayCode | string | ✓ | Ödeme kanalı kodu. Bu değer ön tanımlıdır. |
| paymentGatewayName | string | ✓ | Ödeme kanalı adı. Bu değer ön tanımlıdır. |
| bankName | string | ✓ | Ödeme yapılan banka. Bu değer ön tanımlıdır. |
| cardHolderName | string |  | Kart sahibi ismi |
| deviceType | string | ✓ | Ödemenin gerçekleştiği cihaz bilgisi.<br>İzin verilen değerler: `desktop`, `mobile`, `tablet` |
| currencyRates | string | ✓ | Kur oranları. |
| amount | number (float) | ✓ | Ödemenin saf fiyatı. |
| finalAmount | number (float) | ✓ | Ödemenin son fiyatı. |
| sumOfGainedPoints | number (float) |  | Ödemeden kazanılan toplam puan. |
| installment | integer | ✓ | Ödemenin standart taksit sayısı. |
| installmentRate | number (float) | ✓ | Ödemenin taksit oranı. |
| extraInstallment | integer |  | Ödemenin ekstra taksit sayısı. |
| currency | string | ✓ | Kur bilgisi. |
| memberNote | string |  | Müşterinin ödeme notu. |
| userNote | string |  | Yönetici(admin) ödeme notu. |
| errorMessage | string |  | Ödemenin hata mesajı. |
| cardSavingSystem | string |  | Kart saklama sistemi. |
| member | [Member](#schema-member) |  |  |
| updatedAt | string (date-time) |  | Ödeme nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  | Ödeme nesnesi oluşturulma zamanı. |

---

<h3 id='schema-pricegap'>PriceGap</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Fiyat Aralığı nesnesi kimlik değeri |
| start | integer | ✓ | Fiyat Aralığı başlangıcı |
| end | integer | ✓ | Fiyat Aralığı bitişi |

---

<h3 id='schema-seopref'>SeoPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| homepage | [SeoDetail](#schema-seodetail) | ✓ |  |
| brandPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| categoryPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| productPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| newProductsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| rebateProductsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| featuredProductsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| popularProductsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| dynamicPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| packageBuilderPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| seoTagPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| missedChancePage | [SeoDetail](#schema-seodetail) | ✓ |  |
| contactPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| blogPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| categoriesPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| brandsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| pagesPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| newsPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| cartPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| productSearchPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| instagramShopPage | [SeoDetail](#schema-seodetail) | ✓ |  |
| blogPost | [SeoDetail](#schema-seodetail) | ✓ |  |
| image | [SeoDetail](#schema-seodetail) | ✓ |  |

---

<h3 id='schema-productcomment'>ProductComment</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün yorumu nesnesi kimlik değeri. |
| title | string |  | Ürün yorumu başlığı. |
| content | string |  | Ürün yorumu içeriği. |
| status | integer | ✓ | Ürün yorumu durumu.<br>İzin verilen değerler: `0`, `1` |
| rank | integer | ✓ | Ürün yorumunda ürüne verilen puan.<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |
| isAnonymous | integer | ✓ | Ürün yorumu yapan kişinin anonim olup olmadığı bilgisi.<br>İzin verilen değerler: `0`, `1` |
| member | [Member](#schema-member) |  |  |
| product | [Product](#schema-product) |  |  |
| createdAt | string (date-time) |  | Ürün yorumu nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Ürün yorumu nesnesinin güncellenme zamanı. |

---

<h3 id='schema-productcustomizationfield'>ProductCustomizationField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün özelleştirme alanı nesnesi kimlik değeri |
| name | string | ✓ | Ürün özelleştirme alanı nesnesi ismi |
| sortOrder | integer |  | Ürün özelleştirme alanı sırası |
| isRequired | integer | ✓ | Ürün özelleştirme alanı zorunluluk durumu<br>İzin verilen değerler: `0`, `1` |
| type | string | ✓ | c tipi<br>İzin verilen değerler: `checkbox`, `dropdown`, `file`, `radio`, `textarea`, `textbox` |
| placeHolder | string | ✓ | Ürün özelleştirme alanı yer tutucusu |
| info | string | ✓ | Bilgi alanı |
| productCustomizationGroup | [ProductCustomizationGroup](#schema-productcustomizationgroup) | ✓ |  |
| options | array[[ProductCustomizationFieldOption](#schema-productcustomizationfieldoption)] |  | options |
| settings | array[[ProductCustomizationFieldSetting](#schema-productcustomizationfieldsetting)] |  | settings |

---

<h3 id='schema-formfield'>FormField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| type | string | ✓ | Form alanı tipi<br>İzin verilen değerler: `textbox`, `textarea`, `dropdown`, `radiobox`, `checkbox`, `info` |
| name | string | ✓ | Form alanı ismi |
| isRequired | integer | ✓ | Form Alanı zorunluluk durumu<br>İzin verilen değerler: `0`, `1` |
| options | array[[FormOption](#schema-formoption)] | ✓ | Form alanı seçenekleri |
| settings | array[[FormSetting](#schema-formsetting)] | ✓ | Form alanı ayarları |

---

<h3 id='schema-admin-model-installedapplication'>Admin-Model-InstalledApplication</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| applicationId | integer |  |  |
| applicationName | string |  |  |
| applicationSmallLogo | string |  |  |
| applicationLogo | string |  |  |
| applicationImages | object |  |  |
| applicationShortDetail | string |  |  |
| applicationUser | object |  |  |
| applicationEmbedded | boolean |  |  |
| applicationVisibilityScope | string |  |  |
| applicationRenewDate | string (date-time) |  |  |
| applicationParentId | integer |  |  |
| applicationParentName | string |  |  |
| applicationParentLogo | string |  |  |
| applicationParentSmallLogo | string |  |  |
| applicationParentImages | object |  |  |
| applicationParentSlug | string |  |  |
| embeddedUrl | string |  |  |
| authUrl | string |  |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-customizationgroupnamespace'>CustomizationGroupNamespace</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| name | string | ✓ | name |
| type | string | ✓ | type |
| description | string | ✓ | description |

---

<h3 id='schema-orderrefundrequest'>OrderRefundRequest</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş iptal talebi nesnesi kimlik değeri. |
| code | string |  | Sipariş iptal talebi için oluşturulan benzersiz kod değeri. |
| status | string | ✓ | Sipariş iptal talebi için durum bilgisi.<br>İzin verilen değerler: `approved`, `waiting_for_approval`, `cancelled`, `refundReasonOrderSpecial1`, `refundReasonOrderSpecial2` |
| fee | number (float) |  | Müşteriye ödenecek miktar bilgisi. |
| shippingFee | number (float) |  | Kargo tutarı |
| cancellationReason | string |  | Sipariş iptal talebinin oluşturulması sebebinin detaylı açıklaması. |
| order | [Order](#schema-order) |  |  |
| refundRequestItems | array[[OrderRefundRequestItem](#schema-orderrefundrequestitem)] |  | Sipariş iptal talebi kalemi nesnesi |
| autoPayback | integer | ✓ | Otomatik geri ödeme durumu<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Sipariş iptal talebi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Sipariş iptal talebi nesnesinin güncellenme zamanı. |

---

<h3 id='schema-member'>Member</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Üye nesnesi kimlik değeri. |
| firstname | string | ✓ | Üyenin ismi. |
| surname | string | ✓ | Üyenin soy ismi. |
| email | string | ✓ | Üyenin e-mail adresi. |
| password | string | ✓ | password |
| gender | string |  | Üyenin cinsiyet bilgisi.<br>İzin verilen değerler: `male`, `female`, `unspecified` |
| birthDate | string (date-time) |  | Üyenin doğum tarihi. |
| phoneNumber | string |  | Üyenin telefon numarası. |
| mobilePhoneNumber | string |  | Üyenin mobil telefon numarası. |
| tcId | string |  | Üyenin TC kimlik numarası. |
| status | string | ✓ | Üyenin durum bilgisi.<br>İzin verilen değerler: `active`, `passive`, `queue`, `suspended` |
| kvkkStatus | integer |  | Üye KVKK kabul edilme durumu<br>İzin verilen değerler: `0`, `1` |
| commercialName | string |  | Üyenin kurumsal adı. |
| taxNumber | string |  | Üyenin vergi numarası. |
| taxOffice | string |  | Üyenin vergi dairesi. |
| address | string |  | Üyenin adres bilgileri. |
| country | [Country](#schema-country) | ✓ |  |
| location | [Location](#schema-location) | ✓ |  |
| locationName | string |  | locationName |
| otherLocation | string |  | Üyenin diğer şehir bilgileri. |
| district | string |  | Üyenin ilçesi. |
| zipCode | string |  | Üyenin posta kodu. |
| memberGroup | [MemberGroup](#schema-membergroup) |  |  |
| currentAccount | [CurrentAccount](#schema-currentaccount) |  |  |
| deviceType | string | ✓ | Üyelik oluşturulurken kullanılan cihaz tipi<br>İzin verilen değerler: `bilgisayar`, `mobil` |
| deviceInfo | string |  | Üyelik oluşturulurken kullanılan cihaz bilgisi |
| lastIp | string |  | Üyenin son giriş yaptığı IP adresi |
| pointAmount | number (float) |  | Üyenin kazandığı puan tutarı. |
| metaFields | array[[EntityMetaField](#schema-entitymetafield)] |  | Metafield nesnesi |
| allowedToPhone | integer | ✓ | Üyenin telefon aramaları için izin durumu.<br>İzin verilen değerler: `0`, `1` |
| allowedToCampaigns | integer | ✓ | Üyenin kampanyalara katılım için izin durumu.<br>İzin verilen değerler: `0`, `1` |
| allowedToSms | integer | ✓ | Üyenin sms gönderimi için izin durumu.<br>İzin verilen değerler: `0`, `1` |
| lastLoginDate | string (date-time) |  | Üye son giriş tarihi |
| lastMailSentDate | string (date-time) |  | Üyeye son mail gönderilme tarihi |
| allowedToPhoneUpdatedAt | string (date-time) |  | Üyenin telefon aramaları için izin durumu son güncellenme zamanı |
| allowedToCampaignsUpdatedAt | string (date-time) |  | Üyenin kampanyalara katılım için izin durumu son güncellenme zamanı |
| allowedToSmsUpdatedAt | string (date-time) |  | Üyenin sms gönderimi için izin durumu son güncellenme zamanı |
| createdAt | string (date-time) |  | Üye nesnesi oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Üye nesnesi  güncellenme zamanı. |

---

<h3 id='schema-blogtag'>BlogTag</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Blog Tag nesnesi kimlik değeri. |
| title | string | ✓ | Blog Tag başlığı. |
| slug | string |  |  |
| pageTitle | string |  |  |
| metaKeywords | string |  |  |
| metaDescription | string |  |  |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir. |
| status | integer | ✓ | Blog tag nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Blog Tag nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Blog Tag nesnesinin güncellenme zamanı. |

---

<h3 id='schema-role'>Role</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| name | string | ✓ | name |
| privileges | object |  | privileges |

---

<h3 id='schema-fraudrisk'>FraudRisk</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Riskli sipariş kaynağı nesnesi |
| firstname | string | ✓ | Sipariş geçilen isim |
| surname | string | ✓ | Sipariş geçilen soyad |
| email | string |  | Sipariş geçilen e-mail |
| phoneNumber | string |  | Sipariş geçilen telefon numarası |
| mobilePhoneNumber | string |  | Sipariş geçilen cep telefonu numarası |
| identityRegistrationNumber | string |  | Sipariş geçilen TC kimlik no |
| ip | string |  | Sipariş geçilen IP adresi |
| taxNo | string |  | Sipariş geçilen vergi numarası |
| note | string |  | Not |
| updatedAt | string (date-time) |  | Riskli sipariş kaynağı güncellenme zamanı. |
| createdAt | string (date-time) |  | Riskli sipariş kaynağı oluşturulma zamanı. |

---

<h3 id='schema-user'>User</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Kullanıcı nesnesi kimlik değeri. |
| firstname | string |  | Kullanıcı ismi. |
| surname | string |  | Kullanıcı soy ismi. |
| email | string | ✓ | Kullanıcı e-mail adresi. |
| password | string | ✓ | password |
| username | string | ✓ | Kullanıcı kullanıcı adı. |
| status | integer | ✓ | Kullanıcı aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1`, `2` |
| createdAt | string (date-time) |  | Kullanıcı nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Kullanıcı nesnesinin güncellenme zamanı. |
| isCustomerRepresentative | integer | ✓ | Müşteri temsilciliği durumu.<br>İzin verilen değerler: `0`, `1` |
| memberGroups | array[[MemberGroup](#schema-membergroup)] |  | memberGroups |
| userRole | [UserRole](#schema-userrole) |  |  |
| mfaStatus | integer |  | <br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-optiongroup'>OptionGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Varyant grubu nesnesi kimlik değeri. |
| title | string | ✓ | Varyant grubunun başlığı. Varyant değeri kırmızı ise bu değer renk olabilir. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| sortOrder | integer | ✓ | Varyant grubu nesnesi için sıralama değeri. |
| predefined | integer |  | Varyant grubu nesnesinin öntanımlı olma durumu<br>İzin verilen değerler: `0`, `1` |
| filterStatus | integer | ✓ | Varyant grubunun filtre menüsündeki gösterim durumu.<br>İzin verilen değerler: `0`, `1` |
| aggregator | integer | ✓ | Filtre menüde gruplanma durumu<br>İzin verilen değerler: `0`, `1` |
| options | array[[Option](#schema-option)] | ✓ | Varyant nesnesi listesi |

---

<h3 id='schema-shoppingexperience'>ShoppingExperience</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| member | [Member](#schema-member) |  |  |
| content | string |  |  |
| rating | integer | ✓ | <br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |
| isAnonymous | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| status | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  |  |
| updatedAt | string (date-time) |  |  |

---

<h3 id='schema-orderitem'>OrderItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş kalemi nesnesi kimlik değeri. |
| productName | string | ✓ | Ürünün adı. |
| productSku | string | ✓ | Ürünün stok kodu. |
| productBarcode | string |  | Ürünün barkodu. |
| productPrice | number (float) | ✓ | Ürünün fiyatı. |
| productCurrency | string | ✓ | Ürünün kuru. |
| productQuantity | number (float) | ✓ | Ürünün stok tipi cinsinden miktarı. |
| productTax | number (float) | ✓ | Ürünün vergisi |
| productDiscount | number (float) | ✓ | Ürünün standart indirim değeri. |
| productMoneyOrderDiscount | number (float) | ✓ | Ürünün havale indirim değeri. |
| productWeight | number (float) | ✓ | Ürünün ağırlığı. |
| productStockTypeLabel | string | ✓ | Ürünün stok tipi. |
| isProductPromotioned | integer | ✓ | Ürünün promosyon olup olmadığını belirten değer.<br>İzin verilen değerler: `0`, `1` |
| discount | number (float) |  | Ürünün hediye çeki indirim değeri. |
| order | [Order](#schema-order) | ✓ |  |
| product | [Product](#schema-product) |  |  |
| orderItemCustomizations | array[[OrderItemCustomization](#schema-orderitemcustomization)] |  | Sipariş kalemi özelleştirme nesnesi |
| orderItemSubscription | [OrderItemSubscription](#schema-orderitemsubscription) |  |  |

---

<h3 id='schema-cartitemattribute'>CartItemAttribute</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sepet kalemi özelliği nesnesi kimlik değeri. |
| name | string | ✓ | Sepet kalemi özelliği nesnesinin isim değeri. Örneğin, sepet kalemi kalem ise bu değer renk olabilir. |
| value | string | ✓ | Sepet kalemi özelliği nesnesinin değeri. Örneğin, sepet kalemi kalem, isim değeri renk ise bu değer kırmızı olabilir. |
| productCustomizationFieldPath | string |  | Sepet kalemi özelleştirmeleri |
| cartItem | [CartItem](#schema-cartitem) | ✓ |  |

---

<h3 id='schema-blacklist'>Blacklist</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Engellenen Ip nesnesi kimlik değeri. |
| ip | string | ✓ | Engellenen Ip adresi. |
| createdAt | string (date-time) |  | Engellenen Ip nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-theme'>Theme</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Tema nesnesi kimlik değeri. |
| platform | string | ✓ | Temanın kullanılacağı platform.<br>İzin verilen değerler: `desktop`, `mobile` |
| type | string |  | Tema tipi.<br>İzin verilen değerler: `standard`, `self` |
| name | string | ✓ | Tema adı. |
| preset | string |  | Temanın rengi. |
| directoryName | string |  | Temanın dizini. |
| status | integer | ✓ | Temanın durumu.<br>İzin verilen değerler: `0`, `1` |
| version | integer | ✓ | Tema versiyonu<br>İzin verilen değerler: `1`, `2` |
| attachment | string | ✓ | Tema dosyası |
| createdAt | string (date-time) |  | Tema nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Tema nesnesinin güncellenme zamanı. |

---

<h3 id='schema-checkoutdesignpref'>CheckoutDesignPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| useSecurityStick | integer |  | Güvenlik Çubuğu Gösterimi<br>İzin verilen değerler: `0`, `1` |
| darkMode | integer |  | Karanlık mod. Bu ayar alışveriş sepeti sonrasındaki sipariş aşamaları (Teslimat bilgileri, Ödeme bilgileri ve Sipariş onayı) için geçerli olacaktır.<br>İzin verilen değerler: `0`, `1` |
| banner | [Banner](#schema-banner) |  |  |
| footer | [Footer](#schema-footer) |  |  |
| logo | [Logo](#schema-logo) |  |  |
| links | array[[Link](#schema-link)] |  | Sayfa altı bağlantısı. Maksimum 10 adet |

---

<h3 id='schema-promotion'>Promotion</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Promosyon nesnesi kimlik değeri. |
| type | string | ✓ | Promosyon tipi.<br>İzin verilen değerler: `cart`, `product`, `category_and_brand` |
| name | string | ✓ | Promosyon adı. |
| maxUsage | integer | ✓ | Promosyonun maximum kullanım sayısı. |
| currentUsage | integer |  | Şu ana kadar toplam kullanım sayısı. |
| useDateFilter | integer | ✓ | Tarih aralığı özelliği kullanılsın mı?<br>İzin verilen değerler: `0`, `1` |
| startDate | string (date-time) |  | Promosyon başlangıç tarihi. |
| endDate | string (date-time) |  | Promosyon bitiş tarihi. |
| members | array[[Member](#schema-member)] |  | members |
| memberGroup | [MemberGroup](#schema-membergroup) |  |  |
| minimumCheckoutLimit | number (float) | ✓ | Kullanım Alışveriş Sınırı |
| category | [Category](#schema-category) |  |  |
| categories | array[[Category](#schema-category)] |  |  |
| brand | [Brand](#schema-brand) |  |  |
| brands | array[[Brand](#schema-brand)] |  |  |
| mainProducts | array[[Product](#schema-product)] |  | Ana Ürünler |
| priceRanges | array[[PromotionPriceRange](#schema-promotionpricerange)] | ✓ |  |
| minimumPurchaseQuantityOfMainProducts | integer |  | Ana ürün minimum satın alma zorunluluğu miktarı |
| promotionValidityControl | string |  | Promosyon Geçerlilik Kontrolü<br>İzin verilen değerler: `together`, `any` |
| promotionFeatureType | string | ✓ | Promosyon özelliği tipi<br>İzin verilen değerler: `free`, `discountPrice`, `discountPercentage`, `fixedPrice`, `cartDiscountPercentage`, `byQty` |
| promotionFeatureValue | number (float) | ✓ | Promosyon özelliğine ait promosyon miktarı |
| promotionalProducts | array[[Product](#schema-product)] |  | Promosyonlu ürün nesnesi listesi |
| promotionalProductQuantity | integer |  | Promosyonlu ürün miktarı |
| description | string |  | Promosyon Açıklaması |
| url | string |  |  |
| urlBlankStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| imageFile | string |  |  |
| imageUrl | string |  |  |
| attachment | string |  |  |
| status | integer | ✓ | Promosyon aktiflik durumu <br>İzin verilen değerler: `0`, `1` |
| campaignPageStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ |  |
| freeShipping | integer | ✓ | Ücretsiz Kargo durumu.<br>İzin verilen değerler: `0`, `1` |
| applyToDiscountProduct | integer | ✓ | İndirimli ürünlerde geçerli olsun<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Promosyon nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Promosyon nesnesinin güncellenme zamanı. |

---

<h3 id='schema-adjacenttrait'>AdjacentTrait</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| next | string |  |  |
| prev | string |  |  |

---

<h3 id='schema-productfeed'>ProductFeed</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün önerisi nesnesi kimlik değeri. |
| values | object |  | Öneri değeri  |
| member | [Member](#schema-member) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |
| createdAt | string (date-time) |  | Ürün önerisi nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-option'>Option</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Varyant nesnesi kimlik değeri. |
| title | string | ✓ | Varyant başlığı. Varyant Grubu renk is bu değer kırmızı olabilir. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| sortOrder | integer | ✓ | Varyant nesnesi için sıralama değeri. |
| logo | string |  | Varyant değeri logosu |
| attachment | string |  | Varyant değeri logo dosyası |
| imageUrl | string |  | Varyant değeri imaj URL'i |
| size | integer |  | Varyant değeri logosu boyutu<br>İzin verilen değerler: `16`, `24`, `32`, `64`, `128`, `256`, `512` |
| optionGroup | [OptionGroup](#schema-optiongroup) | ✓ |  |
| updatedAt | string (date-time) |  | Varyant nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-tag'>Tag</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | SEO+ etiketi nesnesi kimlik değeri. |
| name | string | ✓ | SEO+ etiketi nesnesi için isim değeri. |
| slug | string | ✓ |  |
| count | integer |  | SEO+ etiketinin kaç kez kullanıldığı bilgisi. |
| pageTitle | string |  | SEO+ etiketi nesnesinin etiket başlığı. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |

---

<h3 id='schema-cartitemsubscription'>CartItemSubscription</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sepet kalemi aboneliği nesnesi kimlik değeri. |
| chosenPeriod | integer | ✓ | Seçilmiş abonelik periodu. (günde bir, haftada bir, ayda bir) |
| chosenDispatchCount | integer | ✓ |  |
| subscription | [Subscription](#schema-subscription) | ✓ |  |
| cartItem | [CartItem](#schema-cartitem) | ✓ |  |

---

<h3 id='schema-ticket'>Ticket</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Destek talebi nesnesi kimlik değeri. |
| subject | string |  | Destek talebi nesnesi başlığı. |
| content | string | ✓ | Destek talebi nesnesi içeriği. |
| code | string |  | Destek talebi nesnesi kod değeri. |
| status | string | ✓ | Destek talebi nesnesi durumu.<br>İzin verilen değerler: `pending`, `closed`, `replied` |
| parent | [ManualRelation](#schema-manualrelation) |  |  |
| member | [Member](#schema-member) |  |  |
| user | [User](#schema-user) |  |  |
| updatedAt | string (date-time) |  | Destek talebi nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Destek talebi nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-instagramshopsetting'>InstagramShopSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| varKey | string |  | varKey |
| varValue | string |  | varValue |

---

<h3 id='schema-purchaselimitationitem'>PurchaseLimitationItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Satın alma limiti kalemi nesnesi kimlik değeri. |
| purchaseLimitation | [PurchaseLimitation](#schema-purchaselimitation) | ✓ |  |
| brand | [Brand](#schema-brand) |  |  |
| category | [Category](#schema-category) |  |  |
| product | [Product](#schema-product) |  |  |
| memberGroup | [MemberGroup](#schema-membergroup) |  |  |
| createdAt | string (date-time) |  | Satın alma limiti kalemi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Satın alma limiti kalemi nesnesinin güncellenme zamanı. |

---

<h3 id='schema-formsetting'>FormSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| varKey | string | ✓ | Form alanı ayarları seçeneği<br>İzin verilen değerler: `attributes` |
| varValue | string | ✓ | Form alanı ayarları seçeneği değeri |

---

<h3 id='schema-pointpref'>PointPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| useInCommenting | integer |  | Yorumlarda Kullanarak puan kazanma özelliği<br>İzin verilen değerler: `0`, `1` |
| useInAdvicing | integer |  | Tavsiyelerde Kullanarak puan kazanma özelliği<br>İzin verilen değerler: `0`, `1` |
| useRegisteringAMember | integer |  | useRegisteringAMember<br>İzin verilen değerler: `0`, `1` |
| useInVoting | integer |  | Ankete Oy Vermede Kullan<br>İzin verilen değerler: `0`, `1` |
| useInShopping | integer |  | Alışverişte Kullan<br>İzin verilen değerler: `0`, `1` |
| useInPaymentSystem | integer |  | useInPaymentSystem<br>İzin verilen değerler: `0`, `1` |
| pointValue | number (float) |  | pointValue |
| pointPerCommenting | number (float) |  | pointPerCommenting |
| pointPerAdvicing | number (float) |  | pointPerAdvicing |
| pointPerRegisteringAMember | number (float) |  | pointPerRegisteringAMember |
| pointPerVoting | number (float) |  | pointPerVoting |
| percentPerShopping | number (float) |  | percentPerShopping |
| percentPerPaymentSystem | number (float) |  | percentPerPaymentSystem |
| tokenProductionRatio | number (float) |  | tokenProductionRatio |
| tokenMinimumUsageLimit | number (float) |  | tokenMinimumUsageLimit |
| minShoppingForInvitationGain | number (float) |  | minShoppingForInvitationGain |
| invitationGain | integer |  | invitationGain |
| tokenCategories | array[[Category](#schema-category)] | ✓ | tokenCategories |
| tokenBrands | array[[Brand](#schema-brand)] | ✓ | tokenBrands |
| isEffectiveSpecialToken | integer |  | isEffectiveSpecialToken<br>İzin verilen değerler: `0`, `1` |
| tokenTaxIncluded | integer |  | tokenTaxIncluded<br>İzin verilen değerler: `0`, `1` |
| tokenMinimumUsageLimitTaxIncluded | integer |  | tokenMinimumUsageLimitTaxIncluded<br>İzin verilen değerler: `0`, `1` |
| tokenMaximumUsageLimit | number (float) |  | tokenMaximumUsageLimit |
| useInDiscountedProduct | integer |  | useInDiscountedProduct<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-productimage'>ProductImage</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün resmi nesnesi kimlik değeri. |
| filename | string | ✓ | Ürün resminin dosya adı. Uzantı olmadan yazılmalıdır. |
| extension | string | ✓ | Resim için geçerli dosya uzantıları.<br>İzin verilen değerler: `jpg`, `png`, `gif`, `jpeg`, `webp`, `avif`, `JPG`, `PNG`, `GIF`, `JPEG`, `WEBP`, `AVIF` |
| sortOrder | integer | ✓ | Resmin sıralama değeri. Ürün içerisindeki 8 fotoğraf içinden hangisi olacağını belirler. |
| thumbUrl | string |  | Küçük resim URL adresi |
| originalUrl | string |  | Ürün imajı orijinal URL adresi. |
| attachment | string | ✓ | Ürün resminin base64 formatına çevrilmiş resim kodu. Oluşturma(POST) isteği esnasında başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir. Resim url'ini, https://www.magaza-adiniz.com/myassets/products/{directoryName}/{filename}.{extension}?revision={revision} formatını kullanarak kendiniz oluşturmanız gerekmektedir. |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-maillist'>Maillist</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Mail Listesi nesnesi kimlik değeri |
| name | string | ✓ | Mail Listesi nesnesi ismi |
| email | string | ✓ | E-mail bilgisi  |
| lastMailSentDate | string (date-time) |  | Son Gönderim Tarihi |
| creatorIpAddress | string |  | Mail oluşturucu ip adresi |
| maillistGroup | [MaillistGroup](#schema-maillistgroup) | ✓ |  |

---

<h3 id='schema-posaccount'>PosAccount</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | id |
| bank | integer |  | bank |
| cardName | string |  | cardName |
| cardLogo | string |  | cardLogo |
| status | integer |  | status<br>İzin verilen değerler: `0`, `1` |
| settings | string | ✓ | settings |
| permit | integer |  | permit<br>İzin verilen değerler: `0`, `1` |
| threedStatus | integer |  | threedStatus<br>İzin verilen değerler: `0`, `1`, `2` |
| paynet | integer |  | paynet<br>İzin verilen değerler: `0`, `1` |
| segment | integer |  | segment<br>İzin verilen değerler: `0`, `1` |
| payu | integer |  | payu<br>İzin verilen değerler: `0`, `1` |
| ipara | integer |  | ipara<br>İzin verilen değerler: `0`, `1` |
| turkPara | integer |  | turkPara<br>İzin verilen değerler: `0`, `1` |
| hepsiPay | integer |  | hepsiPay<br>İzin verilen değerler: `0`, `1` |
| boschSanalPos | integer |  | boschSanalPos<br>İzin verilen değerler: `0`, `1` |
| payTr | integer |  | payTr<br>İzin verilen değerler: `0`, `1` |
| paytrek | integer |  | paytrek<br>İzin verilen değerler: `0`, `1` |
| wirecard | integer |  | wirecard<br>İzin verilen değerler: `0`, `1` |
| sipay | integer |  | sipay<br>İzin verilen değerler: `0`, `1` |
| moka | integer |  | moka<br>İzin verilen değerler: `0`, `1` |
| vepara | integer |  | vepara<br>İzin verilen değerler: `0`, `1` |
| faturamatik | integer |  | faturamatik<br>İzin verilen değerler: `0`, `1` |
| unitedPay | integer |  | unitedPay<br>İzin verilen değerler: `0`, `1` |
| paratika | integer |  | paratika<br>İzin verilen değerler: `0`, `1` |
| akode | integer |  | akode<br>İzin verilen değerler: `0`, `1` |
| papel | integer |  | <br>İzin verilen değerler: `0`, `1` |
| posFix | integer |  | <br>İzin verilen değerler: `0`, `1` |
| posMode | string |  | posMode<br>İzin verilen değerler: `test`, `prod` |
| authType | string |  | authType<br>İzin verilen değerler: `Auth`, `PreAuth` |
| extraRateMinimumLimit | number (float) | ✓ | extraRateMinimumLimit |
| installmentLimit | number (float) | ✓ | installmentLimit |
| threedType | string | ✓ | threedType<br>İzin verilen değerler: `3D`, `3DPAY`, `3D_FULL`, `3DHOSTING`, `3D_OOS_PAY` |
| sortOrder | integer |  | sortOrder |

---

<h3 id='schema-shippingprovider'>ShippingProvider</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Teslimat hizmeti sağlayıcısı nesnesi kimlik değeri. |
| code | string |  | Teslimat hizmeti sağlayıcısı kodu. Benzersiz olmalıdır. |
| name | string |  | Teslimat hizmeti sağlayıcısı nesnesi için isim değeri. |
| trackingUrl | string |  | Kargo takip url. |
| trackingFormMethod | string |  | Kargo takip formu almak için kullanılacak method.<br>İzin verilen değerler: `get`, `post` |
| payload | string |  | İlgili kargo takip formu almak için kullanılacak yük. |
| settings | array[[ShippingProviderSetting](#schema-shippingprovidersetting)] |  | Teslimat hizmeti sağlayıcısı için ayarlar. |

---

<h3 id='schema-label'>Label</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Kişisel etiket nesnesi kimlik değeri |
| name | string | ✓ | Kişisel etiket Adı |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| sortOrder | integer | ✓ | Kişisel etiket nesnesi için sıralama değeri. |
| status | integer | ✓ | Kişisel etiket nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| hasChildren | integer | ✓ | Kişisel etiket nesnesinin alt etiket barındırma durumu. Bu değer otomatik oluşturulur.<br>İzin verilen değerler: `0`, `1` |
| pageTitle | string |  | Kişisel etiket nesnesi sayfa başlığı. |
| metaDescription | string |  |  |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| tree | string |  | tree |
| parent | [Label](#schema-label) |  |  |
| children | object |  | Sahip olunan alt kategoriler listesi |
| updatedAt | string (date-time) |  | Kişisel etiket nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Kişisel etiket nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-merchantpoll'>MerchantPoll</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Merchant anketi nesnesi kimliği |
| status | integer | ✓ | Merchant anketi nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| day | integer | ✓ | Gün değeri |
| category | [Category](#schema-category) | ✓ |  |

---

<h3 id='schema-cartitem'>CartItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sepet kalemi nesnesi kimlik değeri. |
| productName | string |  | Sepet kalemi nesnesine ait ürün nesnesi adı |
| isProductPromotioned | integer | ✓ | Sepet kalemi nesnesine ait ürün nesnesi promosyon durumu<br>İzin verilen değerler: `0`, `1` |
| price | number (float) |  | Sepet kalemi nesnesi fiyatı. |
| sku | string |  |  |
| quantity | number (float) | ✓ | Sepetteki kalem adedi. |
| product | [Product](#schema-product) | ✓ |  |
| cart | [Cart](#schema-cart) | ✓ |  |
| cartItemSubscription | [CartItemSubscription](#schema-cartitemsubscription) |  |  |
| selections | array[[CartItemAttribute](#schema-cartitemattribute)] |  | Ek özellik nesnesi. |
| customizations | array[[CartItemAttribute](#schema-cartitemattribute)] |  | Sepet kalemi özelleştirmeleri |
| updatedAt | string (date-time) |  | Sepet kalemi nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Sepet kalemi nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-instagramshop'>InstagramShop</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | id |
| mediaId | string |  | mediaId |
| mediaType | string |  | mediaType |
| imageList | object |  | imageList |
| videoList | object |  | videoList |
| caption | string |  | caption |
| mediaLink | string | ✓ | mediaLink |
| status | integer | ✓ |  nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ |  nesnesi için sıralama değeri. |
| externalLink | string |  | externalLink |
| mediaCreatedTime | string (date-time) |  | mediaCreatedTime |
| products | array[[Product](#schema-product)] |  | Ürün nesnesi listesi |
| updatedAt | string (date-time) |  | Hediye çeki nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  | Hediye çeki nesnesi oluşturulma zamanı. |

---

<h3 id='schema-orderitemsubscription'>OrderItemSubscription</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş kalemi aboneliği kimlik değeri. |
| subscription | [Subscription](#schema-subscription) | ✓ |  |

---

<h3 id='schema-country'>Country</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ülke nesnesi kimlik değeri. |
| name | string |  | Ülke nesnesi için isim değeri. |
| code | string |  | Ülke nesnesi için tanımlı 2 harfli kod. |
| status | integer | ✓ | Ülkenin aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| selectedLanguage | string |  |  |
| selectedCurrency | string |  |  |

---

<h3 id='schema-invoicesetting'>InvoiceSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| formWidth | string |  | Fatura Formu Toplam Genişliği (cm) |
| formHeight | string |  | Fatura Form Yüksekliği (cm) |
| seriNoCaption | string |  | Seri No Başlığı |
| orderIdCaption | string |  | Sipariş No Başlığı |
| dateCaption | string |  | Tarih Başlığı |
| irsaliyeDateCaption | string |  | İrsaliye Tarih Başlığı |
| productLabelCaption | string |  | Ürün Başlığı |
| stockCodeCaption | string |  | Stok Kodu Başlığı |
| barCodeCaption | string |  | Barkod Başlığı |
| quantityCaption | string |  | Miktar Başlığı |
| unitPriceCaption | string |  | Birim Fiyat Başlığı |
| kdvCaption | string |  | KDV Başlığı |
| priceCaption | string |  | Fiyat Başlığı |
| matrahCaption | string |  | Matrah Başlığı |
| subTotalCaption | string |  | Ara Toplam Başlığı |
| totalAmountCaption | string |  | Genel Toplam Başlığı |
| taxDesignCaption | string |  | Kdv Tutar Başlığı |
| priceStringCaption | string |  | Yazı ile Fiyat Başlığı |
| generalBillingDesign | string |  | Genel Toplam Tasarımı |
| logoCaption | string |  | Logo Başlığı |
| logoSource | string |  | Logo Kaynak Dosyası |
| addressCaption | string |  | Adres Başlığı |
| address | string |  | Adres Bilgisi |
| phoneCaption | string |  | Telefon Başlığı |
| faxCaption | string |  | Faks Başlığı |
| buyerCaption | string |  | Alıcı Bilgileri Başlığı |
| taxPlaceCaption | string |  | Vergi Dairesi Başlığı |
| taxIdCaption | string |  | Vergi No Başlığı |
| tcIdCaption | string |  | Tc No Başlığı |
| buyerInformation | string |  | Alıcı Bilgileri |
| invoiceNoteCaption | string |  | Fatura Notu Başlığı |
| invoiceNote | string |  | Fatura Notunuz |
| fontSize | string |  | Fatura Font Boyutu (px) |
| productContainerHeight | string |  | Ürün İçerik Alanının Yüksekliği |
| paymentTypeCaption | string |  | Ödeme Tipi Başlığı |
| stockTypeCaption | string |  | Teslimat Adresi Başlığı |
| shippingAddressCaption | string |  | shippingAddressCaption |
| singleFormWidth | string |  | Tek Fatura Formu Genişliği (cm) |
| divider | string |  | 2 Fatura Arası Genişlik (cm) |
| irsaliyeNumberCaption | string |  | İrsaliye Numara Başlığı |
| customTaxDesignCaption | string |  | Ek Vergi Tutar Başlığı |

---

<h3 id='schema-blogcategory'>BlogCategory</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Blog kategorisi nesnesi kimlik değeri. |
| title | string | ✓ | Blog kategorisi başlığı. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir.  |
| pageTitle | string |  | Blog kategorisi nesnesi sayfa başlığı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir. |
| blockVisibility | integer | ✓ | Blog kategorisi blok durumu.<br>İzin verilen değerler: `0`, `1` |
| status | integer | ✓ | Blog kategorisinin aktiflik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| parent | [BlogCategory](#schema-blogcategory) |  |  |
| hasChildren | integer | ✓ | Blog kategorisi nesnesinin alt kategori barındırma durumu. Bu değer otomatik oluşturulur.<br>İzin verilen değerler: `0`, `1` |
| children | object |  | children |
| createdAt | string (date-time) |  | Blog kategorisi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Blog kategorisi nesnesinin güncellenme zamanı. |

---

<h3 id='schema-paymentprovidersetting'>PaymentProviderSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme altyapısı sağlayıcısı ayarı nesnesi kimlik değeri. |
| varKey | string |  | Ödeme altyapısı sağlayıcısı ayarı nesnesi için değişken anahtarı. |
| varValue | string | ✓ | Ödeme altyapısı sağlayıcısı ayarı nesnesi için değişken değeri. |
| paymentProvider | [PaymentProvider](#schema-paymentprovider) |  |  |

---

<h3 id='schema-preference'>Preference</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Tanımlamalar nesnesi kimlik değeri |
| varKey | string |  | Tanımlamalar nesnesi seçeneği |
| varValue | string | ✓ | Tanımlamalar nesnesi seçeneği değeri |

---

<h3 id='schema-installedapplication'>InstalledApplication</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| applicationId | integer |  |  |
| applicationName | string |  |  |
| applicationSmallLogo | string |  |  |
| applicationLogo | string |  |  |
| applicationImages | object |  |  |
| applicationShortDetail | string |  |  |
| applicationUser | object |  |  |
| applicationEmbedded | boolean |  |  |
| applicationVisibilityScope | string |  |  |
| applicationRenewDate | string (date-time) |  |  |
| applicationParentId | integer |  |  |
| applicationParentName | string |  |  |
| applicationParentLogo | string |  |  |
| applicationParentSmallLogo | string |  |  |
| applicationParentImages | object |  |  |
| applicationParentSlug | string |  |  |
| embeddedUrl | string |  |  |
| authUrl | string |  |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-application'>Application</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| name | string |  |  |
| smallLogo | string |  |  |
| logo | string |  |  |
| images | object |  |  |
| price | number (float) |  |  |
| shortDetail | string |  |  |
| slug | string |  |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-productcustomizationfieldoption'>ProductCustomizationFieldOption</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün özelleştirme alanı seçenekleri nesnesi kimlik değeri |
| name | string | ✓ | Ürün özelleştirme seçenekleri alanı ismi |
| value | string | ✓ | Ürün özelleştirme alanı seçenekleri değeri |
| productCustomizationField | [ProductCustomizationField](#schema-productcustomizationfield) | ✓ |  |

---

<h3 id='schema-admin-model-banner'>Admin-Model-Banner</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| name | string | ✓ |  |
| imageFile | string |  |  |
| imageUrl | string |  |  |
| targetUrl | string |  |  |
| targetBlankStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| altAttribute | string |  |  |
| status | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| attachment | string |  |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-question'>Question</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| product | [Product](#schema-product) | ✓ |  |
| member | [Member](#schema-member) | ✓ |  |
| content | string | ✓ |  |
| answerContent | string |  |  |
| status | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| richSnippetStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| mailStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| isAnonymous | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| answerDate | string (date-time) |  |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-languages'>Languages</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ |  |
| name | string |  |  |
| code | string |  |  |
| status | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| noIndexStatus | integer | ✓ | <br>İzin verilen değerler: `0`, `1` |
| internationalName | string |  |  |

---

<h3 id='schema-paymenttype'>PaymentType</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ödeme tipi nesnesi kimlik değeri. |
| name | string |  | Ödeme tipi nesnesi için isim değeri. |
| sortOrder | integer | ✓ | Ödeme tipi nesnesi için sıralama değeri. |

---

<h3 id='schema-town'>Town</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | İlçe nesnesi kimlik değeri. |
| name | string | ✓ | İlçe nesnesi için isim değeri. |
| status | integer | ✓ | İlçenin aktiflik bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| location | [Location](#schema-location) | ✓ |  |
| townGroup | [TownGroup](#schema-towngroup) | ✓ |  |

---

<h3 id='schema-webproperty'>WebProperty</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | string | ✓ | Google analytics web property kimlik değeri. |
| name | string | ✓ | Google analytics web property ismi. |

---

<h3 id='schema-managementaccount'>ManagementAccount</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | string | ✓ | Google Analytics işletme hesabı nesnesi kimlik değeri |
| name | string | ✓ | Google Analytics işletme hesabı nesnesi ismi |

---

<h3 id='schema-footer'>Footer</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| imageUrl | string |  | Sayfa Altı Görseli |
| align | string | ✓ | Hizalama<br>İzin verilen değerler: `left`, `middle`, `right` |
| attachment | string |  | attachment |

---

<h3 id='schema-logo'>Logo</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| imageUrl | string |  | Logo imajı URL'i |
| align | string | ✓ | Logo hizalama durumu<br>İzin verilen değerler: `left`, `middle`, `right` |
| attachment | string |  | Logo dosyası |

---

<h3 id='schema-banner'>Banner</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| imageUrl | string |  | Banner nesnesinin görselinin url'i. |
| align | string | ✓ | <br>İzin verilen değerler: `left`, `middle`, `right` |
| attachment | string |  | Banner Dosyası içeriği. |

---

<h3 id='schema-link'>Link</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| sortOrder | integer | ✓ | Link nesnesi için sıralama değeri. |
| name | string |  | Link nesnesi ismi. |
| type | string | ✓ | Link nesnesi tipi.<br>İzin verilen değerler: `page`, `url` |
| url | string |  | URL değeri |
| page | [Page](#schema-page) |  |  |

---

<h3 id='schema-seodetail'>SeoDetail</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| pageTitle | string | ✓ | Sayfa başlığı. |
| metaKeywords | string | ✓ | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| metaDescription | string | ✓ | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| useAdvancedSeoOption | integer |  | Gelişmiş seo ayarları kullanımı<br>İzin verilen değerler: `0`, `1` |
| changeFreq | string |  | Değişim sıklığı.<br>İzin verilen değerler: `daily`, `hourly`, `weekly`, `yearly`, `monthly`, `always`, `never` |
| priority | string |  | Öncelik<br>İzin verilen değerler: `0`, `0.1`, `0.2`, `0.3`, `0.3`, `0.4`, `0.5`, `0.6`, `0.7`, `0.8`, `0.9`, `1` |

---

<h3 id='schema-orderrefund'>OrderRefund</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | Sipariş iade durumu<br>İzin verilen değerler: `0`, `1` |
| dayLimit | integer | ✓ | İade gün limiti |
| dateOption | string | ✓ | <br>İzin verilen değerler: `order_date`, `delivery_date` |

---

<h3 id='schema-whatsapp'>Whatsapp</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | Whatsapp sipariş sistemi aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| phoneNumber | string |  | Telefon numarası. |
| message | string |  | Mesaj |
| position | string |  | Whatsapp pencere konumu.<br>İzin verilen değerler: `right`, `left` |
| showInHomepage | integer |  | Anasayfada gösterim durumu.<br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-abandonedcart'>AbandonedCart</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | <br>İzin verilen değerler: `0`, `1` |
| firstDeliveryTime | integer | ✓ | <br>İzin verilen değerler: `20`, `30`, `45`, `60`, `180`, `360`, `1440` |

---

<h3 id='schema-criticalstock'>CriticalStock</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | Kritik stok nesnesi aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| quantity | integer | ✓ | Kritik stok nesnesi miktarı |

---

<h3 id='schema-facebookmessenger'>FacebookMessenger</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | Facebook messenger kullanım durumu<br>İzin verilen değerler: `0`, `1` |
| facebookPage | string |  | Facebook sayfası |
| showInHomepage | integer |  | Ana sayfada göster<br>İzin verilen değerler: `0`, `1` |
| position | string |  | Facebook messenger sayfada pozisyonu<br>İzin verilen değerler: `right`, `left` |

---

<h3 id='schema-mercansuperapp'>MercanSuperApp</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | <br>İzin verilen değerler: `0`, `1` |
| clientId | string |  |  |
| clientSecret | string |  |  |
| returnUrl | string |  |  |

---

<h3 id='schema-watermark'>Watermark</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| status | integer |  | Filigran Kullanımı durumu. Ürün görsellerine filigran uygulanabilmesi için Görsel Optimizasyonu ayarının açık olması gereklidir.<br>İzin verilen değerler: `0`, `1` |
| type | string |  | Filigran Tipi. Bu ayarı aktif ederek yükleyeceğiniz ürün görsellerinize metin veya görsel olarak filigran ekleyebilirsiniz. Bu ayar aktif edilmeden önce yüklenen ürün görselleri bu işlemden etkilenmez.<br>İzin verilen değerler: `text`, `image` |
| text | string |  | Filigran Yazısı. |
| textRotation | string |  | Filigran Eğim Değeri.<br>İzin verilen değerler: `centered_horizontal`, `cross` |
| textOpacity | string |  | Filigran Şeffaflık Değeri<br>İzin verilen değerler: `less`, `normal`, `much` |
| textColor | string |  | Filigran Renk Değeri<br>İzin verilen değerler: `black`, `white` |
| imageRotation | string |  | Filigran Eğim Değeri<br>İzin verilen değerler: `cross`, `straight` |
| imageLocation | string |  | Filigran Konumu.<br>İzin verilen değerler: `left_top`, `right_top`, `left_bottom`, `right_bottom`, `middle` |
| imageOpacity | string |  | Filigran Şeffaflık Değeri<br>İzin verilen değerler: `less`, `normal`, `much`, `full` |
| imageUrl | string |  | Uygulanacak Resim URL'i |
| attachment | string |  | Uygulanacak Resim dosyası. |

---

<h3 id='schema-creator'>Creator</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Oluşturan nesnesi kimlik değeri. |
| username | string |  | Oluşturan nenesi adı |
| type | string |  | Oluşturan nenesi tipi<br>İzin verilen değerler: `user`, `member` |

---

<h3 id='schema-signuppreference'>SignupPreference</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| varKey | string |  | <br>İzin verilen değerler: `use_gender`, `use_gender_required`, `use_repeat_password`, `use_repeat_password_required`, `use_cell_phone`, `use_cell_phone_required`, `member_signup_birthday_field`, `member_signup_birthday_field_required` |
| varValue | integer |  | <br>İzin verilen değerler: `0`, `1` |

---

<h3 id='schema-order'>Order</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Sipariş nesnesi kimlik değeri. |
| customerFirstname | string | ✓ | Müşterinin ismi. |
| customerSurname | string | ✓ | Müşterinin soy ismi. |
| customerEmail | string | ✓ | Müşterinin e-mail adresi. |
| customerPhone | string | ✓ | Müşterinin telefon numarası. |
| paymentTypeName | string | ✓ | Siparişin ödeme tipi. |
| paymentProviderCode | string | ✓ | Siparişin ödeme altyapısı sağlayıcısının kodu. Ön tanımlıdır. API otomatik oluşturur. |
| paymentProviderName | string | ✓ | Siparişin ödeme altyapısı sağlayıcısının adı. Ön tanımlıdır. API otomatik oluşturur. |
| paymentGatewayCode | string | ✓ | Siparişin ödeme kanalının kodu. Ön tanımlıdır. API otomatik oluşturur. |
| paymentGatewayName | string | ✓ | Siparişin ödeme kanalının adı. Ön tanımlıdır. API otomatik oluşturur. |
| bankName | string |  | Siparişin banka adı. Ön tanımlıdır. API otomatik oluşturur. |
| clientIp | string |  | Müşterinin IP adresi. |
| userAgent | string |  | Siparişin gerçekleştiği tarayıcı bilgisi. |
| currency | string | ✓ | Kur bilgisi. |
| currencyRates | string | ✓ | Kur oranları. |
| amount | number (float) | ✓ | Siparişin vergi hariç fiyatı. |
| couponDiscount | number (float) | ✓ | Siparişte kullanılan hediye çeki indirimi tutarı. |
| taxAmount | number (float) | ✓ | Siparişin vergi tutarı. |
| totalCustomTaxAmount | number (float) | ✓ | Toplam özel vergi tutarı. |
| promotionDiscount | number (float) | ✓ | Siparişte kullanılan promosyon indirimi tutarı. |
| generalAmount | number (float) | ✓ | Siparişin genel fiyat tutarı. orderAmount, couponDiscount, taxAmount, promotionDiscount, shippingAmount, additionalServiceAmount tutarlarının toplamı. |
| shippingAmount | number (float) | ✓ | Siparişin teslimat ücreti. |
| additionalServiceAmount | number (float) | ✓ | Siparişin ek hizmet bedeli ücreti. |
| finalAmount | number (float) | ✓ | Siparişin son ödeme tutarı. generalAmount değerinin üzerine taksitten kaynaklı vade farkı bedeli eklenmiş hali. |
| sumOfGainedPoints | number (float) | ✓ | Siparişten kazanılan puan tutarı. |
| installment | integer | ✓ | Siparişin taksit adeti. |
| installmentRate | number (float) | ✓ | Siparişin taksit oranı. |
| extraInstallment | integer | ✓ | Siparişin ek taksit adeti. |
| transactionId | string | ✓ | Siparişin numarası. |
| hasUserNote | integer | ✓ | Siparişin müşteri notuna sahiplik durumu.<br>İzin verilen değerler: `0`, `1` |
| status | string | ✓ | Sipariş durumu.<br>İzin verilen değerler: `deleted`, `waiting_for_approval`, `approved`, `fulfilled`, `cancelled`, `delivered`, `on_accumulation`, `waiting_for_payment`, `being_prepared`, `refunded`, `personal_status_1`, `personal_status_2`, `personal_status_3` |
| paymentStatus | string | ✓ | Ödeme durumu bilgisi.<br>İzin verilen değerler: `in_transaction`, `failed`, `success` |
| errorMessage | string |  | Siparişin hata mesajı. |
| sessionId | string |  | sessionId |
| deviceType | string | ✓ | Siparişin gerçekleştiği cihaz bilgisi.<br>İzin verilen değerler: `desktop`, `mobile`, `tablet` |
| referrer | string |  | Siparişe yönlendiren web-sitesi adresi. Yönlendirmeyi yapan web-sitesinin tam URL bilgisini de içerir. API otomatik oluşturur. |
| invoicePrintCount | integer | ✓ | Sipariş için alınan fatura çıktısı adedi. |
| useGiftPackage | integer | ✓ | Hediye paketi istenilmesi durumu.<br>İzin verilen değerler: `0`, `1` |
| giftNote | string |  | Hediye notu. |
| memberGroupName | string |  | Üye grubu adı. |
| usePromotion | integer | ✓ | Promosyon kullanılma durumu.<br>İzin verilen değerler: `0`, `1` |
| shippingProviderCode | string |  |  |
| shippingProviderName | string |  | Siparişin teslimat hizmeti sağlayıcısı adı. Ön tanımlıdır. |
| shippingCompanyName | string |  | Siparişin kargo firması adı. Ön tanımlıdır. |
| shippingPaymentType | string |  | Siparişin kargo ödeme tipi.<br>İzin verilen değerler: `cash_on_delivery`, `standart_delivery`, `not_applicable` |
| shippingTrackingCode | string |  | Siparişin kargo takip kodu. |
| source | string | ✓ | Siparişin kaynak bilgisi. Siparişin kaynak yazılımını belirtir. |
| createdAt | string (date-time) |  | Sipariş nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Sipariş nesnesinin güncellenme zamanı. |
| maillist | [Maillist](#schema-maillist) |  |  |
| member | [Member](#schema-member) |  |  |
| orderDetails | array[[OrderDetail](#schema-orderdetail)] |  | Sipariş detayı nesnesi |
| orderCustomTaxLines | array[[OrderCustomTaxLine](#schema-ordercustomtaxline)] |  | Özel vergi oranları nesnesi |
| orderItems | array[[OrderItem](#schema-orderitem)] |  | Sipariş kalemi nesnesi listesi |
| shippingAddress | [ShippingAddress](#schema-shippingaddress) |  |  |
| billingAddress | [BillingAddress](#schema-billingaddress) |  |  |
| fraudOrder | [FraudOrder](#schema-fraudorder) |  |  |
| promotion | [Promotion](#schema-promotion) |  |  |
| autoPayback | integer |  | autoPayback<br>İzin verilen değerler: `0`, `1` |
| next | string |  |  |
| prev | string |  |  |

---

<h3 id='schema-product'>Product</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ürün nesnesi kimlik değeri. |
| name | string | ✓ | Ürünün adı |
| fullName | string |  | Ürünün tam adı. Bu değer bir varyant için ana ürünün adı ve varyant adının birleşiminden oluşur. Örneğin Kırmızı varyantı için Kalem Kırmızı olur. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| sku | string | ✓ | Ürünün stok kodu. ID değeri gibi eşsiz bir kimlik değeridir. |
| barcode | string |  | Ürünün barkodu. |
| stockAmount | number (float) | ✓ | ürünün stok miktarı |
| price1 | number (float) | ✓ | Ürünün Fiyat 1 bilgisi. |
| currency | [Currency](#schema-currency) | ✓ |  |
| discount | number (float) |  | Ürünün indirim değeri. Örneğin; discountType 1 olursa %5, 0 olursa 5 tl anlamına gelir. |
| discountType | integer | ✓ | Ürünün indirim tipini belirtir.<br>İzin verilen değerler: `0`, `1` |
| moneyOrderDiscount | number (float) | ✓ | Havale indirimi yüzdesi. |
| buyingPrice | number (float) |  | Ürünün alış fiyatı. |
| marketPriceDetail | string |  | Piyasa Fiyatı detayı |
| taxIncluded | integer | ✓ | Ürün fiyatlarına KDV dahil olup olmadığın belirten değer.<br>İzin verilen değerler: `0`, `1` |
| tax | integer |  | Ürünün KDV oranı. |
| warranty | integer |  | Ürünün garanti süresi. |
| volumetricWeight | number (float) |  | Ürünün desisi. |
| stockTypeLabel | string | ✓ | Ürünün stok tipi.<br>İzin verilen değerler: `Piece`, `cm`, `Dozen`, `gram`, `kg`, `Person`, `Package`, `metre`, `m2`, `pair` |
| customShippingDisabled | integer | ✓ | Kargo ücreti için sistemin kullanılıp kullanılmama değerini belirtir.<br>İzin verilen değerler: `0`, `1` |
| customShippingCost | number (float) |  | Sistem seçeneği seçilmemişse ürün için girilmesi gereken kargo ücreti. |
| distributor | string |  | Ürünün distribütör bilgisi |
| hasGift | integer | ✓ | Ürünün hediyeli olup olmadığını belirtir.<br>İzin verilen değerler: `0`, `1` |
| gift | string |  | Ürünün yanında hediye olarak vermek istediğiniz hediyeyi bu alanda metin ya da rakamla belirtebilirsiniz. |
| status | integer | ✓ | Ürün nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| hasOption | integer | ✓ | Ürünün varyantının olup olmadığı değerini belirtir. (API otomatik olarak bu değeri atar.)<br>İzin verilen değerler: `0`, `1` |
| shortDetails | string |  | Ürünün kısa açıklaması. |
| searchKeywords | string |  | Ziyaretçilerinizin site içindeki ürünlerinizin hangi anahtar kelimelerine göre bulacağını belirler.Kelimeler arasında virgül bırakılarak girilmelidir.(etiket1,etiket2) |
| installmentThreshold | string |  | Ürüne özel yasal veya isteğe bağlı belirleyebileceğiniz taksit adedini belirtir. Ürüne özel bir belirleme yapmak istemiyorsanız '-' işareti kullanabilirsiniz. |
| homeSortOrder | integer |  | Anasayfa vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| popularSortOrder | integer |  | Popüler ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| brandSortOrder | integer |  | Marka vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| featuredSortOrder | integer |  | Sponsor ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| campaignedSortOrder | integer |  | Kampanyalı ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| newSortOrder | integer |  | Yeni ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| discountedSortOrder | integer |  | İndirimli ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz. |
| categoryShowcaseStatus | integer | ✓ | Kategori Gösterim Tipi<br>İzin verilen değerler: `0`, `1` |
| midblockSortOrder | integer |  | Vitrin Blokları sırası |
| pageTitle | string |  | Ürün nesnesinin etiket başlığı. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir. |
| parent | [ManualRelation](#schema-manualrelation) |  |  |
| brand | [Brand](#schema-brand) |  |  |
| detail | [ProductDetail](#schema-productdetail) |  |  |
| button | [ProductButton](#schema-productbutton) |  |  |
| countDown | [ProductCountDown](#schema-productcountdown) |  |  |
| specialInfo | [ProductSpecialInfo](#schema-productspecialinfo) |  |  |
| specGroup | [SpecGroup](#schema-specgroup) |  |  |
| protection | [ProductProtection](#schema-productprotection) |  |  |
| categories | array[[Category](#schema-category)] |  | categories |
| prices | array[[ProductPrice](#schema-productprice)] |  | prices |
| distributors | array[[Distributor](#schema-distributor)] |  | distributors |
| extraInfos | array[[ProductExtraInfo](#schema-productextrainfo)] |  | extraInfos |
| images | array[[ProductImage](#schema-productimage)] |  | images |
| tags | array[[Tag](#schema-tag)] |  | tags |
| selectionGroups | array[[SelectionGroup](#schema-selectiongroup)] |  | selectionGroups |
| optionGroups | array[[OptionGroup](#schema-optiongroup)] |  | optionGroups |
| labels | array[[Label](#schema-label)] |  | labels |
| offeredProducts | array[[OfferedProduct](#schema-offeredproduct)] |  | offeredProducts |
| combineProducts | array[[CombineProduct](#schema-combineproduct)] |  | combineProducts |
| customizationGroups | array[[ProductCustomizationGroup](#schema-productcustomizationgroup)] |  | customizationGroups |
| midblock | [Midblock](#schema-midblock) |  |  |
| seoSetting | [SeoSetting](#schema-seosetting) |  |  |
| comments | array[[ProductComment](#schema-productcomment)] |  |  |
| children | array[[Product](#schema-product)] |  | children |
| updatedAt | string (date-time) |  | Ürün nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Ürün nesnesinin oluşturulma zamanı. |
| productExtraFields | array[[ProductExtraField](#schema-productextrafield)] |  |  |
| next | string |  |  |
| prev | string |  |  |

---

<h3 id='schema-orderdetail'>OrderDetail</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş detayı nesnesi kimlik değeri. |
| varKey | string | ✓ | Sipariş detayı nesnesi için değişken anahtarı. |
| varValue | string | ✓ | Sipariş detayı nesnesi için değişken değeri. |
| order | [Order](#schema-order) | ✓ |  |

---

<h3 id='schema-partnershipurl'>PartnershipUrl</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| url | string |  | Gelir ortaklığı nesnesi URL adresi |

---

<h3 id='schema-package'>Package</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Paket nesnesi kimlik değeri |
| name | string | ✓ | Paket nesnesi ismi |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| description | string |  | Paket nesnesi açıklama alanı |
| items | array[[PackageItem](#schema-packageitem)] |  | Paket kalemi nesnesi listesi |
| status | integer | ✓ | Paket aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| pageTitle | string |  | Sayfa başlığı |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| updatedAt | string (date-time) |  | Paket nesnesi  güncellenme zamanı. |
| createdAt | string (date-time) |  | Paket nesnesi oluşturulma zamanı. |

---

<h3 id='schema-productcustomizationgroup'>ProductCustomizationGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün özelleştirme grubu nesnesi kimlik değeri. |
| name | string | ✓ | Ürün özelleştirme grubu nesnesi ismi. |
| sortOrder | integer | ✓ | Ürün özelleştirme grubu sırsı. |
| fields | array[[ProductCustomizationField](#schema-productcustomizationfield)] | ✓ | Ürün özelleştirme alanı nesnesi |
| updatedAt | string (date-time) |  | Ürün nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Ürün özelleştirme grubu nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-filtermenusetting'>FilterMenuSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Filtre Bloğu Seçenekleri nesnesi kimlik değeri |
| varKey | string |  | Filtre Bloğu Seçenekleri nesnesi seçeneği |
| varValue | string |  | Filtre Bloğu Seçenekleri nesnesi seçeneği değeri |
| filterMenu | [FilterMenu](#schema-filtermenu) | ✓ |  |

---

<h3 id='schema-productprice'>ProductPrice</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ürün fiyatı nesnesi kimlik değeri. |
| type | integer | ✓ | Ürüne tanımlanmış fiyat seçenekleri<br>İzin verilen değerler: `2`, `3`, `4`, `5`, `6` |
| value | number (float) | ✓ | Ürün fiyatı değeri. |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-cart'>Cart</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sepet nesnesi kimlik değeri. |
| sessionId | string | ✓ | Sepetin son durumunu belirten ilgili nesnenin benzersiz kimlik değeri. |
| member | [Member](#schema-member) |  |  |
| coupon | [Coupon](#schema-coupon) |  |  |
| promotion | [Promotion](#schema-promotion) |  |  |
| subTotal | number (float) |  | Sepet nesnesi toplam fiyatı |
| couponDiscount | number (float) |  | Kupon indirimi miktarı |
| amountWithCouponDiscount | number (float) |  | Kupon indirimi yansımış sepet nesnesi fiyatı |
| taxAmount | number (float) |  | Vergi miktarı |
| amountWithTax | number (float) |  | Vergi yansımış sepet nesnesi fiyatı |
| promotionDiscount | number (float) |  | Promosyon indirim miktarı |
| amountWithPromotionDiscount | number (float) |  | Promosyon indirimi yansımış sepet nesnesi fiyatı |
| items | array[[CartItem](#schema-cartitem)] |  | Sepet kalemi nesnelerini barındıran liste. |
| updatedAt | string (date-time) |  | Sepet nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Sepet nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-abandonedorder'>AbandonedOrder</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| cart | [Cart](#schema-cart) |  |  |
| preOrderInfo | [PreOrderInfo](#schema-preorderinfo) |  |  |
| sessionId | string | ✓ | Terkedilen Sepetin son durumunu belirten ilgili nesnenin benzersiz kimlik değeri. |
| mailStatus | integer | ✓ | Terkedilen Sipariş hatırlatma mailinin gönderilme durumu.<br>İzin verilen değerler: `0`, `1` |
| customerFirstname | string | ✓ | Müşterinin ismi. |
| customerSurname | string | ✓ | Müşterinin soy ismi. |
| customerEmail | string | ✓ | Müşterinin e-mail adresi. |
| member | [Member](#schema-member) |  |  |
| priceWithTax | number (float) | ✓ |  |
| updatedAt | string (date-time) |  | Terkedilen Sipariş nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Terkedilen Sipariş nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-notifieduser'>NotifiedUser</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | id |
| user | [User](#schema-user) |  |  |
| notification | [Notification](#schema-notification) |  |  |
| isRead | integer | ✓ | isRead |

---

<h3 id='schema-entitymetafield'>EntityMetaField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Metafield nesnesi kimlik değeri. |
| customizationFieldId | integer | ✓ | Metafield nesnesi özelleştirme alanı kimlik değeri. |
| varKey | string | ✓ | Metafield nesnesi seçeneği |
| varValue | string | ✓ | Metafield nesnesi seçeneğinin değeri |
| createdAt | string (date-time) |  | Metafield nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Metafield nesnesinin güncellenme zamanı. |

---

<h3 id='schema-selection'>Selection</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Ek özellik nesnesi kimlik değeri. |
| title | string | ✓ | Ek özellik nesnesi başlığı. |
| sortOrder | integer |  | Ek özellik nesnesi sırası |
| selectionGroup | [SelectionGroup](#schema-selectiongroup) | ✓ |  |

---

<h3 id='schema-subscriptionproduct'>SubscriptionProduct</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Abonelikli ürün nesnesi kimlik değeri. |
| product | [Product](#schema-product) | ✓ |  |
| subscription | [Subscription](#schema-subscription) | ✓ |  |

---

<h3 id='schema-urlrouting'>UrlRouting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Url yonlendirme nesnesi kimlik değeri. |
| oldUrl | string | ✓ | Url yonlendirme nesnesi eski Url. |
| newUrl | string | ✓ | Url yonlendirme nesnesi yönlendirilen Url. |
| updatedAt | string (date-time) |  | Url yönlendirme nesnesinin güncellenme zamanı. |

---

<h3 id='schema-scripttag'>ScriptTag</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Script tag değişkenleri nesnesi kimlik değeri. |
| src | string | ✓ | Script tag değişkenleri Kaynağı. |
| createdAt | string (date-time) |  | Script tag değişkenleri nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Script tag değişkenleri nesnesinin güncellenme zamanı. |

---

<h3 id='schema-commonfiletranslation'>CommonFileTranslation</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| language | string | ✓ |  |
| notificationForm | string |  |  |
| userAgreement | string |  |  |
| personalDataAgreement | string |  |  |
| paymentAgreement | string |  |  |
| refundProcedure | string |  |  |
| salesCondition | string |  |  |

---

<h3 id='schema-smtppref'>SmtpPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| server | string | ✓ | server |
| username | string | ✓ | username |
| sender | string |  | sender |
| port | integer | ✓ | port |
| password | string | ✓ | password |
| secure | integer | ✓ | secure<br>İzin verilen değerler: `0`, `1`, `2` |
| provider | string | ✓ | <br>İzin verilen değerler: `tucows`, `uzmanposta` |
| mailEngine | string | ✓ | mailEngine<br>İzin verilen değerler: `ideasoft`, `gmail`, `yandex`, `other` |

---

<h3 id='schema-fraudorder'>FraudOrder</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Riskli sipariş nesnesi kimlik değeri |
| fraud | [FraudRisk](#schema-fraudrisk) | ✓ |  |
| order | [Order](#schema-order) | ✓ |  |

---

<h3 id='schema-seosetting'>SeoSetting</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Seo ayarları nesnesi kimlik değeri. |
| context | string | ✓ | Seo ayarları nesnesi içeriği.<br>İzin verilen değerler: `product`, `brand`, `blog`, `category`, `page` |
| contextItemId | integer | ✓ | Seo ayarları nesnesi içerik kalemi kimlik değeri. |
| jsonValue | object | ✓ | Seo ayarları nesnesi json formatında değeri. |
| updatedAt | string (date-time) |  | Promosyon nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Promosyon nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-dashboard'>Dashboard</h3>


---

<h3 id='schema-filtermenu'>FilterMenu</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Filtre Bloğu nesnesi kimlik değeri |
| name | string | ✓ | Filtre Bloğu nesnesi ismi |
| sortOrder | integer |  | Sıralama Seçeneği  |
| updatedAt | string (date-time) |  | Özel vergi oranları nesnesinin güncellenme zamanı. |
| parent | [ManualRelation](#schema-manualrelation) |  |  |
| status | integer |  | Filtre Bloğu Kullanımı<br>İzin verilen değerler: `0`, `1` |
| settings | array[[FilterMenuSetting](#schema-filtermenusetting)] |  | Filtre Bloğu Seçenekleri nesnesi |

---

<h3 id='schema-netgsm'>NetGsm</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| username | string | ✓ |  |
| password | string | ✓ |  |
| msgHeader | string |  |  |
| validMsgHeaders | object |  |  |
| remainingCredits | string |  |  |

---

<h3 id='schema-orderrefundrequestitem'>OrderRefundRequestItem</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş iptal talebi kalemi nesnesi kimlik değeri. |
| orderItem | [ManualRelation](#schema-manualrelation) |  |  |
| amount | number (float) |  | Sipariş iptal talebi istenen ürün miktarı. |
| reason | string |  | Sipariş iptal talebi sebebi. Tanımlı dört seçenekten biri seçilmelidir. |
| details | string |  | Sipariş iptal talebinin detaylı açıklaması. |
| paybackStatus | integer | ✓ | Geri ödeme durumu<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Sipariş iptal talebi kalemi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Sipariş iptal talebi kalemi nesnesinin güncellenme zamanı. |

---

<h3 id='schema-draftorder'>DraftOrder</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Manuel sipariş nesnesi kimlik değeri |
| name | string | ✓ | Manuel sipariş nesnesi için isim değeri. |
| code | string |  | Manuel sipariş kodu |
| member | [Member](#schema-member) |  |  |
| coupon | [Coupon](#schema-coupon) |  |  |
| items | array[[CartItem](#schema-cartitem)] | ✓ | Sepet kalemi nesnesi listesi |
| orderInfo | [PreOrderInfo](#schema-preorderinfo) |  |  |
| user | [User](#schema-user) |  |  |
| subTotal | number (float) |  | Ara toplam |
| couponDiscount | number (float) |  | Hediye çeki indirimi |
| amountWithCouponDiscount | number (float) |  | Hediye çeki indirimi uygulanmış toplam fiyat |
| shipmentAmount | number (float) |  | Kargo ücreti |
| customTaxAmount | number (float) |  | Özel vergi oranı uygulanmış fiyat |
| moneyOrderDiscountAmount | number (float) |  | Havale indirimi miktarı |
| taxAmount | number (float) |  | Vergi miktarı |
| amountWithTax | number (float) |  | Vergi eklenmiş toplam fiyat |
| createdAt | string (date-time) |  | Manuel sipariş nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Manuel sipariş nesnesinin güncellenme zamanı. |

---

<h3 id='schema-searchenginepref'>SearchEnginePref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| googleVerifyCode | string | ✓ | Google onaylama kodu. |
| googleAnalyticsRemarketingCode | string | ✓ | Site İzleme & Remarketing Kodu. |
| orderTrackingCode | string | ✓ | Sipariş takip Kodu. |
| cartTrackingCode | string | ✓ | Sepet takip Kodu. |
| productTrackingCode | string | ✓ | Ürün takip Kodu. |
| homepageTrackingCode | string | ✓ | Anasayfa takip Kodu. |
| memberTrackingCode | string | ✓ | Üye takip Kodu. |
| robotsTxt | string | ✓ | Robots.txt dosyası, ileri seviye kullanıcılar için tasarlanmış, arama motorlarının sitenizdeki belirli sayfaların taramasını önleyen bir metin dosyasıdır. Bu alan arama motoru performansınızı etkilemez. Standart olarak değişiklik yapmanıza gerek yoktur. |

---

<h3 id='schema-clientwebhook'>ClientWebhook</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Webhook nesnesi kimlik değeri. |
| client | [Client](#schema-client) |  |  |
| topic | string | ✓ | Webhook tetikleyen olay.<br>İzin verilen değerler: `product/delete`, `product/update`, `product/create`, `order/create`, `order/update`, `order/delete`, `payment/create`, `payment/update`, `payment/delete`, `member/delete`, `member/create`, `member/update`, `category/delete`, `category/create`, `category/update`, `member_group/create`, `member_group/update`, `member_group/delete`, `brand/create`, `brand/update`, `brand/delete`, `contract/create`, `contract/update`, `order_refund_request/create`, `order_refund_request/update`, `order_refund_request/delete`, `extra_pref/update`, `theme/create`, `theme/update`, `theme/delete`, `queue_process/create`, `queue_process/update` |
| address | string | ✓ | Bir olay meydana geldiğinde webhook aboneliğinin POST isteğini göndermesi gereken hedef URI. |
| fields | string |  | Webhook isteğine dönülecek alanların listesi |
| status | integer | ✓ | Webhook nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| createdAt | string (date-time) |  | Webhook nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Webhook nesnesinin güncellenme zamanı. |

---

<h3 id='schema-region'>Region</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Teslimat bölgesi kimlik değeri. |
| name | string |  | Teslimat bölgesi ismi |
| countries | array[[Country](#schema-country)] |  | Ülke nesnesi |

---

<h3 id='schema-resourceusage'>ResourceUsage</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  |  |
| date | string | ✓ |  |
| bandwidth | string | ✓ |  |
| request | string | ✓ |  |
| updatedAt | string (date-time) |  |  |
| createdAt | string (date-time) |  |  |

---

<h3 id='schema-productprotection'>ProductProtection</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Entegrasyon seçeneği nesnesi kimlik değeri. |
| isPriceProtected | integer | ✓ | Ürün fiyatının korumalı olup olmadığı bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| isStockProtected | integer | ✓ | Ürün stoğunun korumalı olup olmadığı bilgisini belirtir.<br>İzin verilen değerler: `0`, `1` |
| product | [Product](#schema-product) | ✓ |  |

---

<h3 id='schema-maillistgroup'>MaillistGroup</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Mail Listesi Grubu kimlik değeri |
| name | string | ✓ | Mail Listesi Grubu ismi |

---

<h3 id='schema-productextrafield'>ProductExtraField</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |
| varKey | string | ✓ |  |
| varValue | string |  |  |

---

<h3 id='schema-category'>Category</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Kategori nesnesi kimlik değeri. |
| name | string | ✓ | Kategori nesnesi için isim değeri. |
| slug | string |  | Slug değeri ilgili nesnenin Url değeridir. |
| sortOrder | integer | ✓ | Kategori nesnesi için sıralama değeri. |
| showcaseSortOrder | integer |  |  |
| status | integer | ✓ | Kategori nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| distributor | string |  | Her zaman null değer alır. Pratikte kullanımı yoktur. |
| distributorCode | string |  | Her zaman null değer alır. Pratikte kullanımı yoktur. |
| percent | number (float) |  | Kategori nesnesinin fiyat katsayısı. |
| imageFile | string |  | Kategori nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF |
| displayShowcaseContent | integer | ✓ | Kategori nesnesinin üst içerik metninin gösterim durumu.<br>İzin verilen değerler: `0`, `1`, `2` |
| showcaseContent | string |  | Kategori nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir. |
| showcaseContentDisplayType | integer | ✓ | Kategori nesnesinin üst içerik metninin gösterim tipi.<br>İzin verilen değerler: `1`, `2`, `3` |
| displayShowcaseFooterContent | integer | ✓ | Kategori Alt İçerik nesnesinin üst içerik metninin gösterim durumu.<br>İzin verilen değerler: `0`, `1`, `2` |
| showcaseFooterContent | string |  | Kategori nesnesinin alt içeriği. Admin paneli üzerinden düzenlenebilir. |
| showcaseFooterContentDisplayType | integer | ✓ | Kategori Alt İçerik metninin gösterim tipi.<br>İzin verilen değerler: `1`, `2`, `3` |
| hasChildren | integer | ✓ | Kategori nesnesi alt kategori sahiplik durumu<br>İzin verilen değerler: `0`, `1` |
| pageTitle | string |  | Sayfanın arama motorları tarafından tespit edilebilecek başlık yazısı. |
| metaDescription | string |  | Arama motorları tarafından tespit edilebilecek açıklama yazısı. |
| metaKeywords | string |  | Arama motorları tarafından tespit edilebilecek anahtar kelimeler. |
| canonicalUrl | string |  | İlgili nesnenin İdeaSoft mağazanızdaki sayfasına eklenecek olan <code>&#x3C;link rel=&#x22;canonical&#x22; href=&#x22;https://www.magaza-adiniz.com/girdiginiz-canonical-url-de&#x11F;eri" /&#x3E;</code> HTML etiketinin girdiginiz-canonical-url alanı yazan yere gelmesini istediğiniz değer. Mağaza domaininizin olduğu kısım değiştirilemez, sistem tarafından otomatik eklenir.. |
| tree | string |  | tree |
| attachment | string |  | attachment |
| parent | [Category](#schema-category) |  |  |
| children | object |  | Alt kategori olan kategori listesi. |
| imageUrl | string |  | Kategori nesnesinin görselinin URL'i |
| isCombine | integer | ✓ | Kategori nesnesi kombin kategori durumu.Bu kategori kombin kategorisi olarak işaretlendiğinde kategori altındaki ürünler kombin detay sayfasına yönlendirilecektir.<br>İzin verilen değerler: `0`, `1` |
| isSearchable | integer |  | <br>İzin verilen değerler: `0`, `1` |
| seoSetting | [SeoSetting](#schema-seosetting) |  |  |
| createdAt | string (date-time) |  | Kategori nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-partnership'>Partnership</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Gelir ortaklığı nesnesi kimlik değeri |
| firstname | string | ✓ | İsim |
| surname | string | ✓ | Soy ad |
| email | string | ✓ | E-mail |
| phone | string | ✓ | Telefon |
| companyName | string | ✓ | Firma adı |
| note | string |  | Not |
| type | string |  | Gelir ortaklığı nesnesi tipi |
| status | string |  | Gelir ortaklığı nesnesi durumu |
| createdAt | string (date-time) |  | Gelir ortaklığı nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-commonpref'>CommonPref</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| companyName | string | ✓ | Firma Adı |
| companyOfficialName | string | ✓ | Firma Resmi Adı |
| companyWebsite | string | ✓ | Firma İnternet Sitesi |
| companyRepresentative | string | ✓ | Yetkili Kişi |
| companyPhoneNumber | string | ✓ | Firma Telefon Numarası |
| companyPhoneNumber2 | string | ✓ | Firma Telefon Numarası 2 |
| companyFaxNumber | string | ✓ | Faks Numarası |
| companyEmail | string | ✓ | Firma E-mail Adresi  |
| orderEmail | string | ✓ | Sipariş E-mail Adresi |
| dealerPaymentSystemEmail | string | ✓ | Bayi Ödeme Sistemi E-mail Adresi |
| companyAddress | string | ✓ | Firma Açık Adresi |
| companyPostalCode | string | ✓ | Firma Posta Kodu |
| companyCountry | [Country](#schema-country) | ✓ |  |
| companyLocationName | string | ✓ | Şehir Adı |
| companyLocation | [Location](#schema-location) |  |  |
| companyTown | string |  | İlçe |
| companyIdentityRegistrationNumber | string | ✓ | Firma Sicil Numarası |
| companyTaxNumber | string | ✓ | Firma Vergi Numarası |
| companyTaxOffice | string | ✓ | Firma Vergi Dairesi |
| companyKepAddress | string | ✓ | Firma Kep Adresi |
| companyMersisNumber | string | ✓ | Firma Mersis No |
| favicon | string |  | Tarayıcıların adres çubuğunun yanında küçük bir simge olarak gösterilir. Tüm çözünürlükte en iyi sonucu vermesi için 196x196 px boyutunda olması önerilir. |
| faviconAttachment | string |  | faviconAttachment |
| mailLogoUrl | string |  | Sistemden otomatik olarak gönderilen e-maillerde yer alacak olan logo URL'i. |
| mailLogoAttachment | string |  | mailLogoAttachment |
| contactUs | string | ✓ | İletişim alanı |
| ideapayAgreement | string | ✓ |  Alışverişsiz Ödeme Sistemi Sözleşmesi |
| notificationForm | string | ✓ | Ön Bilgilendirme Formu |
| userAgreement | string | ✓ | Üyelik Sözleşmesi |
| personalDataAgreement | string | ✓ |  KVKK Metni |
| paymentAgreement | string | ✓ | Satış Sözleşmesi |
| refundProcedure | string | ✓ |  İade ve İptal Prosedürü |
| salesCondition | string | ✓ |  Satış Koşulları |

---

<h3 id='schema-orderaddress'>OrderAddress</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş adresi nesnesi kimlik değeri. |
| firstname | string | ✓ | Müşterinin ismi. |
| surname | string | ✓ | Müşterinin soy ismi. |
| country | string | ✓ | Müşterinin ülke bilgisi. |
| location | string | ✓ | Müşterinin şehir bilgisi. |
| subLocation | string | ✓ | Müşterinin ilçe bilgisi. |
| address | string | ✓ | Müşterinin adres bilgisi. |
| phoneNumber | string |  | Müşterinin telefon numarası. |
| mobilePhoneNumber | string | ✓ | Müşterinin mobil telefon numarası. |
| zipCode | string |  |  |
| order | [Order](#schema-order) | ✓ |  |

---

<h3 id='schema-shipment'>Shipment</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Teslimat nesnesi kimlik değeri. |
| barcode | string |  | Teslimat barkodu. |
| waybillNo | string |  | Teslimat fatura numarası. |
| invoiceKey | string |  | Teslimat irsaliye makbuzu numarası. |
| cargoOffice | string |  | Teslimatın kargo şubesi |
| code | string |  | Teslimat kodu. Kargo takip kodu. |
| deliveryType | string |  | Teslimat tipi |
| invoiceIncluded | string |  | Faturanın pakete dahillik durumunu belirtir.<br>İzin verilen değerler: `0`, `1` |
| payAtDoorAmount | string |  | Kapıda ödeme hizmeti bedeli. |
| status | integer | ✓ | Teslimat nesnesinin aktiflik durumunu belirten değer.<br>İzin verilen değerler: `0`, `1` |
| order | [Order](#schema-order) |  |  |
| barcodeImage | string | ✓ | Barkod resmi. |
| trackingUrl | string | ✓ | Takip linki. |
| createdAt | string (date-time) |  | Teslimat nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-subscription'>Subscription</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Abonelik yönetimi nesnesi kimlik değeri. |
| name | string | ✓ | Abonelik yönetimi nesnesi ismi. |
| periods | string | ✓ |  Abonelik Periyodu. |
| periodFrequency | string | ✓ |  Abonelik Periyodu sıklığı<br>İzin verilen değerler: `daily`, `weekly`, `monthly` |
| dispatchCounts | string | ✓ | Periyod içindeki sevk sayısı. 30 günde bir, en fazla 1,2,3,4 defa abone olunabilir. |
| continuousSending | integer |  | Sürekli gönderim. Süresiz gönderim kullanıcı abonelikten çıkmadığı sürece gönderim sağlanır.<br>İzin verilen değerler: `0`, `1` |
| description | string | ✓ | Açıklama. |
| status | string | ✓ | Abonelik yönetimi aktiflik durumu.<br>İzin verilen değerler: `active`, `passive` |
| discount | integer | ✓ | İndirim. |
| shippingAmount | number (float) | ✓ | Kargo fiyatı. |
| createdAt | string (date-time) |  | Abonelik yönetimi nesnesinin oluşturulma zamanı. |
| updatedAt | string (date-time) |  | Abonelik yönetimi nesnesinin güncellenme zamanı. |

---

<h3 id='schema-extrainfo'>ExtraInfo</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Ek Bilgiler nesnesi kimlik değeri. |
| name | string | ✓ | Ek Bilgiler nesnesi kimlik değeri. |
| sortOrder | integer | ✓ | Ek Bilgiler nesnesi için sıralama değeri. |

---

<h3 id='schema-stockwarning'>StockWarning</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Stok bildirim sistemi nesnesi kimlik değeri. |
| member | [Member](#schema-member) | ✓ |  |
| product | [Product](#schema-product) | ✓ |  |
| createdAt | string (date-time) |  | Stok bildirim sistemi nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-slider'>Slider</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Slider nesnesi kimlik değeri. |
| description | string |  | Slider nesnesi açıklaması. |
| status | integer |  | Slider aktiflik durumu.<br>İzin verilen değerler: `0`, `1` |
| predefined | integer |  | Değiştirilemez sliderlar<br>İzin verilen değerler: `0`, `1` |
| setting | [SliderSetting](#schema-slidersetting) | ✓ |  |
| items | array[[SliderItem](#schema-slideritem)] | ✓ | Slider tanımlı ürünler listesi |
| updatedAt | string (date-time) |  | Slider nesnesinin güncellenme zamanı. |
| createdAt | string (date-time) |  | Slider nesnesinin oluşturulma zamanı. |

---

<h3 id='schema-midblock'>Midblock</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer | ✓ | Tablı vitrin blokları nesnesi kimlik değeri |
| name | string | ✓ | Tablı vitrin blokları nesnesi |
| status | integer | ✓ | Tablı vitrin blokları aktiflik durumu<br>İzin verilen değerler: `0`, `1` |
| sortOrder | integer | ✓ | Sıra No |
| productCountPerRow | integer | ✓ | Satırdaki Ürün Sayısı<br>İzin verilen değerler: `1`, `2`, `3`, `4`, `5` |

---

<h3 id='schema-shippingaddress'>ShippingAddress</h3>

| Özellik | Tip | Gerekli | Açıklama |
|---|---|:---:|---|
| id | integer |  | Sipariş adresi nesnesi kimlik değeri. |
| firstname | string | ✓ | Müşterinin ismi. |
| surname | string | ✓ | Müşterinin soy ismi. |
| country | string | ✓ | Müşterinin ülke bilgisi. |
| location | string | ✓ | Müşterinin şehir bilgisi. |
| subLocation | string | ✓ | Müşterinin ilçe bilgisi. |
| address | string | ✓ | Müşterinin adres bilgisi. |
| phoneNumber | string |  | Müşterinin telefon numarası. |
| mobilePhoneNumber | string | ✓ | Müşterinin mobil telefon numarası. |
| zipCode | string |  |  |
| order | [Order](#schema-order) | ✓ |  |

---

