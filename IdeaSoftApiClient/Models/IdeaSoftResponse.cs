using System.Net;

namespace IdeaSoftApiClient.Models;

/// <summary>Veri ile birlikte HTTP durumunu ve cevap başlıklarını taşır.</summary>
public sealed class IdeaSoftResponse<T>
{
    public required T Data { get; init; }
    public required HttpStatusCode StatusCode { get; init; }
    public required IReadOnlyDictionary<string, string[]> Headers { get; init; }
    public string? RequestId { get; init; }
}
