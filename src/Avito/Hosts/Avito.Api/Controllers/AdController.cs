using System.Net;
using Avito.Contracts;
using Avito.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Avito.Api.Controller;

/// <summary>
/// Работа с контроллером объявлений
/// </summary>
[ApiController]
[Route("v1/[controller]")]
public class AdController : ControllerBase
{
    private readonly ILogger<AdController> _logger;

    public AdController()
    {
    }

    /// <summary>
    /// Вывод объявлений
    /// </summary>
    /// <returns></returns>
    [HttpGet("Get")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AvitoDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAsyncAdvert()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Вывод **всех** объялений
    /// </summary>
    /// <returns></returns>
    [HttpGet("GetAll")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AvitoAllDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsyncAdvert()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Удаление созданного объявление
    /// </summary>
    /// <param name="deletedAdvertDto"></param>
    /// <returns></returns>
    [HttpDelete("Delete")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> DeleteAsyncAdvert(Guid Id)
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Обновление через фильтры поиска
    /// </summary>
    /// <param name="updateAdvertDto"></param>
    /// <returns></returns>
    [HttpPut("Put")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> UpdateAsyncAdvert(CreateAndUpdateDto updateAdvertDto, CancellationToken putCancellationToken)
    {
        return await Task.FromResult(Ok());
    }

    //Cities Location, Categorys Category

    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    ///<param name="createAdvertDto"></param>
    /// <returns></returns>
    [HttpPost("Post")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> PostAsyncAdvert(CreateAndUpdateDto createAdvertDto, CancellationToken putCancellationToken)
    {
        return await Task.FromResult(Ok());
    }
}