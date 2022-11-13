namespace Avito.Domain;

public class Category
{
    /// <summary>
    /// Id категории
    /// </summary>
    public Guid CategoryId { get; set; }
    /// <summary>
    /// Наименование категории
    /// </summary>
    public string CategoryName { get; set; }
}