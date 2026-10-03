# .NET 8 MCP istemci örneği

Bu proje resmi .NET MCP SDK'sını kullanarak IdeaSoftApi MCP sunucusunu gerçek `stdio` bağlantısıyla başlatır ve çevrimdışı sınar. Varsayılan hedef .NET sunucusudur; aynı istemci Python sunucusunu da test edebilir.

Önce çözümü derleyin:

```powershell
dotnet build IdeaSoftApiIntegration.sln -c Release -warnaserror
```

.NET sunucusunu sınamak için:

```powershell
dotnet run --project samples/McpDotNetTest -c Release -- --server dotnet
```

Python sunucusunu sınamak için:

```powershell
uv sync --project IdeaSoftApi.Mcp.Python
dotnet run --project samples/McpDotNetTest -c Release -- --server python
```

Örnek; 12 aracın ve 3 kaynağın keşfedildiğini, güvenli durum çıktısını, yetenek bilgisini, taşıma kontrol listesini ve güvenlik kaynağını doğrular. Canlı IdeaSoft endpoint'i çağırmaz. Alt sürece `IDEASOFT_*` değişkenleri aktarılmaz; bu nedenle gerçek Client ID, Client Secret veya token kullanmaz ve göstermez.
