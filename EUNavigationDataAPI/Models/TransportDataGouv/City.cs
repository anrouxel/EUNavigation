using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class City
{
    [JsonPropertyName("insee")]
    public string? Insee { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}