namespace Avito.Domain;

public class Categorys
{
    /// <summary>
    /// Id категории
    /// </summary>
    public Guid CategoryId { get; set; }
    /// <summary>
    /// Наименование категории
    /// </summary>
    public string CategoryName { get; set; }
    
    public IEnumerable<Advert>? CategorysAdvert { get; set; }
}