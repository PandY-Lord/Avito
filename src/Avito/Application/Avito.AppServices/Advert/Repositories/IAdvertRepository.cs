using Avito.Contracts;

namespace Avito.AppServices.Advert.Repositories;

public interface IAdvertRepository
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
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="take"></param>
    /// <param name="skip"></param>
    /// <returns></returns>
    Task<IReadOnlyCollection<AvitoAllDto>> GetAllFiltered(AdvertFilterRequest request, CancellationToken cancellationToken);
}