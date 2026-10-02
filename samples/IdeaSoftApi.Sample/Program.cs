using IdeaSoftApiClient;
using IdeaSoftApiClient.Config;
using IdeaSoftApiClient.Exceptions;

var storeUrl = Environment.GetEnvironmentVariable("IDEASOFT_STORE_URL");
var accessToken = Environment.GetEnvironmentVariable("IDEASOFT_ACCESS_TOKEN");

if (string.IsNullOrWhiteSpace(storeUrl) || string.IsNullOrWhiteSpace(accessToken))
{
    Console.Error.WriteLine("IDEASOFT_STORE_URL ve IDEASOFT_ACCESS_TOKEN ortam değişkenlerini tanımlayın.");
    return 1;
}

try
{
    var config = new ApiConfig(storeUrl);
    using var client = new IdeaSoftClient(config, accessToken);
    var response = await client.Products.ListAsync(page: 1, limit: 20);

    foreach (var product in response.Data)
        Console.WriteLine($"{product.Id}: {product.Name} | SKU: {product.Sku} | Fiyat: {product.Price}");

    return 0;
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"IdeaSoft API hatası ({exception.StatusCode}): {exception.Message}");
    return 2;
}
