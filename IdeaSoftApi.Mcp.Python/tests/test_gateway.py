import asyncio
import base64
import hashlib
import hmac
import unittest

from ideasoftapi_mcp.gateway import Gateway, IdeaSoftGatewayError, Options, WRITE_CONFIRMATION


class FakeResponse:
    def __init__(self, body: bytes = b"{}", status: int = 200) -> None:
        self._body = body
        self.status = status
        self.headers = {"X-Request-Id": "local-test"}

    def read(self) -> bytes:
        return self._body

    def __enter__(self):
        return self

    def __exit__(self, *_args):
        return False


class RecordingOpener:
    def __init__(self, body: bytes = b"{}", status: int = 200) -> None:
        self.body = body
        self.status = status
        self.request = None

    def __call__(self, request, timeout):
        self.request = request
        self.timeout = timeout
        return FakeResponse(self.body, self.status)


class GatewayTests(unittest.TestCase):
    def test_status_does_not_return_secrets(self):
        gateway = Gateway(Options(store_url="https://ornek.myideasoft.com", access_token="secret"))
        result = gateway.status()
        self.assertTrue(result["accessTokenConfigured"])
        self.assertFalse(result["secretsAreReturned"])
        self.assertNotIn("'secret'", str(result))

    def test_authorization_url(self):
        gateway = Gateway(
            Options(
                store_url="https://ornek.myideasoft.com",
                client_id="ornek-client",
                redirect_uri="https://uygulama.example/callback",
            )
        )
        result = gateway.authorization_url()
        self.assertTrue(result["authorizationUrl"].startswith("https://ornek.myideasoft.com/panel/auth?"))
        self.assertIn("client_id=ornek-client", result["authorizationUrl"])
        self.assertGreaterEqual(len(result["state"]), 32)

    def test_admin_get_path(self):
        opener = RecordingOpener(b'{"id":42}')
        gateway = self._gateway(opener)
        result = asyncio.run(gateway.get("admin", "products", 42))
        self.assertEqual("https://ornek.myideasoft.com/admin-api/products/42", opener.request.full_url)
        self.assertEqual("Bearer test-token", opener.request.get_header("Authorization"))
        self.assertEqual(42, result["data"]["id"])

    def test_store_list_path(self):
        opener = RecordingOpener(b"[]")
        gateway = self._gateway(opener)
        asyncio.run(gateway.list("store", "orders", 2, 10, {"status": 1}))
        self.assertEqual(
            "https://ornek.myideasoft.com/api/orders?page=2&limit=10&status=1",
            opener.request.full_url,
        )

    def test_writes_are_disabled_by_default(self):
        gateway = self._gateway(RecordingOpener())
        with self.assertRaisesRegex(IdeaSoftGatewayError, "kapalı"):
            asyncio.run(
                gateway.request(
                    "admin", "products", "POST", body={}, write_confirmation=WRITE_CONFIRMATION
                )
            )

    def test_write_requires_two_steps(self):
        opener = RecordingOpener(b'{"id":7}', 201)
        gateway = Gateway(
            Options(
                store_url="https://ornek.myideasoft.com",
                access_token="test-token",
                allow_writes=True,
            ),
            opener=opener,
        )
        with self.assertRaises(IdeaSoftGatewayError):
            asyncio.run(gateway.request("admin", "products", "POST", body={}, write_confirmation="wrong"))
        result = asyncio.run(
            gateway.request(
                "admin", "products", "POST", body={"name": "Test"}, write_confirmation=WRITE_CONFIRMATION
            )
        )
        self.assertEqual(201, result["statusCode"])
        self.assertEqual("POST", opener.request.method)

    def test_webhook_hmac(self):
        body = '{"id":1}'
        secret = "yerel-test-secret"
        signature = base64.b64encode(
            hmac.new(secret.encode(), body.encode(), hashlib.sha256).digest()
        ).decode()
        gateway = Gateway(Options(client_secret=secret))
        self.assertTrue(gateway.verify_webhook(body, signature)["isValid"])
        self.assertFalse(gateway.verify_webhook(body + "x", signature)["isValid"])

    def test_refresh_flow_keeps_rotated_token_in_memory(self):
        class RefreshOpener:
            def __init__(self):
                self.requests = []

            def __call__(self, request, timeout):
                self.requests.append(request)
                if request.full_url.endswith("/oauth/v2/token"):
                    return FakeResponse(
                        b'{"access_token":"renewed-access","refresh_token":"renewed-refresh","expires_in":3600}'
                    )
                return FakeResponse(b'{"id":9}')

        opener = RefreshOpener()
        gateway = Gateway(
            Options(
                store_url="https://ornek.myideasoft.com",
                client_id="client",
                client_secret="client-secret",
                refresh_token="initial-refresh",
            ),
            opener=opener,
        )
        result = asyncio.run(gateway.get("admin", "products", 9))
        self.assertEqual(9, result["data"]["id"])
        self.assertEqual(2, len(opener.requests))
        self.assertEqual("Bearer renewed-access", opener.requests[1].get_header("Authorization"))

    @staticmethod
    def _gateway(opener: RecordingOpener) -> Gateway:
        return Gateway(
            Options(store_url="https://ornek.myideasoft.com", access_token="test-token"),
            opener=opener,
        )


if __name__ == "__main__":
    unittest.main()
