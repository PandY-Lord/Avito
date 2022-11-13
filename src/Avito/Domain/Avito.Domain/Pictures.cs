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
    public string PicturesnName { get; set; }
    /// <summary>
    /// Картинка, которую загружают
    /// </summary>
    public IFormFile Image { get; set; }
}