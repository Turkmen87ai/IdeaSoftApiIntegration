from __future__ import annotations

import asyncio
import base64
import hashlib
import hmac
import json
import os
import secrets
import threading
import time
from dataclasses import dataclass
from typing import Any, Callable
from urllib.error import HTTPError, URLError
from urllib.parse import urlencode, urlparse
from urllib.request import Request, urlopen


WRITE_CONFIRMATION = "IDEASOFT_WRITE_CONFIRMED"
RETRY_STATUS_CODES = {429, 502, 503, 504}
ALLOWED_METHODS = {"GET", "POST", "PUT", "DELETE"}


class IdeaSoftGatewayError(RuntimeError):
    """Araç sonucuna güvenle aktarılabilecek, secret içermeyen hata."""


@dataclass(frozen=True)
class Options:
    store_url: str | None = None
    access_token: str | None = None
    client_id: str | None = None
    client_secret: str | None = None
    redirect_uri: str | None = None
    refresh_token: str | None = None
    allow_writes: bool = False
    timeout_seconds: int = 100
    max_retry_count: int = 3

    @classmethod
    def from_environment(cls) -> "Options":
        return cls(
            store_url=_read("IDEASOFT_STORE_URL"),
            access_token=_read("IDEASOFT_ACCESS_TOKEN"),
            client_id=_read("IDEASOFT_CLIENT_ID"),
            client_secret=_read("IDEASOFT_CLIENT_SECRET"),
            redirect_uri=_read("IDEASOFT_REDIRECT_URI"),
            refresh_token=_read("IDEASOFT_REFRESH_TOKEN"),
            allow_writes=(_read("IDEASOFT_MCP_ALLOW_WRITES") or "").lower() in {"true", "1"},
            timeout_seconds=_read_integer("IDEASOFT_MCP_TIMEOUT_SECONDS", 100, 1, 600),
            max_retry_count=_read_integer("IDEASOFT_MCP_MAX_RETRY_COUNT", 3, 0, 10),
        )


class Gateway:
    def __init__(
        self,
        options: Options,
        opener: Callable[..., Any] = urlopen,
        sleeper: Callable[[float], None] = time.sleep,
    ) -> None:
        self.options = options
        self._opener = opener
        self._sleeper = sleeper
        self._access_token = options.access_token
        self._refresh_token = options.refresh_token
        self._access_token_expires_at = float("inf") if options.access_token else 0.0
        self._token_lock = threading.Lock()

    def status(self) -> dict[str, Any]:
        store_url = None
        if self.options.store_url:
            parsed = urlparse(self.options.store_url)
            if parsed.scheme in {"http", "https"} and parsed.netloc:
                store_url = f"{parsed.scheme}://{parsed.netloc}/"
        return {
            "serverName": "IdeaSoftApi MCP",
            "storeUrl": store_url,
            "accessTokenConfigured": bool(self.options.access_token),
            "refreshFlowConfigured": all(
                (self.options.client_id, self.options.client_secret, self.options.refresh_token)
            ),
            "authorizationUrlConfigured": bool(
                self.options.client_id and _is_absolute_url(self.options.redirect_uri)
            ),
            "writesEnabled": self.options.allow_writes,
            "writeConfirmation": WRITE_CONFIRMATION,
            "secretsAreReturned": False,
        }

    def authorization_url(self) -> dict[str, str]:
        base = self._base_url()
        if not self.options.client_id:
            raise IdeaSoftGatewayError("IDEASOFT_CLIENT_ID ortam değişkeni tanımlı değil.")
        if not _is_absolute_url(self.options.redirect_uri):
            raise IdeaSoftGatewayError("IDEASOFT_REDIRECT_URI geçerli bir mutlak URL değil.")
        state = secrets.token_urlsafe(32)
        query = urlencode(
            {
                "response_type": "code",
                "client_id": self.options.client_id,
                "redirect_uri": self.options.redirect_uri,
                "state": state,
            }
        )
        return {
            "authorizationUrl": f"{base}/panel/auth?{query}",
            "state": state,
            "redirectUri": self.options.redirect_uri or "",
            "warning": "State değerini kullanıcı oturumunda saklayın ve callback'te birebir doğrulayın.",
        }

    async def request(
        self,
        surface: str,
        path: str,
        method: str = "GET",
        query: dict[str, Any] | None = None,
        body: dict[str, Any] | list[Any] | None = None,
        write_confirmation: str | None = None,
    ) -> dict[str, Any]:
        return await asyncio.to_thread(
            self._request_sync,
            surface,
            path,
            method,
            query,
            body,
            write_confirmation,
        )

    async def list(
        self,
        surface: str,
        resource: str,
        page: int = 1,
        limit: int = 20,
        filters: dict[str, Any] | None = None,
    ) -> dict[str, Any]:
        if page < 1:
            raise IdeaSoftGatewayError("page en az 1 olmalıdır.")
        if not 1 <= limit <= 100:
            raise IdeaSoftGatewayError("limit 1 ile 100 arasında olmalıdır.")
        query: dict[str, Any] = {"page": page, "limit": limit}
        for key, value in (filters or {}).items():
            if key not in {"page", "limit"}:
                query[key] = value
        return await self.request(surface, resource, query=query)

    async def get(self, surface: str, resource: str, record_id: int) -> dict[str, Any]:
        if record_id < 1:
            raise IdeaSoftGatewayError("id pozitif olmalıdır.")
        return await self.request(surface, f"{resource.rstrip('/')}/{record_id}")

    def verify_webhook(self, raw_body: str, received_base64_hmac: str) -> dict[str, Any]:
        if not self.options.client_secret:
            raise IdeaSoftGatewayError("IDEASOFT_CLIENT_SECRET ortam değişkeni tanımlı değil.")
        expected = hmac.new(
            self.options.client_secret.encode("utf-8"),
            raw_body.encode("utf-8"),
            hashlib.sha256,
        ).digest()
        try:
            received = base64.b64decode(received_base64_hmac, validate=True)
        except (ValueError, TypeError):
            received = b""
        return {
            "isValid": hmac.compare_digest(expected, received),
            "algorithm": "HMAC-SHA256/Base64",
        }

    def _request_sync(
        self,
        surface: str,
        path: str,
        method: str,
        query: dict[str, Any] | None,
        body: dict[str, Any] | list[Any] | None,
        write_confirmation: str | None,
    ) -> dict[str, Any]:
        normalized_surface = _normalize_surface(surface)
        normalized_method = method.strip().upper()
        if normalized_method not in ALLOWED_METHODS:
            raise IdeaSoftGatewayError("method yalnız GET, POST, PUT veya DELETE olabilir.")
        self._ensure_write_allowed(normalized_method, write_confirmation)
        safe_path = _safe_relative_path(path)
        prefix = "admin-api" if normalized_surface == "admin" else "api"
        url = f"{self._base_url()}/{prefix}/{safe_path}"
        if query:
            encoded = urlencode(
                [(str(key), _query_value(value)) for key, value in query.items() if value is not None],
                doseq=True,
            )
            if encoded:
                url = f"{url}?{encoded}"

        payload = None if body is None else json.dumps(body, ensure_ascii=False).encode("utf-8")
        attempts = 1 + (self.options.max_retry_count if normalized_method in {"GET", "PUT", "DELETE"} else 0)
        for attempt in range(attempts):
            token = self._get_access_token()
            request = Request(url, data=payload, method=normalized_method)
            request.add_header("Authorization", f"Bearer {token}")
            request.add_header("Accept", "application/json")
            if payload is not None:
                request.add_header("Content-Type", "application/json; charset=utf-8")
            try:
                with self._opener(request, timeout=self.options.timeout_seconds) as response:
                    raw = response.read()
                    data = None if not raw else json.loads(raw.decode("utf-8"))
                    return {
                        "surface": normalized_surface,
                        "method": normalized_method,
                        "path": safe_path,
                        "statusCode": int(response.status),
                        "requestId": response.headers.get("X-Request-Id"),
                        "data": data,
                    }
            except HTTPError as error:
                if error.code in RETRY_STATUS_CODES and attempt + 1 < attempts:
                    self._sleeper(min(2**attempt, 8))
                    continue
                raise IdeaSoftGatewayError(
                    f"IdeaSoft isteği başarısız: HTTP {error.code}; cevap gövdesi güvenlik nedeniyle gösterilmedi."
                ) from None
            except (URLError, TimeoutError) as error:
                if attempt + 1 < attempts:
                    self._sleeper(min(2**attempt, 8))
                    continue
                raise IdeaSoftGatewayError("IdeaSoft bağlantısı kurulamadı veya zaman aşımına uğradı.") from error
            except json.JSONDecodeError as error:
                raise IdeaSoftGatewayError("IdeaSoft cevabı geçerli JSON değil.") from error
        raise IdeaSoftGatewayError("IdeaSoft isteği tamamlanamadı.")

    def _get_access_token(self) -> str:
        if self._access_token and time.monotonic() < self._access_token_expires_at:
            return self._access_token
        with self._token_lock:
            if self._access_token and time.monotonic() < self._access_token_expires_at:
                return self._access_token
            if not all((self.options.client_id, self.options.client_secret, self._refresh_token)):
                raise IdeaSoftGatewayError(
                    "IDEASOFT_ACCESS_TOKEN veya Client ID/Client Secret/Refresh Token üçlüsü tanımlanmalıdır."
                )
            payload = urlencode(
                {
                    "grant_type": "refresh_token",
                    "client_id": self.options.client_id,
                    "client_secret": self.options.client_secret,
                    "refresh_token": self._refresh_token,
                }
            ).encode("utf-8")
            request = Request(f"{self._base_url()}/oauth/v2/token", data=payload, method="POST")
            request.add_header("Accept", "application/json")
            request.add_header("Content-Type", "application/x-www-form-urlencoded")
            try:
                with self._opener(request, timeout=self.options.timeout_seconds) as response:
                    token_data = json.loads(response.read().decode("utf-8"))
            except (HTTPError, URLError, TimeoutError, json.JSONDecodeError) as error:
                raise IdeaSoftGatewayError("OAuth token yenileme başarısız oldu.") from error
            access_token = token_data.get("access_token")
            if not isinstance(access_token, str) or not access_token:
                raise IdeaSoftGatewayError("OAuth yanıtında access_token bulunamadı.")
            self._access_token = access_token
            expires_in = token_data.get("expires_in", 3600)
            try:
                lifetime = max(int(expires_in), 1)
            except (TypeError, ValueError):
                lifetime = 3600
            self._access_token_expires_at = time.monotonic() + max(lifetime - 60, 1)
            rotated_refresh = token_data.get("refresh_token")
            if isinstance(rotated_refresh, str) and rotated_refresh:
                self._refresh_token = rotated_refresh
            return self._access_token

    def _ensure_write_allowed(self, method: str, confirmation: str | None) -> None:
        if method == "GET":
            return
        if not self.options.allow_writes:
            raise IdeaSoftGatewayError(
                "Yazma işlemleri kapalı. IDEASOFT_MCP_ALLOW_WRITES=true olmadan çalıştırılamaz."
            )
        if confirmation != WRITE_CONFIRMATION:
            raise IdeaSoftGatewayError(
                f"Yazma için writeConfirmation tam olarak {WRITE_CONFIRMATION} olmalıdır."
            )

    def _base_url(self) -> str:
        if not self.options.store_url:
            raise IdeaSoftGatewayError("IDEASOFT_STORE_URL ortam değişkeni tanımlı değil.")
        parsed = urlparse(self.options.store_url.strip())
        if parsed.scheme not in {"http", "https"} or not parsed.netloc:
            raise IdeaSoftGatewayError("IDEASOFT_STORE_URL geçerli bir mutlak URL değil.")
        if parsed.query or parsed.fragment or parsed.username or parsed.password:
            raise IdeaSoftGatewayError("IDEASOFT_STORE_URL sorgu, fragment veya kullanıcı bilgisi içeremez.")
        return f"{parsed.scheme}://{parsed.netloc}"


def _normalize_surface(surface: str) -> str:
    normalized = surface.strip().lower()
    if normalized not in {"admin", "store"}:
        raise IdeaSoftGatewayError("surface yalnız admin veya store olabilir.")
    return normalized


def _safe_relative_path(path: str) -> str:
    value = (path or "").strip().strip("/")
    parsed = urlparse(value)
    segments = value.split("/")
    if not value or parsed.scheme or parsed.netloc or parsed.query or parsed.fragment or ".." in segments:
        raise IdeaSoftGatewayError("path yalnız güvenli bir göreli API yolu olabilir.")
    if value.startswith(("admin-api/", "api/")):
        raise IdeaSoftGatewayError("path alanına admin-api veya api öneki eklemeyin.")
    return value


def _query_value(value: Any) -> Any:
    if isinstance(value, bool):
        return "true" if value else "false"
    return value


def _is_absolute_url(value: str | None) -> bool:
    if not value:
        return False
    parsed = urlparse(value)
    return parsed.scheme in {"http", "https"} and bool(parsed.netloc)


def _read(name: str) -> str | None:
    value = os.getenv(name)
    return value.strip() if value and value.strip() else None


def _read_integer(name: str, fallback: int, minimum: int, maximum: int) -> int:
    try:
        value = int(_read(name) or "")
    except ValueError:
        return fallback
    return value if minimum <= value <= maximum else fallback
