using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class Dataset
{
    [JsonPropertyName("aom")]
    public Aom Aom { get; set; } = new Aom();

    [JsonPropertyName("community_resources")]
    public List<CommunityResource> CommunityResources { get; set; } = new List<CommunityResource>();

    [JsonPropertyName("covered_area")]
    public CoveredArea CoveredArea { get; set; } = new CoveredArea();

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("datagouv_id")]
    public string? DatagouvId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("licence")]
    public string? Licence { get; set; }

    [JsonPropertyName("page_url")]
    public Uri? PageUrl { get; set; }

    [JsonPropertyName("publisher")]
    public Publisher Publisher { get; set; } = new Publisher();

    [JsonPropertyName("resources")]
    public List<Resource> Resources { get; set; } = new List<Resource>();

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("updated")]
    public DateTimeOffset? Updated { get; set; }
}