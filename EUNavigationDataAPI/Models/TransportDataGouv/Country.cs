using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class Country
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}