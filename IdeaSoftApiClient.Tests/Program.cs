using IdeaSoftApiClient;
using IdeaSoftApiClient.Authentication;
using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;
using System.Net;
using System.Text;

var tests = new (string Name, Func<Task> Run)[]
{
    ("OAuth izin adresi", TestAuthorizationUri),
    ("Bearer ve liste cevabı", TestBearerAndList),
    ("Data zarfı", TestDataEnvelope),
    ("COUNT nesnesi", TestCountObject),
    ("API hatası", TestApiError),
    ("429 yeniden deneme", TestRetry),
    ("POST otomatik tekrarlanmaz", TestPostIsNotRetried),
    ("OAuth token POST", TestTokenPost),
    ("Dönen refresh token'ı saklama", TestRefreshingProvider)
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

return failed == 0 ? 0 : 1;

static Task TestAuthorizationUri()
{
    var oauth = new IdeaSoftOAuthClient(new ApiConfig("https://demo.myideasoft.com"));
    var uri = oauth.CreateAuthorizationUri("client 1", new Uri("https://app.example/callback"), "state-value");
    Equal("https", uri.Scheme);
    Contains("/panel/auth?", uri.AbsoluteUri);
    Contains("client_id=client%201", uri.Query);
    Contains("response_type=code", uri.Query);
    Contains("state=state-value", uri.Query);
    return Task.CompletedTask;
}

static async Task TestBearerAndList()
{
    var handler = new StubHandler((request, _) =>
    {
        Equal("Bearer", request.Headers.Authorization?.Scheme);
        Equal("secret-token", request.Headers.Authorization?.Parameter);
        Equal("/admin-api/products?page=2&limit=10", request.RequestUri?.PathAndQuery);
        return Json(HttpStatusCode.OK, "[{\"id\":7,\"name\":\"Kalem\",\"sku\":\"K-1\"}]");
    });
    using var httpClient = new HttpClient(handler);
    using var client = new IdeaSoftClient(new ApiConfig("https://demo.myideasoft.com"), "secret-token", httpClient);
    var response = await client.Products.ListAsync(page: 2, limit: 10);
    Equal(1, response.Data.Count);
    Equal("K-1", response.Data[0].Sku);
}

static async Task TestDataEnvelope()
{
    var handler = new StubHandler((_, _) => Json(HttpStatusCode.OK, "{\"data\":{\"id\":9,\"name\":\"Marka\"}}"));
    using var client = new IdeaSoftClient(new ApiConfig("https://demo.myideasoft.com"), "token", new HttpClient(handler));
    var response = await client.Brands.GetAsync(9);
    Equal("Marka", response.Data.Name);
}

static async Task TestCountObject()
{
    var handler = new StubHandler((_, _) => Json(HttpStatusCode.OK, "{\"count\":27}"));
    using var client = new IdeaSoftClient(new ApiConfig("https://demo.myideasoft.com"), "token", new HttpClient(handler));
    Equal(27, await client.Products.CountAsync());
}

static async Task TestApiError()
{
    var handler = new StubHandler((_, _) => Json(HttpStatusCode.UnprocessableEntity, "{\"code\":\"validation\",\"message\":\"Alan hatalı\"}"));
    using var client = new IdeaSoftClient(new ApiConfig("https://demo.myideasoft.com"), "token", new HttpClient(handler));
    try
    {
        await client.Products.GetAsync(1);
        throw new Exception("ApiException bekleniyordu.");
    }
    catch (ApiException exception)
    {
        Equal(422, exception.StatusCode);
        Equal("validation", exception.ApiErrorCode);
        Contains("Alan hatalı", exception.Message);
    }
}

static async Task TestRetry()
{
    var calls = 0;
    var handler = new StubHandler((_, _) =>
    {
        calls++;
        return calls == 1
            ? Json(HttpStatusCode.TooManyRequests, "{\"message\":\"Yavaşla\"}")
            : Json(HttpStatusCode.OK, "[]");
    });
    var config = new ApiConfig("https://demo.myideasoft.com")
    {
        MaxRetryCount = 1,
        RetryBaseDelay = TimeSpan.Zero
    };
    using var client = new IdeaSoftClient(config, "token", new HttpClient(handler));
    await client.Products.ListAsync();
    Equal(2, calls);
}

static async Task TestPostIsNotRetried()
{
    var calls = 0;
    var handler = new StubHandler((_, _) =>
    {
        calls++;
        return Json(HttpStatusCode.ServiceUnavailable, "{\"message\":\"Geçici hata\"}");
    });
    var config = new ApiConfig("https://demo.myideasoft.com")
    {
        MaxRetryCount = 3,
        RetryBaseDelay = TimeSpan.Zero
    };
    using var client = new IdeaSoftClient(config, "token", new HttpClient(handler));
    try
    {
        await client.Products.CreateAsync(new() { Name = "Tek kayıt" });
        throw new Exception("ApiException bekleniyordu.");
    }
    catch (ApiException)
    {
        Equal(1, calls);
    }
}

static async Task TestTokenPost()
{
    var handler = new StubHandler(async (request, cancellationToken) =>
    {
        Equal(HttpMethod.Post, request.Method);
        Equal("/oauth/v2/token", request.RequestUri?.AbsolutePath);
        var form = await request.Content!.ReadAsStringAsync(cancellationToken);
        Contains("grant_type=refresh_token", form);
        Contains("refresh_token=refresh", form);
        return Json(HttpStatusCode.OK, "{\"access_token\":\"access\",\"refresh_token\":\"new-refresh\",\"expires_in\":86400,\"token_type\":\"bearer\"}");
    });
    var oauth = new IdeaSoftOAuthClient(new ApiConfig("https://demo.myideasoft.com"), new HttpClient(handler));
    var token = await oauth.RefreshAsync("client", "secret", "refresh");
    Equal("access", token.AccessToken);
    Equal("new-refresh", token.RefreshToken);
}

static async Task TestRefreshingProvider()
{
    var calls = 0;
    var savedRefreshToken = string.Empty;
    var handler = new StubHandler((_, _) =>
    {
        calls++;
        return Json(HttpStatusCode.OK, "{\"access_token\":\"new-access\",\"refresh_token\":\"rotated-refresh\",\"expires_in\":86400}");
    });
    var oauth = new IdeaSoftOAuthClient(new ApiConfig("https://demo.myideasoft.com"), new HttpClient(handler));
    using var provider = new RefreshingAccessTokenProvider(
        oauth,
        "client",
        "secret",
        new OAuthToken { AccessToken = "expired", RefreshToken = "old-refresh", ExpiresIn = 0 },
        (newToken, _) =>
        {
            savedRefreshToken = newToken.RefreshToken;
            return Task.CompletedTask;
        });

    Equal("new-access", await provider.GetAccessTokenAsync());
    Equal("new-access", await provider.GetAccessTokenAsync());
    Equal("rotated-refresh", savedRefreshToken);
    Equal(1, calls);
}

static HttpResponseMessage Json(HttpStatusCode statusCode, string content) => new(statusCode)
{
    Content = new StringContent(content, Encoding.UTF8, "application/json")
};

static void Equal<T>(T expected, T actual)
{
    if (!EqualityComparer<T>.Default.Equals(expected, actual))
        throw new Exception($"Beklenen: {expected}; gelen: {actual}");
}

static void Contains(string expected, string? actual)
{
    if (actual is null || !actual.Contains(expected, StringComparison.Ordinal))
        throw new Exception($"'{expected}' değeri bulunamadı. Gelen: {actual}");
}

file sealed class StubHandler : HttpMessageHandler
{
    private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _handler;

    public StubHandler(Func<HttpRequestMessage, CancellationToken, HttpResponseMessage> handler)
        : this((request, token) => Task.FromResult(handler(request, token)))
    {
    }

    public StubHandler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handler) => _handler = handler;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
        _handler(request, cancellationToken);
}
