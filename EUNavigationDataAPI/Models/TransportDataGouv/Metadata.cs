using System.Text.Json;
using System.Text.Json.Serialization;

namespace EUNavigationDataAPI.Models.TransportDataGouv;

public class Metadata
{
    [JsonPropertyName("end_date")]
    public DateTimeOffset? EndDate { get; set; }

    [JsonPropertyName("has_fares")]
    public bool HasFares { get; set; }

    [JsonPropertyName("has_pathways")]
    public bool HasPathways { get; set; }

    [JsonPropertyName("has_shapes")]
    public bool HasShapes { get; set; }

    [JsonPropertyName("issues_count")]
    public Dictionary<string, long> IssuesCount { get; set; } = new Dictionary<string, long>();

    [JsonPropertyName("lines_count")]
    public long LinesCount { get; set; }

    [JsonPropertyName("lines_with_custom_color_count")]
    public long LinesWithCustomColorCount { get; set; }

    [JsonPropertyName("modes")]
    public List<string> Modes { get; set; } = new List<string>();

    [JsonPropertyName("networks")]
    public List<string> Networks { get; set; } = new List<string>();

    [JsonPropertyName("networks_start_end_dates")]
    public Dictionary<string, NetworksStartEndDate> NetworksStartEndDates { get; set; } = new Dictionary<string, NetworksStartEndDate>();

    [JsonPropertyName("some_stops_need_phone_agency")]
    public bool SomeStopsNeedPhoneAgency { get; set; }

    [JsonPropertyName("some_stops_need_phone_driver")]
    public bool SomeStopsNeedPhoneDriver { get; set; }

    [JsonPropertyName("start_date")]
    public DateTimeOffset? StartDate { get; set; }

    [JsonPropertyName("stop_areas_count")]
    public long StopAreasCount { get; set; }

    [JsonPropertyName("stop_points_count")]
    public long StopPointsCount { get; set; }

    [JsonPropertyName("stops_count")]
    public long StopsCount { get; set; }

    [JsonPropertyName("stops_with_wheelchair_info_count")]
    public long? StopsWithWheelchairInfoCount { get; set; }

    [JsonPropertyName("trips_count")]
    public long TripsCount { get; set; }

    [JsonPropertyName("trips_with_bike_info_count")]
    public long TripsWithBikeInfoCount { get; set; }

    [JsonPropertyName("trips_with_wheelchair_info_count")]
    public long TripsWithWheelchairInfoCount { get; set; }

    [JsonPropertyName("validator_version")]
    public string? ValidatorVersion { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trips_with_shape_count")]
    public long? TripsWithShapeCount { get; set; }
}