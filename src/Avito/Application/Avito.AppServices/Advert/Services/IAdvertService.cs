using Avito.Contracts;

namespace Avito.AppServices.Advert.Services;
/// <summary>
/// Сервси для работы с Объявлениями 
/// </summary>
public interface IAdvertService
{
    /// <summary>
    /// Взять все объявления подпендинг, исплозовать под пагинацию 
    /// </summary>
    /// <param name="take"></param>
    /// <param name="skip"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IReadOnlyCollection<AvitoAllDto>> GetAll(int take, int skip, CancellationToken cancellationToken);

    /// <summary>
    /// Взять всё по фильтрам юзера
    /// </summary>
    /// <param name="take"></param>
    /// <param name="skip"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IReadOnlyCollection<AvitoAllDto>> GetAllFiltered(AdvertFilterRequest request, CancellationToken cancellationToken);
}