from __future__ import annotations

from typing import Any
from urllib.parse import urlparse

from mcp.server.mcpserver import MCPServer
from mcp.types import ToolAnnotations

from .gateway import Gateway, IdeaSoftGatewayError, Options


mcp = MCPServer("IdeaSoftApi MCP")
gateway = Gateway(Options.from_environment())
READ_ONLY_LOCAL = ToolAnnotations(
    readOnlyHint=True, destructiveHint=False, idempotentHint=True, openWorldHint=False
)
READ_ONLY_OPEN = ToolAnnotations(
    readOnlyHint=True, destructiveHint=False, idempotentHint=True, openWorldHint=True
)
WRITE_CREATE = ToolAnnotations(
    readOnlyHint=False, destructiveHint=False, idempotentHint=False, openWorldHint=True
)
WRITE_UPDATE = ToolAnnotations(
    readOnlyHint=False, destructiveHint=False, idempotentHint=True, openWorldHint=True
)
WRITE_DELETE = ToolAnnotations(
    readOnlyHint=False, destructiveHint=True, idempotentHint=True, openWorldHint=True
)


@mcp.tool(name="ideasoft_status", annotations=READ_ONLY_LOCAL, structured_output=True)
def ideasoft_status() -> dict[str, Any]:
    """Secret göstermeden sunucu yapılandırmasının hazır olup olmadığını bildirir."""
    return gateway.status()


@mcp.tool(
    name="ideasoft_authorization_url",
    annotations=ToolAnnotations(
        readOnlyHint=True, destructiveHint=False, idempotentHint=False, openWorldHint=False
    ),
    structured_output=True,
)
def ideasoft_authorization_url() -> dict[str, str]:
    """OAuth2 Authorization Code akışı için izin URL'si ve güvenli state üretir."""
    return gateway.authorization_url()


@mcp.tool(name="ideasoft_list", annotations=READ_ONLY_OPEN, structured_output=True)
async def ideasoft_list(
    surface: str,
    resource: str,
    page: int = 1,
    limit: int = 20,
    filters: dict[str, Any] | None = None,
) -> dict[str, Any]:
    """Admin veya Store API'de bir kaynağı sayfalı ve salt okunur listeler."""
    return await gateway.list(surface, resource, page, limit, filters)


@mcp.tool(name="ideasoft_get", annotations=READ_ONLY_OPEN, structured_output=True)
async def ideasoft_get(surface: str, resource: str, record_id: int) -> dict[str, Any]:
    """Admin veya Store API'de tek kaydı pozitif ID ile getirir."""
    return await gateway.get(surface, resource, record_id)


@mcp.tool(
    name="ideasoft_request",
    annotations=ToolAnnotations(
        readOnlyHint=False, destructiveHint=True, idempotentHint=False, openWorldHint=True
    ),
    structured_output=True,
)
async def ideasoft_request(
    surface: str,
    path: str,
    method: str = "GET",
    query: dict[str, Any] | None = None,
    body: dict[str, Any] | list[Any] | None = None,
    write_confirmation: str | None = None,
) -> dict[str, Any]:
    """Belgelenmiş Admin/Store yollarını çağırır; yazmalar iki aşamalı kilide tabidir."""
    return await gateway.request(surface, path, method, query, body, write_confirmation)


@mcp.tool(name="ideasoft_webhook_list", annotations=READ_ONLY_OPEN, structured_output=True)
async def ideasoft_webhook_list(page: int = 1, limit: int = 20) -> dict[str, Any]:
    """Admin API webhook aboneliklerini salt okunur listeler."""
    return await gateway.list("admin", "client_webhooks", page, limit)


@mcp.tool(name="ideasoft_webhook_create", annotations=WRITE_CREATE, structured_output=True)
async def ideasoft_webhook_create(
    topic: str,
    address: str,
    status: int,
    write_confirmation: str,
) -> dict[str, Any]:
    """Admin API'de webhook aboneliği oluşturur; açık yazma onayı gerekir."""
    _validate_webhook(topic, address, status)
    return await gateway.request(
        "admin",
        "client_webhooks",
        "POST",
        body={"topic": topic, "address": address, "status": status},
        write_confirmation=write_confirmation,
    )


@mcp.tool(name="ideasoft_webhook_update", annotations=WRITE_UPDATE, structured_output=True)
async def ideasoft_webhook_update(
    webhook_id: int,
    write_confirmation: str,
    topic: str | None = None,
    address: str | None = None,
    status: int | None = None,
) -> dict[str, Any]:
    """Admin API'de webhook aboneliğini günceller; açık yazma onayı gerekir."""
    if webhook_id < 1:
        raise IdeaSoftGatewayError("id pozitif olmalıdır.")
    if topic is None and address is None and status is None:
        raise IdeaSoftGatewayError("Güncellemek için en az bir alan verin.")
    if topic is not None and not topic.strip():
        raise IdeaSoftGatewayError("topic boş olamaz.")
    if address is not None and not _is_https(address):
        raise IdeaSoftGatewayError("Webhook address geçerli bir HTTPS URL olmalıdır.")
    if status is not None and status not in {0, 1}:
        raise IdeaSoftGatewayError("status yalnız 0 veya 1 olabilir.")
    body = {key: value for key, value in {"topic": topic, "address": address, "status": status}.items() if value is not None}
    return await gateway.request(
        "admin",
        f"client_webhooks/{webhook_id}",
        "PUT",
        body=body,
        write_confirmation=write_confirmation,
    )


@mcp.tool(name="ideasoft_webhook_delete", annotations=WRITE_DELETE, structured_output=True)
async def ideasoft_webhook_delete(webhook_id: int, write_confirmation: str) -> dict[str, Any]:
    """Admin API'de webhook aboneliğini siler; işlem geri alınamaz."""
    if webhook_id < 1:
        raise IdeaSoftGatewayError("id pozitif olmalıdır.")
    return await gateway.request(
        "admin",
        f"client_webhooks/{webhook_id}",
        "DELETE",
        write_confirmation=write_confirmation,
    )


@mcp.tool(name="ideasoft_verify_webhook", annotations=READ_ONLY_LOCAL, structured_output=True)
def ideasoft_verify_webhook(raw_body: str, received_base64_hmac: str) -> dict[str, Any]:
    """Ham webhook gövdesinin HMAC-SHA256/Base64 imzasını sabit zamanda doğrular."""
    return gateway.verify_webhook(raw_body, received_base64_hmac)


@mcp.tool(name="ideasoft_capabilities", annotations=READ_ONLY_LOCAL, structured_output=True)
def ideasoft_capabilities() -> dict[str, Any]:
    """MCP sunucusunun API kapsamını ve güvenlik değişmezlerini açıklar."""
    return {
        "server": "IdeaSoftApi MCP",
        "surfaces": ["Admin API: /admin-api", "Store API: /api", "Webhooks: /admin-api/client_webhooks"],
        "coverage": "Genel request aracı belgelenmiş bütün göreli Admin ve Store yollarını kapsar.",
        "securityRules": [
            "Secret'lar yalnız ortam değişkenlerinden okunur",
            "Harici mutlak URL reddedilir",
            "Yazmalar varsayılan kapalıdır",
            "Yazmada ortam kilidi ve çağrı onayı birlikte gerekir",
            "POST otomatik retry edilmez",
        ],
    }


@mcp.tool(name="ideasoft_migration_checklist", annotations=READ_ONLY_LOCAL, structured_output=True)
def ideasoft_migration_checklist() -> dict[str, list[str]]:
    """Bir siteyi IdeaSoft'a taşımak için güvenli ve sıralı kontrol listesi döndürür."""
    return {
        "steps": [
            "Kaynak içerik, medya, URL, SEO ve ilişkileri envanterle",
            "Marka, kategori, özellik ve etiket bağımlılıklarını önce taşı",
            "Eski ID ile yeni ID arasında kalıcı eşleme tut",
            "Ürün ve içerikleri küçük partiler ve checkpoint ile taşı",
            "Tema, yönlendirme, ödeme ve kargoyu doğrula",
            "Önce dry-run; sonra sayım ve örnek kayıt karşılaştırması yap",
        ],
        "safetyRules": [
            "Token ve kişisel veriyi loglama",
            "POST tekrarını otomatik açma",
            "DELETE öncesi mağaza ve kayıt ID'sini doğrula",
            "Webhook gövdesini ayrıştırmadan önce HMAC ile doğrula",
        ],
    }


@mcp.resource("ideasoft://guide/capabilities", mime_type="text/markdown")
def capabilities_resource() -> str:
    """Admin API, Store API, OAuth ve webhook kapsamı."""
    return """# IdeaSoftApi MCP kapsamı

- Admin API yolu: `/admin-api/`
- Store API yolu: `/api/`
- Webhook abonelikleri: `/admin-api/client_webhooks`
- Genel `ideasoft_request` aracı belgelenmiş göreli yolları çağırır.
"""


@mcp.resource("ideasoft://guide/security", mime_type="text/markdown")
def security_resource() -> str:
    """Secret, yazma, retry ve webhook güvenlik kuralları."""
    return """# Güvenlik

1. Secret ve token'lar yalnız ortam değişkenlerinden okunur.
2. Mutlak URL ve `..` içeren yollar reddedilir.
3. Yazma varsayılan kapalıdır ve iki ayrı onay ister.
4. POST otomatik retry edilmez.
5. Webhook HMAC'i ham gövde üzerinden doğrulanır.
"""


@mcp.resource("ideasoft://guide/migration", mime_type="text/markdown")
def migration_resource() -> str:
    """İçerik, veri, SEO ve tema taşıma sırası."""
    return """# Site taşıma sırası

Envanter → bağımlılıklar → ID eşleme → ürünler → içerikler → tema → SEO/yönlendirme → dry-run ve doğrulama.

Veri aktarımı ile IdeaSoft tema/frontend uyarlamasını ayrı iş akışları olarak yönetin.
"""


def _validate_webhook(topic: str, address: str, status: int) -> None:
    if not topic.strip():
        raise IdeaSoftGatewayError("topic boş olamaz.")
    if not _is_https(address):
        raise IdeaSoftGatewayError("Webhook address geçerli bir HTTPS URL olmalıdır.")
    if status not in {0, 1}:
        raise IdeaSoftGatewayError("status yalnız 0 veya 1 olabilir.")


def _is_https(value: str) -> bool:
    parsed = urlparse(value)
    return parsed.scheme == "https" and bool(parsed.netloc)


def main() -> None:
    mcp.run()


if __name__ == "__main__":
    main()
