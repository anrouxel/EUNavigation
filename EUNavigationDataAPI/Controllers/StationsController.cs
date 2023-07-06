using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using EUNavigationDataAPI.Models.TransportDataGouv;

namespace EUNavigationDataAPI.Controllers;

[ApiVersion(1.0)]
[ApiController]
[Route("[controller]")]
public class StationsController : ControllerBase
{
    private readonly ILogger<StationsController> _logger;

    public StationsController(ILogger<StationsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStations")]
    public Dataset[]? Get()
    {
        using var client = new HttpClient();
        var response = client.GetFromJsonAsync<Dataset[]>($"https://transport.data.gouv.fr/api/datasets");
        return response.Result;
    }

    [HttpGet("{id}", Name = "GetStationById")]
    public Dataset? Get(string id)
    {
        using var client = new HttpClient();
        var response = client.GetFromJsonAsync<Dataset>($"https://transport.data.gouv.fr/api/datasets/{id}");
        return response.Result;
    }
}