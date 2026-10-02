using System.Text.Json;
using System.Text.Json.Serialization;

namespace IdeaSoftApiClient.Models;

/// <summary>IdeaSoft yönetim API'sindeki üye (Member) modeli.</summary>
public sealed class Member
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("firstname")] public string? FirstName { get; set; }
    [JsonPropertyName("surname")] public string? Surname { get; set; }
    [JsonPropertyName("email")] public string? Email { get; set; }
    [JsonPropertyName("phoneNumber")] public string? PhoneNumber { get; set; }
    [JsonPropertyName("mobilePhoneNumber")] public string? MobilePhoneNumber { get; set; }
    [JsonPropertyName("status")] public string? Status { get; set; }
    [JsonPropertyName("createdAt")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("updatedAt")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonExtensionData] public Dictionary<string, JsonElement>? AdditionalData { get; set; }
}
