# IdeaSoftApi MCP — .NET 8

Bu proje IdeaSoft Admin API, Store API, OAuth2 ve webhook işlemlerini MCP araçları olarak sunan yerel `stdio` sunucusudur. Resmi `ModelContextProtocol` C# SDK'sını kullanır.

## Derleme ve çalıştırma

```powershell
dotnet build IdeaSoftApi.Mcp.DotNet/IdeaSoftApi.Mcp.DotNet.csproj -c Release
dotnet run --project IdeaSoftApi.Mcp.DotNet -c Release
```

Sunucu doğrudan çalıştırıldığında ekrana menü basmaz; MCP istemcisinden stdin/stdout üzerinden istek bekler. Loglar protokolü bozmamak için stderr'e gider.

## Ortam değişkenleri

| Değişken | Gerekli olduğu durum |
|---|---|
| `IDEASOFT_STORE_URL` | OAuth ve bütün API çağrıları |
| `IDEASOFT_ACCESS_TOKEN` | Hazır access token ile API çağrısı |
| `IDEASOFT_CLIENT_ID` | OAuth izin URL'si veya refresh akışı |
| `IDEASOFT_CLIENT_SECRET` | Refresh akışı ve webhook HMAC doğrulaması |
| `IDEASOFT_REDIRECT_URI` | OAuth izin URL'si |
| `IDEASOFT_REFRESH_TOKEN` | Access token yoksa otomatik, bellek içi yenileme |
| `IDEASOFT_MCP_ALLOW_WRITES` | `true` değilse POST/PUT/DELETE engellenir |

Sırlar hiçbir dosyaya yazılmaz ve MCP araç sonuçlarında döndürülmez.

## Ortak araçlar

Sunucu 12 araç yayınlar: `ideasoft_status`, `ideasoft_authorization_url`, `ideasoft_list`, `ideasoft_get`, `ideasoft_request`, dört webhook yönetim aracı, `ideasoft_verify_webhook`, `ideasoft_capabilities` ve `ideasoft_migration_checklist`.

Python projesi aynı araç adlarını ve güvenlik kurallarını kullanır. Ortak sözleşmenin tamamı `docs/MCP_REHBERI.md` dosyasındadır.

## MCP istemcisi ayar örneği

Mutlak repo yolunu kendi bilgisayarınıza göre değiştirin:

```json
{
  "mcpServers": {
    "IdeaSoftApi": {
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "D:/Proje/IdeaSoft/IdeaSoftApiIntegration/IdeaSoftApi.Mcp.DotNet",
        "-c",
        "Release",
        "--no-build"
      ],
      "env": {
        "IDEASOFT_STORE_URL": "https://magaza-adiniz.myideasoft.com",
        "IDEASOFT_ACCESS_TOKEN": "SECRET_MANAGER_DAN_GELEN_DEGER"
      }
    }
  }
}
```

Gerçek token'ı paylaşılabilir bir MCP ayar dosyasına yazmayın; istemcinin güvenli secret/env özelliğini kullanın.

## Güvenlik

- Salt-okunur GET araçları varsayılan çalışır.
- Yazma için `IDEASOFT_MCP_ALLOW_WRITES=true` ve araç çağrısında `IDEASOFT_WRITE_CONFIRMED` birlikte gerekir.
- Mutlak URL ve `..` içeren yollar istemci katmanında reddedilir.
- API hata gövdesi MCP hata mesajına eklenmez.
- `ideasoft_verify_webhook` Client Secret'ı parametre olarak almaz; ortamdan okur.
