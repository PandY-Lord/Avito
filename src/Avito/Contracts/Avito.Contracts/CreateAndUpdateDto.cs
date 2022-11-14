using Avito.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Avito.Contracts;

public class CreateAndUpdateDto

{
    /// <summary>
    /// Наименование товара
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Цена товара
    /// </summary>
    public int Price { get; set; }
    /// <summary>
    /// Дата создания/выгрузки объявления
    /// </summary>
    public DateOnly CreateDate { get; set; }
    /// <summary>
    /// Картинки товара
    /// </summary>
    public IEnumerable<IFormFile> Picture { get; set; }
    /// <summary>
    /// Уникальный id продавца
    /// </summary>
    public int PersonId { get; set; }
    /// <summary>
    /// Город в котором находится товар
    /// </summary>
    public Cities Location { get; set; }
    /// <summary>
    /// Категория товара
    /// </summary>
    public Categorys Categoty { get; set; } //Довести до списка категорий, успеть до миграций
}