using IdeaSoftApi.Mcp.DotNet.Configuration;
using IdeaSoftApi.Mcp.DotNet.Services;
using IdeaSoftApiClient.Exceptions;
using ModelContextProtocol;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace IdeaSoftApi.Mcp.DotNet.Tools;

[McpServerToolType]
public static class IdeaSoftTools
{
    [McpServerTool(Name = "ideasoft_status", ReadOnly = true, Idempotent = true, OpenWorld = false, UseStructuredContent = true)]
    [Description("IdeaSoft MCP yapılandırmasının hazır olup olmadığını secret değerlerini göstermeden bildirir.")]
    public static ConfigurationStatus Status(IdeaSoftMcpGateway gateway) => gateway.GetStatus();

    [McpServerTool(Name = "ideasoft_authorization_url", ReadOnly = true, Idempotent = false, OpenWorld = false, UseStructuredContent = true)]
    [Description("OAuth2 Authorization Code akışı için izin URL'si ve güvenli state üretir; token veya Client Secret döndürmez.")]
    public static AuthorizationToolResult AuthorizationUrl(IdeaSoftMcpGateway gateway) => Execute(gateway.CreateAuthorizationUrl);

    [McpServerTool(Name = "ideasoft_list", ReadOnly = true, Idempotent = true, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin veya Store API'de bir kaynağı sayfalı ve salt okunur olarak listeler.")]
    public static Task<ApiToolResult> ListAsync(
        IdeaSoftMcpGateway gateway,
        [Description("admin veya store")] string surface,
        [Description("Önek içermeyen kaynak yolu; örnek: products, orders, brands")] string resource,
        [Description("1'den başlayan sayfa")] int page = 1,
        [Description("Sayfa boyutu; 1-100")] int limit = 20,
        [Description("İsteğe bağlı filtre JSON nesnesi; örnek: {\"status\":\"1\"}")] string? filtersJson = null,
        CancellationToken cancellationToken = default) =>
        ExecuteAsync(() => gateway.ListAsync(surface, resource, page, limit, filtersJson, cancellationToken));

    [McpServerTool(Name = "ideasoft_get", ReadOnly = true, Idempotent = true, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin veya Store API'de bir kaydı pozitif ID ile getirir.")]
    public static Task<ApiToolResult> GetAsync(
        IdeaSoftMcpGateway gateway,
        [Description("admin veya store")] string surface,
        [Description("Önek içermeyen kaynak; örnek: products veya orders")] string resource,
        [Description("Pozitif kayıt ID'si")] long id,
        CancellationToken cancellationToken = default) =>
        ExecuteAsync(() => gateway.GetAsync(surface, resource, id, cancellationToken));

    [McpServerTool(Name = "ideasoft_request", ReadOnly = false, Destructive = true, Idempotent = false, OpenWorld = true, UseStructuredContent = true)]
    [Description("Belgelenmiş tüm Admin/Store endpoint'lerini çağıran genel araçtır. GET varsayılandır; POST/PUT/DELETE iki aşamalı yazma kilidine tabidir.")]
    public static Task<ApiToolResult> RequestAsync(
        IdeaSoftMcpGateway gateway,
        [Description("admin veya store")] string surface,
        [Description("/admin-api veya /api öneki içermeyen göreli yol")] string path,
        [Description("GET, POST, PUT veya DELETE")] string method = "GET",
        [Description("İsteğe bağlı sorgu JSON nesnesi")] string? queryJson = null,
        [Description("POST/PUT için isteğe bağlı JSON gövdesi")] string? bodyJson = null,
        [Description("Yazmada tam olarak IDEASOFT_WRITE_CONFIRMED olmalıdır")] string? writeConfirmation = null,
        CancellationToken cancellationToken = default) =>
        ExecuteAsync(() => gateway.SendAsync(surface, method, path, queryJson, bodyJson, writeConfirmation, cancellationToken));

    [McpServerTool(Name = "ideasoft_webhook_list", ReadOnly = true, Idempotent = true, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin API client_webhooks aboneliklerini salt okunur listeler.")]
    public static Task<ApiToolResult> WebhookListAsync(
        IdeaSoftMcpGateway gateway,
        int page = 1,
        int limit = 20,
        CancellationToken cancellationToken = default) =>
        ExecuteAsync(() => gateway.ListAsync("admin", "client_webhooks", page, limit, null, cancellationToken));

    [McpServerTool(Name = "ideasoft_webhook_create", ReadOnly = false, Destructive = false, Idempotent = false, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin API'de webhook aboneliği oluşturur. Yazma kilidi ve açık onay zorunludur.")]
    public static Task<ApiToolResult> WebhookCreateAsync(
        IdeaSoftMcpGateway gateway,
        [Description("Örnek: product/update")] string topic,
        [Description("IdeaSoft'un bildirim göndereceği HTTPS adresi")] string address,
        [Description("1 aktif, 0 pasif")] int status,
        [Description("Tam olarak IDEASOFT_WRITE_CONFIRMED")] string writeConfirmation,
        CancellationToken cancellationToken = default)
    {
        ValidateWebhook(topic, address, status);
        var body = JsonSerializer.Serialize(new { topic, address, status });
        return ExecuteAsync(() => gateway.SendAsync(
            "admin", "POST", "client_webhooks", null, body, writeConfirmation, cancellationToken));
    }

    [McpServerTool(Name = "ideasoft_webhook_update", ReadOnly = false, Destructive = false, Idempotent = true, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin API'de webhook aboneliğini günceller. En az bir alan ve açık yazma onayı gerekir.")]
    public static Task<ApiToolResult> WebhookUpdateAsync(
        IdeaSoftMcpGateway gateway,
        [Description("Pozitif webhook abonelik ID'si")] long id,
        [Description("Yeni topic; değişmeyecekse null")] string? topic = null,
        [Description("Yeni HTTPS adresi; değişmeyecekse null")] string? address = null,
        [Description("1 aktif, 0 pasif; değişmeyecekse null")] int? status = null,
        [Description("Tam olarak IDEASOFT_WRITE_CONFIRMED")] string? writeConfirmation = null,
        CancellationToken cancellationToken = default)
    {
        if (id < 1) throw new McpException("id pozitif olmalıdır.");
        if (topic is null && address is null && status is null)
            throw new McpException("Güncellemek için topic, address veya status alanlarından en az birini verin.");
        if (topic is not null && string.IsNullOrWhiteSpace(topic)) throw new McpException("topic boş olamaz.");
        if (address is not null && (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme != Uri.UriSchemeHttps))
            throw new McpException("Webhook address geçerli bir HTTPS URL olmalıdır.");
        if (status is not null && status is not (0 or 1)) throw new McpException("status yalnız 0 veya 1 olabilir.");

        var body = JsonSerializer.Serialize(new { topic, address, status });
        return ExecuteAsync(() => gateway.SendAsync(
            "admin", "PUT", $"client_webhooks/{id}", null, body, writeConfirmation, cancellationToken));
    }

    [McpServerTool(Name = "ideasoft_webhook_delete", ReadOnly = false, Destructive = true, Idempotent = true, OpenWorld = true, UseStructuredContent = true)]
    [Description("Admin API'de webhook aboneliğini siler. İşlem geri alınamaz; yazma kilidi ve açık onay zorunludur.")]
    public static Task<ApiToolResult> WebhookDeleteAsync(
        IdeaSoftMcpGateway gateway,
        [Description("Pozitif webhook abonelik ID'si")] long id,
        [Description("Tam olarak IDEASOFT_WRITE_CONFIRMED")] string writeConfirmation,
        CancellationToken cancellationToken = default)
    {
        if (id < 1) throw new McpException("id pozitif olmalıdır.");
        return ExecuteAsync(() => gateway.SendAsync(
            "admin", "DELETE", $"client_webhooks/{id}", null, null, writeConfirmation, cancellationToken));
    }

    [McpServerTool(Name = "ideasoft_verify_webhook", ReadOnly = true, Idempotent = true, OpenWorld = false, UseStructuredContent = true)]
    [Description("Ham webhook gövdesini X-Ideashop-Hmac-Sha256 değeriyle sabit zamanlı karşılaştırır; Client Secret ortam değişkeninden okunur.")]
    public static WebhookVerificationResult VerifyWebhook(
        IdeaSoftMcpGateway gateway,
        [Description("IdeaSoft'tan gelen, hiç değiştirilmemiş ham istek gövdesi")] string rawBody,
        [Description("X-Ideashop-Hmac-Sha256 başlığındaki Base64 değer")] string receivedBase64Hmac) =>
        Execute(() => gateway.VerifyWebhook(rawBody, receivedBase64Hmac));

    [McpServerTool(Name = "ideasoft_capabilities", ReadOnly = true, Idempotent = true, OpenWorld = false, UseStructuredContent = true)]
    [Description("MCP sunucusunun API kapsamını ve güvenlik değişmezlerini açıklar.")]
    public static CapabilityInfo Capabilities() => new(
        "IdeaSoftApi MCP",
        ["Admin API: /admin-api", "Store API: /api", "Webhooks: /admin-api/client_webhooks", "OAuth2: /panel/auth ve /oauth/v2/token"],
        ["status", "authorization_url", "list", "get", "generic_request", "webhook CRUD", "webhook HMAC verification", "migration checklist"],
        ["Secret'lar yalnız ortam değişkenlerinden okunur", "Harici mutlak URL reddedilir", "Yazmalar varsayılan kapalıdır", "Yazmada ortam kilidi ve çağrı onayı birlikte gerekir", "POST otomatik retry edilmez"],
        "Genel request aracı, canlı dokümandaki bütün Admin ve Store göreli yollarını kapsar; özel kolaylık araçları sık işlemleri basitleştirir.");

    [McpServerTool(Name = "ideasoft_migration_checklist", ReadOnly = true, Idempotent = true, OpenWorld = false, UseStructuredContent = true)]
    [Description("Bir siteyi IdeaSoft'a veri ve tema olarak taşımak için junior dostu güvenli kontrol listesi döndürür.")]
    public static MigrationChecklist MigrationChecklist() => new(
        [
            "Kaynak içerik, medya, URL, SEO ve ilişkileri envanterle",
            "Marka, kategori, özellik ve etiket bağımlılıklarını önce taşı",
            "Eski ID ile yeni ID arasında kalıcı eşleme tablosu tut",
            "Ürünleri ve ilişkilerini küçük partiler ve checkpoint ile taşı",
            "Sayfa, blog, menü, slider ve banner içeriklerini taşı",
            "Tasarımı IdeaSoft tema motoruna bileşen bazında uyarla",
            "Redirect, canonical, meta alanları, ödeme ve kargoyu doğrula",
            "Önce dry-run; sonra sayım ve örnek kayıt karşılaştırması yap"
        ],
        [
            "Token ve kişisel veriyi loglama",
            "POST tekrarını otomatik açma",
            "Canlı DELETE öncesi hedef mağaza ve ID'yi yeniden doğrula",
            "Webhook gövdesini JSON parse etmeden önce HMAC ile doğrula"
        ]);

    private static void ValidateWebhook(string topic, string address, int status)
    {
        if (string.IsNullOrWhiteSpace(topic)) throw new McpException("topic boş olamaz.");
        if (!Uri.TryCreate(address, UriKind.Absolute, out var uri) || uri.Scheme != Uri.UriSchemeHttps)
            throw new McpException("Webhook address geçerli bir HTTPS URL olmalıdır.");
        if (status is not (0 or 1)) throw new McpException("status yalnız 0 veya 1 olabilir.");
    }

    private static T Execute<T>(Func<T> action)
    {
        try
        {
            return action();
        }
        catch (Exception exception) when (exception is not McpException)
        {
            throw SafeException(exception);
        }
    }

    private static async Task<T> ExecuteAsync<T>(Func<Task<T>> action)
    {
        try
        {
            return await action().ConfigureAwait(false);
        }
        catch (Exception exception) when (exception is not McpException)
        {
            throw SafeException(exception);
        }
    }

    private static McpException SafeException(Exception exception) => exception switch
    {
        ApiException api => new McpException(
            $"IdeaSoft isteği başarısız: HTTP {api.StatusCode}; requestId={api.RequestId ?? "yok"}; cevap gövdesi güvenlik nedeniyle gösterilmedi."),
        JsonException => new McpException("JSON parametresi geçerli değil."),
        ArgumentException or InvalidOperationException => new McpException(exception.Message),
        _ => new McpException("IdeaSoft MCP işlemi beklenmeyen bir nedenle başarısız oldu.")
    };
}
