using IdeaSoftApiClient.Models;
using IdeaSoftApiClient.Exceptions;
using System.Text.Json;

namespace IdeaSoftApiClient.Services;

/// <summary>Standart LIST/GET/POST/PUT/DELETE kaynakları için ortak istemci.</summary>
public sealed class AdminResourceClient<T> where T : class
{
    private readonly IdeaSoftClient _client;
    private readonly string _resource;

    internal AdminResourceClient(IdeaSoftClient client, string resource)
    {
        _client = client;
        _resource = resource.Trim('/');
    }

    public Task<IdeaSoftResponse<List<T>>> ListAsync(
        int page = 1,
        int limit = 20,
        IReadOnlyDictionary<string, string?>? filters = null,
        CancellationToken cancellationToken = default)
    {
        if (page < 1) throw new ArgumentOutOfRangeException(nameof(page));
        if (limit is < 1 or > 100) throw new ArgumentOutOfRangeException(nameof(limit), "limit 1 ile 100 arasında olmalıdır.");

        var query = new List<KeyValuePair<string, string?>>
        {
            new("page", page.ToString(System.Globalization.CultureInfo.InvariantCulture)),
            new("limit", limit.ToString(System.Globalization.CultureInfo.InvariantCulture))
        };
        if (filters is not null) query.AddRange(filters);
        return _client.SendAsync<List<T>>(HttpMethod.Get, _resource, query: query, cancellationToken: cancellationToken);
    }

    public Task<IdeaSoftResponse<T>> GetAsync(long id, CancellationToken cancellationToken = default) =>
        _client.SendAsync<T>(HttpMethod.Get, $"{_resource}/{Positive(id)}", cancellationToken: cancellationToken);

    public Task<IdeaSoftResponse<T>> CreateAsync(T value, CancellationToken cancellationToken = default) =>
        _client.SendAsync<T>(HttpMethod.Post, _resource, value, cancellationToken: cancellationToken);

    public Task<IdeaSoftResponse<T>> UpdateAsync(long id, T value, CancellationToken cancellationToken = default) =>
        _client.SendAsync<T>(HttpMethod.Put, $"{_resource}/{Positive(id)}", value, cancellationToken: cancellationToken);

    public async Task DeleteAsync(long id, CancellationToken cancellationToken = default) =>
        await _client.SendAsync<object?>(HttpMethod.Delete, $"{_resource}/{Positive(id)}", cancellationToken: cancellationToken)
            .ConfigureAwait(false);

    public async Task<int> CountAsync(
        IReadOnlyDictionary<string, string?>? filters = null,
        CancellationToken cancellationToken = default)
    {
        var response = await _client.SendAsync<JsonElement>(HttpMethod.Get, $"{_resource}/count", query: filters, cancellationToken: cancellationToken)
            .ConfigureAwait(false);
        if (response.Data.ValueKind == JsonValueKind.Number && response.Data.TryGetInt32(out var directCount))
            return directCount;
        if (response.Data.ValueKind == JsonValueKind.Object)
        {
            foreach (var name in new[] { "count", "total" })
            {
                if (response.Data.TryGetProperty(name, out var value) && value.TryGetInt32(out var count))
                    return count;
            }
        }

        throw new ApiException("COUNT cevabında sayısal count/total alanı bulunamadı.", responseBody: response.Data.GetRawText());
    }

    private static long Positive(long id) => id > 0 ? id : throw new ArgumentOutOfRangeException(nameof(id));
}
