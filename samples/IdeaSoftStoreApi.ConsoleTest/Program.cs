using IdeaSoftApiClient;
using IdeaSoftApiClient.Authentication;
using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;
using System.Net;
using System.Text;

const string StoreUrlVariable = "IDEASOFT_STORE_URL";
const string AccessTokenVariable = "IDEASOFT_ACCESS_TOKEN";
const string ClientIdVariable = "IDEASOFT_CLIENT_ID";
const string ClientSecretVariable = "IDEASOFT_CLIENT_SECRET";
const string RedirectUriVariable = "IDEASOFT_REDIRECT_URI";
const string RefreshTokenVariable = "IDEASOFT_REFRESH_TOKEN";

using var cancellation = new CancellationTokenSource();
Console.CancelKeyPress += (_, eventArgs) =>
{
    eventArgs.Cancel = true;
    cancellation.Cancel();
};

try
{
    var mode = args.Length == 0 ? "--self-test" : args[0].ToLowerInvariant();
    if (mode is "--help" or "-h")
    {
        PrintUsage();
        return 0;
    }

    if (mode is not ("--self-test" or "--live" or "--all"))
    {
        Console.Error.WriteLine($"Bilinmeyen seçenek: {args[0]}");
        PrintUsage();
        return 1;
    }

    if (mode is "--self-test" or "--all")
    {
        var selfTestSuccess = await RunSelfTestsAsync(cancellation.Token);
        if (!selfTestSuccess)
            return 2;
    }

    if (mode is "--live" or "--all")
    {
        var liveTestSuccess = await RunLiveTestsAsync(cancellation.Token);
        return liveTestSuccess ? 0 : 2;
    }

    return 0;
}
catch (OperationCanceledException)
{
    Console.Error.WriteLine("İşlem kullanıcı tarafından iptal edildi.");
    return 130;
}
catch (ApiException exception)
{
    PrintApiError("IdeaSoft Store API", exception);
    return 2;
}
catch (Exception exception) when (exception is ArgumentException or InvalidOperationException or UriFormatException)
{
    Console.Error.WriteLine($"[HATA] {exception.Message}");
    return 2;
}

static async Task<bool> RunSelfTestsAsync(CancellationToken cancellationToken)
{
    Console.WriteLine("Store API yerel testleri başlıyor; ağ bağlantısı ve kimlik bilgisi kullanılmayacak...\n");

    var tests = new (string Name, Func<Task> Run)[]
    {
        ("Mağaza URL normalizasyonu", TestStoreUrlNormalizationAsync),
        ("OAuth izin URL'si ve state", TestAuthorizationUriAsync),
        ("Bearer başlığı ve Store API yolu", () => TestBearerRequestAsync(cancellationToken)),
        ("Harici URL güvenlik engeli", TestExternalUrlRejectionAsync)
    };

    var successful = 0;
    foreach (var test in tests)
    {
        try
        {
            await test.Run();
            Console.WriteLine($"[BAŞARILI] {test.Name}");
            successful++;
        }
        catch (Exception exception)
        {
            Console.Error.WriteLine($"[HATA] {test.Name}: {exception.Message}");
        }
    }

    Console.WriteLine($"\nStore API yerel sonuç: {successful}/{tests.Length} test başarılı.");
    return successful == tests.Length;
}

static async Task<bool> RunLiveTestsAsync(CancellationToken cancellationToken)
{
    var config = new ApiConfig(Required(StoreUrlVariable));
    var accessToken = Environment.GetEnvironmentVariable(AccessTokenVariable);
    if (string.IsNullOrWhiteSpace(accessToken))
        accessToken = await AcquireAccessTokenAsync(config, cancellationToken);

    using var client = new IdeaSoftStoreClient(config, accessToken);
    return await RunReadOnlyTestsAsync(client, cancellationToken);
}

static Task TestStoreUrlNormalizationAsync()
{
    var config = new ApiConfig("https://ornek.myideasoft.com/panel/test?x=1");
    Ensure(
        config.StoreUri.AbsoluteUri == "https://ornek.myideasoft.com/",
        $"Beklenmeyen mağaza kökü: {config.StoreUri}");
    return Task.CompletedTask;
}

static Task TestAuthorizationUriAsync()
{
    var config = new ApiConfig("https://ornek.myideasoft.com");
    using var oauth = new IdeaSoftOAuthClient(config);
    var redirectUri = new Uri("https://uygulama.example/ideasoft/callback");
    const string state = "0123456789abcdef0123456789abcdef";
    var uri = oauth.CreateAuthorizationUri("ornek-client", redirectUri, state);
    var query = ParseQuery(uri.Query);

    Ensure(uri.AbsolutePath == "/panel/auth", "OAuth izin yolu yanlış.");
    Ensure(query.GetValueOrDefault("client_id") == "ornek-client", "Client ID URL'ye eklenmedi.");
    Ensure(query.GetValueOrDefault("redirect_uri") == redirectUri.AbsoluteUri, "Redirect URI yanlış.");
    Ensure(query.GetValueOrDefault("state") == state, "OAuth state yanlış.");
    Ensure(query.GetValueOrDefault("response_type") == "code", "OAuth response_type yanlış.");
    return Task.CompletedTask;
}

static async Task TestBearerRequestAsync(CancellationToken cancellationToken)
{
    var handler = new RecordingHandler();
    using var httpClient = new HttpClient(handler);
    using var client = new IdeaSoftStoreClient(
        new ApiConfig("https://ornek.myideasoft.com"),
        "yerel-store-test-token",
        httpClient);

    var response = await client.Products.ListAsync(page: 1, limit: 1, cancellationToken: cancellationToken);

    Ensure(response.StatusCode == HttpStatusCode.OK, "Test cevabı başarılı işlenmedi.");
    var recordedRequest = handler.LastRequest ?? throw new InvalidOperationException("HTTP isteği yakalanmadı.");
    Ensure(recordedRequest.AuthorizationScheme == "Bearer", "Bearer şeması kullanılmadı.");
    Ensure(recordedRequest.AuthorizationParameter == "yerel-store-test-token", "Access token başlığa eklenmedi.");
    Ensure(
        recordedRequest.Uri == "https://ornek.myideasoft.com/api/products?page=1&limit=1",
        $"Beklenmeyen Store API adresi: {recordedRequest.Uri}");
}

static async Task TestExternalUrlRejectionAsync()
{
    using var client = new IdeaSoftStoreClient(new ApiConfig("https://ornek.myideasoft.com"), "yerel-store-test-token");

    try
    {
        await client.SendAsync<object>(HttpMethod.Get, "https://example.com/token-sizdirma");
        throw new InvalidOperationException("Harici URL kabul edildi.");
    }
    catch (ArgumentException)
    {
        // Beklenen güvenlik davranışı.
    }
}

static async Task<string> AcquireAccessTokenAsync(ApiConfig config, CancellationToken cancellationToken)
{
    var clientId = Required(ClientIdVariable);
    var clientSecret = Required(ClientSecretVariable);
    var redirectUri = new Uri(Required(RedirectUriVariable), UriKind.Absolute);
    var refreshToken = Environment.GetEnvironmentVariable(RefreshTokenVariable);

    using var oauth = new IdeaSoftOAuthClient(config);
    OAuthToken token;

    if (!string.IsNullOrWhiteSpace(refreshToken))
    {
        Console.WriteLine("Refresh token ile yeni token isteniyor...");
        token = await oauth.RefreshAsync(clientId, clientSecret, refreshToken, cancellationToken);
    }
    else
    {
        var expectedState = IdeaSoftOAuthClient.CreateState();
        var authorizationUri = oauth.CreateAuthorizationUri(clientId, redirectUri, expectedState);

        Console.WriteLine("\n1. Aşağıdaki adresi tarayıcıda açın ve yetkili kullanıcıyla izin verin:");
        Console.WriteLine(authorizationUri);
        Console.WriteLine("\n2. Yönlendirme tamamlanınca tarayıcının adres çubuğundaki TAM URL'yi hemen buraya yapıştırın.");
        Console.WriteLine("   Authorization code yaklaşık 30 saniye geçerlidir.");
        Console.Write("Yönlendirilen URL: ");

        var callbackText = Console.ReadLine();
        var callback = ParseAuthorizationResponse(callbackText);
        if (!string.Equals(callback.State, expectedState, StringComparison.Ordinal))
            throw new InvalidOperationException("OAuth state değeri eşleşmedi. İşlem güvenlik nedeniyle durduruldu.");

        token = await oauth.ExchangeCodeAsync(
            clientId,
            clientSecret,
            callback.Code,
            redirectUri,
            cancellationToken);
    }

    Console.WriteLine($"Token alındı. Bitiş zamanı (UTC): {token.ExpiresAt:O}");
    Console.WriteLine("Access/refresh token değerleri ekrana yazılmadı ve diske kaydedilmedi.");
    return token.AccessToken;
}

static async Task<bool> RunReadOnlyTestsAsync(IdeaSoftStoreClient client, CancellationToken cancellationToken)
{
    Console.WriteLine("\nStore API salt okunur bağlantı testleri başlıyor...");

    var results = new[]
    {
        await RunTestAsync(
            "Store ürünler",
            async () => (await client.Products.ListAsync(page: 1, limit: 1, cancellationToken: cancellationToken)).StatusCode),
        await RunTestAsync(
            "Store kategoriler",
            async () => (await client.Categories.ListAsync(page: 1, limit: 1, cancellationToken: cancellationToken)).StatusCode),
        await RunTestAsync(
            "Store siparişler",
            async () => (await client.Orders.ListAsync(page: 1, limit: 1, cancellationToken: cancellationToken)).StatusCode)
    };

    var successful = results.Count(result => result);
    Console.WriteLine($"\nStore API sonucu: {successful}/{results.Length} test başarılı.");
    return successful == results.Length;
}

static async Task<bool> RunTestAsync(string name, Func<Task<HttpStatusCode>> request)
{
    try
    {
        var status = await request();
        Console.WriteLine($"[BAŞARILI] {name}: HTTP {(int)status}");
        return true;
    }
    catch (ApiException exception)
    {
        PrintApiError(name, exception);
        return false;
    }
}

static AuthorizationResponse ParseAuthorizationResponse(string? value)
{
    if (string.IsNullOrWhiteSpace(value) || !Uri.TryCreate(value.Trim(), UriKind.Absolute, out var uri))
        throw new InvalidOperationException("Geçerli tam yönlendirme URL'si girilmedi.");

    var query = ParseQuery(uri.Query);
    if (query.TryGetValue("error", out var error))
        throw new InvalidOperationException($"OAuth yetkilendirmesi reddedildi: {error}");
    if (!query.TryGetValue("code", out var code) || string.IsNullOrWhiteSpace(code))
        throw new InvalidOperationException("Yönlendirme URL'sinde code parametresi bulunamadı.");
    if (!query.TryGetValue("state", out var state) || string.IsNullOrWhiteSpace(state))
        throw new InvalidOperationException("Yönlendirme URL'sinde state parametresi bulunamadı.");

    return new AuthorizationResponse(code, state);
}

static Dictionary<string, string> ParseQuery(string query)
{
    var result = new Dictionary<string, string>(StringComparer.Ordinal);
    foreach (var item in query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries))
    {
        var parts = item.Split('=', 2);
        var name = Uri.UnescapeDataString(parts[0].Replace('+', ' '));
        var value = parts.Length == 2
            ? Uri.UnescapeDataString(parts[1].Replace('+', ' '))
            : string.Empty;
        result[name] = value;
    }

    return result;
}

static string Required(string variableName)
{
    var value = Environment.GetEnvironmentVariable(variableName);
    return string.IsNullOrWhiteSpace(value)
        ? throw new InvalidOperationException($"{variableName} ortam değişkeni tanımlı değil.")
        : value.Trim();
}

static void Ensure(bool condition, string message)
{
    if (!condition)
        throw new InvalidOperationException(message);
}

static void PrintUsage()
{
    Console.WriteLine("IdeaSoft Store API Console Test");
    Console.WriteLine("  --self-test  Ağ kullanmadan Store istemcisini test eder (varsayılan).");
    Console.WriteLine("  --live       Gerçek mağazada yalnız Store ürün/kategori/sipariş GET çağrıları yapar.");
    Console.WriteLine("  --all        Önce yerel Store testlerini, ardından canlı Store testini çalıştırır.");
}

static void PrintApiError(string operation, ApiException exception)
{
    var status = exception.StatusCode > 0 ? exception.StatusCode.ToString() : "bilinmiyor";
    Console.Error.WriteLine($"[HATA] {operation}: HTTP {status} - {exception.ApiErrorMessage ?? exception.Message}");
    if (!string.IsNullOrWhiteSpace(exception.ApiErrorCode))
        Console.Error.WriteLine($"       API kodu: {exception.ApiErrorCode}");
    if (!string.IsNullOrWhiteSpace(exception.RequestId))
        Console.Error.WriteLine($"       Request ID: {exception.RequestId}");
}

internal sealed record AuthorizationResponse(string Code, string State);

internal sealed class RecordingHandler : HttpMessageHandler
{
    public RecordedRequest? LastRequest { get; private set; }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        LastRequest = new RecordedRequest(
            request.RequestUri?.AbsoluteUri,
            request.Headers.Authorization?.Scheme,
            request.Headers.Authorization?.Parameter);

        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("[]", Encoding.UTF8, "application/json"),
            RequestMessage = request
        };
        return Task.FromResult(response);
    }
}

internal sealed record RecordedRequest(
    string? Uri,
    string? AuthorizationScheme,
    string? AuthorizationParameter);
