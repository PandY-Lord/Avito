using Avito.AppServices.Advert.Repositories;
using Avito.Contracts;

namespace Avito.AppServices.Advert.Services;

/// <inheritdoc />
public class AdvertService : IAdvertService
{

    public readonly IAdvertRepository _AdvertRepository;

    public AdvertService(IAdvertRepository advertRepository)
    {
        _AdvertRepository = advertRepository;
    }

    /// <inheritdoc />
    public Task<IReadOnlyCollection<AvitoAllDto>> GetAll(int take, int skip, CancellationToken cancellationToken)
    {
        return _AdvertRepository.GetAll(take, skip, cancellationToken);
    }

    /// <inheritdoc />
    public Task<IReadOnlyCollection<AvitoAllDto>> GetAllFiltered(AdvertFilterRequest request, CancellationToken cancellationToken)
    {
        return _AdvertRepository.GetAllFiltered(request, cancellationToken);
    }
}