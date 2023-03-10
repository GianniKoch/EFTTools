using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using TarkovDevData.Services.Interfaces;

namespace EFTToolsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EftToolsApiController : ControllerBase
{
    private readonly ILogger<EftToolsApiController> _logger;
    private readonly ITarkovDevDataService _tarkovDevDataService;

    public EftToolsApiController(ILogger<EftToolsApiController> logger,
        ITarkovDevDataService tarkovDevDataService)
    {
        _logger = logger;
        _tarkovDevDataService = tarkovDevDataService;
    }

    [HttpGet("Items")]
    [OutputCache]
    public async Task<IActionResult> GetItems(CancellationToken ct)
    {
        var items = await _tarkovDevDataService.GetAllItems(ct);
        _logger.LogInformation("Retrieving all items.");
        return Ok(items);
    }

    [HttpGet("Ammo")]
    [OutputCache]
    public async Task<IActionResult> GetAmmo(CancellationToken ct)
    {
        var items = await _tarkovDevDataService.GetAmmo(ct);
        _logger.LogInformation("Retrieving all ammo.");
        return Ok(items);
    }
}