using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class CommunityResource
{
    [JsonPropertyName("community_resource_publisher")]
    public string? CommunityResourcePublisher { get; set; }

    [JsonPropertyName("datagouv_id")]
    public Guid DatagouvId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("is_available")]
    public bool IsAvailable { get; set; }

    [JsonPropertyName("original_url")]
    public Uri? OriginalUrl { get; set; }

    [JsonPropertyName("page_url")]
    public Uri? PageUrl { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("updated")]
    public DateTimeOffset Updated { get; set; }

    [JsonPropertyName("url")]
    public Uri? Url { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_resource_url")]
    public Uri? OriginalResourceUrl { get; set; }
}