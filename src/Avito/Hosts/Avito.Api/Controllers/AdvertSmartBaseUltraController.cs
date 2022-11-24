using System.Net;
using Avito.AppServices.Advert.Services;
using Avito.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Avito.Api.Controller;
/// <summary>
/// Работа с контроллером объявлений
/// </summary>

[ApiController]
[Route("v1/[controller]")]

public class AdvertSmartBaseUltraController : ControllerBase
{
    private readonly IAdvertService _AdvertService;

    public AdvertSmartBaseUltraController(IAdvertService advertService)
    {
        _AdvertService = advertService;
    }

    [HttpGet(template: "GetAllAdverts")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AvitoDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAll(int take, int skip, CancellationToken cancellationToken)
    {
        var result = await _AdvertService.GetAll(take, skip, cancellationToken);
        return Ok(result);
    }
}