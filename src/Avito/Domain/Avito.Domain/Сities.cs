namespace Avito.Domain;

/// <summary>
/// Города для поиска товаров - Модель
/// </summary>
public class Сities
{
    /// <summary>
    ///Id города продажи товара
    /// </summary>
    public Guid LocationId { get; set; }
    /// <summary>
    /// Название города для продажи 
    /// </summary>
    public string LocationName { get; set; }
}