using System.Diagnostics.Contracts;

namespace Avito.Domain;

/// <summary>
/// Города для поиска товаров - Модель
/// </summary>
public class Cities
{
    /// <summary>
    ///Id города продажи товара
    /// </summary>
    public Guid LocationId { get; set; }

    /// <summary>
    /// Название города для продажи 
    /// </summary>
    public string LocationName { get; set; }
    
    public IEnumerable<Advert> CitiesAdverts { get; set; }
}