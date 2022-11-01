using Microsoft.AspNetCore.Mvc;

namespace Avito.Api.Controllers;

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
    /// Вывод обхявлений
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }

    
    /// <summary>
    /// Удаление созданного объявление
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return await Task.FromResult(Ok());
    }

    
    /// <summary>
    /// Обновление через фильтры поиска
    /// </summary>
    /// <returns></returns>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync()
    {
        return await Task.FromResult(Ok());
    }

    
    /// <summary>
    /// Добавление нового объявления
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> PostAsync()
    {
        return await Task.FromResult(Ok());
    }
}