using System.Net;
using Avito.Contracts;
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
    [HttpGet ("Get")]

    [ProducesResponseType(typeof(IReadOnlyCollection<AvitoDto>),(int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Вывод **всех** объялений
    /// </summary>
    /// <returns></returns>
    [HttpGet ("GetAll")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AvitoAllDto>),(int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync()
    {
        return await Task.FromResult(Ok());
    }
    
    /// <summary>
    /// Удаление созданного объявление
    /// </summary>
    /// <returns></returns>
    [HttpDelete ("Post")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return await Task.FromResult(Ok());
    }

    
    /// <summary>
    /// Обновление через фильтры поиска
    /// </summary>
    /// <returns></returns>
    [HttpPut ("Put")]
    public async Task<IActionResult> UpdateAsync()
    {
        return await Task.FromResult(Ok());
    }

    
    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <returns></returns>
    [HttpPost ("Post")]
    public async Task<IActionResult> PostAsync()
    {
        return await Task.FromResult(Ok());
    }
}