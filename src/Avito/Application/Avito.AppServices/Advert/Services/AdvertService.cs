using Avito.Contracts;

namespace Avito.AppServices.Advert.Services;

public class AdvertService : IAdvertService
{
    public Task<IReadOnlyCollection<AvitoAllDto>> GetAll(int take, int skip)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<AvitoAllDto>> GetAllFiltered(AdvertFilterRequest request)
    {
        throw new NotImplementedException();
    }
}