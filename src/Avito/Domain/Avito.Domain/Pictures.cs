using Microsoft.AspNetCore.Http;

namespace Avito.Domain;

public class Pictures
{
    /// <summary>
    /// Уникальный номер картинки
    /// </summary>
    public Guid PicturesId { get; set; }
    /// <summary>
    /// Название картинки
    /// </summary>
    public string? PicturesnName { get; set; }
    /// <summary>
    /// Ссылка на картину в БДшке
    /// </summary>
    public string Image { get; set; }
    
    public Advert PicturesAdvert { get; set; }
}