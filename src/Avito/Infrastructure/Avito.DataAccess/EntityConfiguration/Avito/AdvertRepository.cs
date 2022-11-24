using Avito.AppServices.Advert.Repositories;
using Avito.Contracts;
using Avito.Domain;
using Avito.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Avito.DataAccess.EntityConfiguration.Avito;

public class AdvertRepository : IAdvertRepository
{
    private readonly IRepository<Advert> _repository;

    public AdvertRepository(IRepository<Advert> repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<AvitoAllDto>> GetAll(int take, int skip, CancellationToken cancellationToken)
    {
        return await _repository.GetAll()
            .Select(p => new AvitoAllDto
                {
                    PersonId = p.PersonId,
                    Categoty = p.Category,
                    Price = p.Price,
                    Id = p.Id,
                    Location = p.Location,
                    Title = p.Title
                })
            .Take(take).Skip(skip).ToListAsync();
    }

    public async Task<IReadOnlyCollection<AvitoAllDto>> GetAllFiltered(AdvertFilterRequest request,
        CancellationToken cancellationToken)
    {
        var query = _repository.GetAll();

        if (request.Id.HasValue)
        {
            query = query.Where(p => p.Id == request.Id);
        }
        if (!string.IsNullOrWhiteSpace(request.Name))
        {
            query = query.Where(p => p.Title.ToLower().Contains(request.Name));
        }

        return await query.Select(p => new AvitoAllDto
                {
                    PersonId = p.PersonId,
                    Categoty = p.Category,
                    Price = p.Price,
                    Id = p.Id,
                    Location = p.Location,
                    Title = p.Title
                })
                .ToListAsync(cancellationToken);

    }
}