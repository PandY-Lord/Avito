using System.ComponentModel.DataAnnotations;
using Avito.Domain;

namespace Avito.Contracts;

public class AvitoDto
{
    /// <summary>
    /// Уникальный ключЬ объявления
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Цена товара
    /// </summary>
    public int Price { get; set; }

    /// <summary>
    /// Описание товара
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Номер проадвца
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Дата создания/выгрузки объявления
    /// </summary>
    public DateOnly CreateDate { get; set; }

    /// <summary>
    /// Картинки товара
    /// </summary>
    public IEnumerable<string> Pictures { get; set; }

    /// <summary>
    /// Уникальный номер продавца
    /// </summary>
    public int PersonId { get; set; }

    /// <summary>
    /// Город в котором находится товар
    /// </summary>
    public Cities Location { get; set; }

    /// <summary>
    /// Категория товара
    /// </summary>
    public Categorys Category { get; set; } //Довести до списка категорий, успеть до миграций
}