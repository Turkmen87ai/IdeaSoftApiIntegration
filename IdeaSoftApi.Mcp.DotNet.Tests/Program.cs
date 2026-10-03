using IdeaSoftApi.Mcp.DotNet.Configuration;
using IdeaSoftApi.Mcp.DotNet.Services;
using IdeaSoftApi.Mcp.DotNet.Tools;
using ModelContextProtocol.Server;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var tests = new (string Name, Func<Task> Run)[]
{
    ("Secret göstermeyen durum", TestStatusAsync),
    ("Durum şeması null alan uyumu", TestStatusSchemaAsync),
    ("OAuth izin URL'si", TestAuthorizationUrlAsync),
    ("Admin GET yolu", TestAdminGetAsync),
    ("Store liste yolu", TestStoreListAsync),
    ("Varsayılan yazma kilidi", TestWriteDisabledAsync),
    ("İki aşamalı yazma onayı", TestWriteConfirmationAsync),
    ("Webhook HMAC doğrulaması", TestWebhookHmacAsync),
    ("MCP araç keşfi", TestToolDiscoveryAsync)
};

var failed = 0;
foreach (var test in tests)
{
    try
    {
        await test.Run();
        Console.WriteLine($"PASS  {test.Name}");
    }
    catch (Exception exception)
    {
        failed++;
        Console.Error.WriteLine($"FAIL  {test.Name}: {exception.Message}");
    }
}

Console.WriteLine($"IdeaSoftApi MCP .NET testleri: {tests.Length - failed}/{tests.Length} PASS");
return failed == 0 ? 0 : 1;

static Task TestStatusAsync()
{
    using var gateway = new IdeaSoftMcpGateway(new IdeaSoftMcpOptions
    {
        StoreUrl = "https://ornek.myideasoft.com",
        AccessToken = "gizli-token",
        ClientSecret = "gizli-secret"
    });
    var status = gateway.GetStatus();
    Equal(true, status.AccessTokenConfigured);
    Equal(false, status.SecretsAreReturned);
    Equal(false, status.WritesEnabled);
    return Task.CompletedTask;
}

static Task TestStatusSchemaAsync()
{
    var status = new IdeaSoftMcpOptions().ToStatus();
    var json = JsonSerializer.Serialize(status, new JsonSerializerOptions
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    });
    using var document = JsonDocument.Parse(json);
    Ensure(document.RootElement.TryGetProperty("StoreUrl", out var storeUrl), "StoreUrl şema alanı atlandı.");
    Equal(JsonValueKind.Null, storeUrl.ValueKind);
    return Task.CompletedTask;
}

static Task TestAuthorizationUrlAsync()
{
    using var gateway = new IdeaSoftMcpGateway(new IdeaSoftMcpOptions
    {
        StoreUrl = "https://ornek.myideasoft.com",
        ClientId = "ornek-client",
        RedirectUri = "https://uygulama.example/callback"
    });
    var result = gateway.CreateAuthorizationUrl();
    Ensure(result.AuthorizationUrl.StartsWith("https://ornek.myideasoft.com/panel/auth?", StringComparison.Ordinal), "İzin yolu yanlış.");
    Ensure(result.AuthorizationUrl.Contains("client_id=ornek-client", StringComparison.Ordinal), "Client ID eksik.");
    Ensure(result.State.Length >= 32, "State yeterince güçlü değil.");
    return Task.CompletedTask;
}

static async Task TestAdminGetAsync()
{
    var handler = new RecordingHandler("{\"id\":42,\"name\":\"Ürün\"}");
    using var http = new HttpClient(handler);
    using var gateway = CreateGateway(http);
    var result = await gateway.GetAsync("admin", "products", 42, default);
    Equal("https://ornek.myideasoft.com/admin-api/products/42", handler.LastUri);
    Equal("Bearer", handler.AuthorizationScheme);
    Equal(42L, result.Data?.GetProperty("id").GetInt64());
}

static async Task TestStoreListAsync()
{
    var handler = new RecordingHandler("[]");
    using var http = new HttpClient(handler);
    using var gateway = CreateGateway(http);
    await gateway.ListAsync("store", "orders", 2, 10, "{\"status\":\"1\"}", default);
    Equal("https://ornek.myideasoft.com/api/orders?page=2&limit=10&status=1", handler.LastUri);
}

static async Task TestWriteDisabledAsync()
{
    using var http = new HttpClient(new RecordingHandler("{}"));
    using var gateway = CreateGateway(http);
    try
    {
        await gateway.SendAsync("admin", "POST", "products", null, "{}", IdeaSoftMcpOptions.WriteConfirmation, default);
        throw new Exception("Yazma kilidi devreye girmedi.");
    }
    catch (InvalidOperationException exception)
    {
        Ensure(exception.Message.Contains("kapalı", StringComparison.Ordinal), "Beklenmeyen hata mesajı.");
    }
}

static Task TestToolDiscoveryAsync()
{
    var names = typeof(IdeaSoftTools).GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Select(method => method.GetCustomAttribute<McpServerToolAttribute>()?.Name)
        .Where(name => name is not null)
        .ToHashSet(StringComparer.Ordinal);

    Equal(12, names.Count);
    Ensure(names.Contains("ideasoft_request"), "Genel istek aracı bulunamadı.");
    Ensure(names.Contains("ideasoft_verify_webhook"), "Webhook doğrulama aracı bulunamadı.");
    return Task.CompletedTask;
}

static async Task TestWriteConfirmationAsync()
{
    var handler = new RecordingHandler("{\"id\":7}", HttpStatusCode.Created);
    using var http = new HttpClient(handler);
    using var gateway = new IdeaSoftMcpGateway(new IdeaSoftMcpOptions
    {
        StoreUrl = "https://ornek.myideasoft.com",
        AccessToken = "test-token",
        AllowWrites = true
    }, http);

    try
    {
        await gateway.SendAsync("admin", "POST", "products", null, "{}", "yanlis", default);
        throw new Exception("Yanlış onay kabul edildi.");
    }
    catch (InvalidOperationException)
    {
        // Beklenen sonuç.
    }

    var result = await gateway.SendAsync(
        "admin", "POST", "products", null, "{\"name\":\"Test\"}", IdeaSoftMcpOptions.WriteConfirmation, default);
    Equal(201, result.StatusCode);
    Equal("POST", handler.LastMethod);
}

static Task TestWebhookHmacAsync()
{
    const string body = "{\"id\":1}";
    const string secret = "yerel-test-secret";
    var signature = Convert.ToBase64String(HMACSHA256.HashData(
        Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(body)));

    using var gateway = new IdeaSoftMcpGateway(new IdeaSoftMcpOptions { ClientSecret = secret });
    Equal(true, gateway.VerifyWebhook(body, signature).IsValid);
    Equal(false, gateway.VerifyWebhook(body + "x", signature).IsValid);
    return Task.CompletedTask;
}

static IdeaSoftMcpGateway CreateGateway(HttpClient http) => new(new IdeaSoftMcpOptions
{
    StoreUrl = "https://ornek.myideasoft.com",
    AccessToken = "test-token"
}, http);

static void Ensure(bool condition, string message)
{
    if (!condition) throw new Exception(message);
}

static void Equal<T>(T expected, T actual)
{
    if (!EqualityComparer<T>.Default.Equals(expected, actual))
        throw new Exception($"Beklenen: {expected}; gerçek: {actual}");
}

internal sealed class RecordingHandler(string responseBody, HttpStatusCode statusCode = HttpStatusCode.OK) : HttpMessageHandler
{
    public string? LastUri { get; private set; }
    public string? LastMethod { get; private set; }
    public string? AuthorizationScheme { get; private set; }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        LastUri = request.RequestUri?.AbsoluteUri;
        LastMethod = request.Method.Method;
        AuthorizationScheme = request.Headers.Authorization?.Scheme;
        return Task.FromResult(new HttpResponseMessage(statusCode)
        {
            Content = new StringContent(responseBody, Encoding.UTF8, "application/json"),
            RequestMessage = request
        });
    }
}
