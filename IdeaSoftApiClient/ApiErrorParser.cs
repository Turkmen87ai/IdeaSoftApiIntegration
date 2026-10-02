using IdeaSoftApiClient.Exceptions;
using System.Net.Http.Headers;
using System.Text.Json;

namespace IdeaSoftApiClient;

internal static class ApiErrorParser
{
    public static ApiException Create(HttpResponseMessage response, string body, string fallbackMessage)
    {
        string? code = null;
        string? message = null;

        if (!string.IsNullOrWhiteSpace(body))
        {
            try
            {
                using var document = JsonDocument.Parse(body);
                if (document.RootElement.ValueKind == JsonValueKind.Object)
                {
                    code = ReadString(document.RootElement, "error") ?? ReadString(document.RootElement, "code");
                    message = ReadString(document.RootElement, "error_description") ??
                              ReadString(document.RootElement, "message") ??
                              ReadString(document.RootElement, "detail");
                }
            }
            catch (JsonException)
            {
                // JSON olmayan hata sayfalarında ham gövde ResponseBody üzerinden korunur.
            }
        }

        var requestId = GetFirstHeader(response.Headers, "X-Request-Id") ?? GetFirstHeader(response.Headers, "CF-Ray");
        var text = message is null ? fallbackMessage : $"{fallbackMessage} {message}";
        return new ApiException(text, (int)response.StatusCode, message, code, body, requestId);
    }

    private static string? ReadString(JsonElement element, string propertyName) =>
        element.TryGetProperty(propertyName, out var value) ? value.ToString() : null;

    private static string? GetFirstHeader(HttpResponseHeaders headers, string name) =>
        headers.TryGetValues(name, out var values) ? values.FirstOrDefault() : null;
}
