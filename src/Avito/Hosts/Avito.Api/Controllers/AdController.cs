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
    /// Добавить новое объявление
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }
    
    /// <summary>
    /// Удалить созданное тобой объявление
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return await Task.FromResult(Ok());
    }

    /// <summary>
    /// Тут что-то будет
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> GetAsync()
    {
        return await Task.FromResult(Ok());
    }
}