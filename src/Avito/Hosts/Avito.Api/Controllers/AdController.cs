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
    /// <returns></returns>
    [HttpDelete("{Id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> DeleteAsyncAdvert(Guid Id, CancellationToken deleteCancellationToken)
    {
        return await Task.FromResult(Ok());
    }


    /// <summary>
    /// Обновление через фильтры поиска
    /// </summary>
    /// <returns></returns>
    [HttpPut("{Id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> UpdateAsyncAdvert(Guid Id, string Title, int Price, string Description,
        string PhoneNumber, IEnumerable<string> Pictures, CancellationToken putCancellationToken)
    {
        return await Task.FromResult(Ok());
    }

    //Cities Location, Categorys Category

    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <returns></returns>
    [HttpPost("{Id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> PostAsyncAdvert(Guid Id, string Title, int Price, string Description,
        string PhoneNumber, IEnumerable<string> Pictures, CancellationToken putCancellationToken) //Не хватает полей (Cities Location, Categorys Category), возможно ошибка в отсутсвии БД
    {
        return await Task.FromResult(Ok());
    }
}