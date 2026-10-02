# IdeaSoftApi MCP — Python

Bu proje IdeaSoft Admin API, Store API ve webhook işlemlerini MCP araçları olarak sunan Python 3.10+ stdio sunucusudur. Araç sözleşmesi `.NET 8` projesiyle aynıdır.

## Kurulum ve çevrimdışı test

```powershell
uv sync --project IdeaSoftApi.Mcp.Python
uv run --project IdeaSoftApi.Mcp.Python python -m unittest discover -s IdeaSoftApi.Mcp.Python/tests -v
```

## Çalıştırma

```powershell
$env:IDEASOFT_STORE_URL = "https://magazaniz.myideasoft.com"
$env:IDEASOFT_ACCESS_TOKEN = "gecici-access-token"
uv run --project IdeaSoftApi.Mcp.Python ideasoftapi-mcp
```

MCP istemcisi yapılandırma örneği:

```json
{
  "mcpServers": {
    "ideasoft-python": {
      "command": "uv",
      "args": ["run", "--project", "D:/Proje/IdeaSoft/IdeaSoftApiIntegration/IdeaSoftApi.Mcp.Python", "ideasoftapi-mcp"],
      "env": {
        "IDEASOFT_STORE_URL": "https://magazaniz.myideasoft.com",
        "IDEASOFT_ACCESS_TOKEN": "ortamdan-verin"
      }
    }
  }
}
```

Secret değerlerini JSON dosyasına yazmak yerine MCP istemcisinin güvenli ortam değişkeni özelliğini kullanın. Yazmalar varsayılan kapalıdır. Ayrıntılı ortak sözleşme için `docs/MCP_REHBERI.md` dosyasına bakın.
