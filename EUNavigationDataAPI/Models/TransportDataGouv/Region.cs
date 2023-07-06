using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class Region
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}