using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class Publisher
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}