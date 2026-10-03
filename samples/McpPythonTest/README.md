# Python MCP istemci örneği

Bu proje resmi Python MCP SDK'sını kullanarak IdeaSoftApi MCP sunucusunu gerçek `stdio` bağlantısıyla başlatır ve çevrimdışı sınar. Varsayılan hedef Python sunucusudur; aynı istemci .NET 8 sunucusunu da test edebilir.

İstemci ve Python sunucusu bağımlılıklarını hazırlayın:

```powershell
uv sync --project samples/McpPythonTest
uv sync --project IdeaSoftApi.Mcp.Python
```

Python sunucusunu sınamak için:

```powershell
uv run --offline --project samples/McpPythonTest ideasoftapi-mcp-python-test --server python
```

.NET 8 sunucusunu sınamak için önce çözümü Release modunda derleyip ardından örneği çalıştırın:

```powershell
dotnet build IdeaSoftApiIntegration.sln -c Release -warnaserror
uv run --offline --project samples/McpPythonTest ideasoftapi-mcp-python-test --server dotnet
```

Örnek; 12 aracın ve 3 kaynağın keşfedildiğini, güvenli durum çıktısını, yetenek bilgisini, taşıma kontrol listesini ve güvenlik kaynağını doğrular. Canlı IdeaSoft endpoint'i çağırmaz. Alt sürece `IDEASOFT_*` değişkenleri aktarılmaz; bu nedenle gerçek Client ID, Client Secret veya token kullanmaz ve göstermez.
