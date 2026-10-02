using ModelContextProtocol.Server;
using System.ComponentModel;

namespace IdeaSoftApi.Mcp.DotNet.Resources;

[McpServerResourceType]
public static class IdeaSoftResources
{
    [McpServerResource(UriTemplate = "ideasoft://guide/capabilities", Name = "IdeaSoft API kapsamı", MimeType = "text/markdown")]
    [Description("Admin API, Store API, OAuth ve webhook kapsamının kısa özeti.")]
    public static string Capabilities() => """
        # IdeaSoftApi MCP kapsamı

        - Admin API yolu: `/admin-api/`
        - Store API yolu: `/api/`
        - Webhook abonelikleri: `/admin-api/client_webhooks`
        - OAuth: Authorization Code + Bearer token
        - Genel `ideasoft_request` aracı belgelenmiş bütün göreli yolları çağırabilir.
        - `ideasoft_list`, `ideasoft_get` ve webhook araçları sık işlemleri daha güvenli hale getirir.
        """;

    [McpServerResource(UriTemplate = "ideasoft://guide/security", Name = "IdeaSoft MCP güvenliği", MimeType = "text/markdown")]
    [Description("Secret, yazma, retry ve webhook güvenlik kuralları.")]
    public static string Security() => """
        # Güvenlik

        1. Secret ve token'lar yalnız ortam değişkenlerinden okunur; araç sonuçlarında gösterilmez.
        2. Mutlak URL ve `..` içeren yollar reddedilir.
        3. POST/PUT/DELETE varsayılan kapalıdır.
        4. Yazma için hem `IDEASOFT_MCP_ALLOW_WRITES=true` hem `IDEASOFT_WRITE_CONFIRMED` gerekir.
        5. POST otomatik retry edilmez; çift kayıt riskini uygulama tarafında yönetin.
        6. Webhook HMAC'i ham gövde üzerinden JSON ayrıştırılmadan önce doğrulanır.
        """;

    [McpServerResource(UriTemplate = "ideasoft://guide/migration", Name = "IdeaSoft site taşıma özeti", MimeType = "text/markdown")]
    [Description("İçerik, veri, SEO ve tema taşıma sırasının kısa özeti.")]
    public static string Migration() => """
        # Site taşıma sırası

        Envanter → bağımlılıklar → ID eşleme → ürünler → içerikler → tema uyarlaması → SEO/yönlendirme → dry-run ve doğrulama.

        API, keyfi bir sitenin HTML/CSS tasarımını tek çağrıda IdeaSoft temasına dönüştürmez. Veri taşıma ile tema/frontend uyarlamasını ayrı iş akışları olarak yönetin.
        """;
}
