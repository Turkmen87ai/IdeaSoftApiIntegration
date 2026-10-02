namespace IdeaSoftApiClient;

internal static class QueryStringBuilder
{
    public static string Build(IEnumerable<KeyValuePair<string, string?>> values) =>
        string.Join("&", values
            .Where(item => item.Value is not null)
            .Select(item => $"{Uri.EscapeDataString(item.Key)}={Uri.EscapeDataString(item.Value!)}"));
}
