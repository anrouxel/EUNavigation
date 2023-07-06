using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class NetworksStartEndDate
{
    [JsonPropertyName("end_date")]
    public DateTimeOffset EndDate { get; set; }

    [JsonPropertyName("start_date")]
    public DateTimeOffset StartDate { get; set; }
}