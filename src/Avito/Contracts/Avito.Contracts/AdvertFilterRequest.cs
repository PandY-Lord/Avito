using Avito.Domain;

namespace Avito.Contracts;

/// <summary>
/// Фильтр для объявлений
/// </summary>
public class AdvertFilterRequest
{
    /// <summary>
    /// Филтрация по ID
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Фильтрация по наименования объявления
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Фильтрация по цене объявления
    /// </summary>
    public int? Price { get; set; }

    /// <summary>
    /// Фильтрация по городу, в котором объявление
    /// </summary>
    public Cities? Cities { get; set; }

    /// <summary>
    /// Фильтр по категории товара
    /// </summary>
    public Categorys? Category { get; set; }
}