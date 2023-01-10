using Microsoft.AspNetCore.Mvc;

namespace EFTToolsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EFTToolsApiController : ControllerBase
{

    private readonly ILogger<EFTToolsApiController> _logger;

    public EFTToolsApiController(ILogger<EFTToolsApiController> logger)
    {
        _logger = logger;
    }

    // [HttpGet]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //         {
    //             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //             TemperatureC = Random.Shared.Next(-20, 55),
    //             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //         })
    //         .ToArray();
    // }
}