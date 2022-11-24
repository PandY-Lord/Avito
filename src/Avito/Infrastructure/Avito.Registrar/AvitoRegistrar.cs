using System.Globalization;
using Avito.AppServices.Advert.Repositories;
using Avito.AppServices.Advert.Services;
using Avito.DataAccess;
using Avito.DataAccess.EntityConfiguration.Avito;
using Avito.DataAccess.Interface;
using Avito.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;

namespace Avito.Registrar;

public static class AvitoRegistrar
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddDbContext<AdvertContext>((Action<IServiceProvider, DbContextOptionsBuilder>)
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionConfigurator<AdvertContext>>()
                .Configure((DbContextOptionsBuilder<AdvertContext>)dbOptions)));
        services.AddSingleton<IDbContextOptionConfigurator<AdvertContext>, AdvertContextConfiguration>();
        services.AddScoped(sp => (DbContext) sp.GetRequiredService<AdvertContext>());
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        services.AddTransient<IAdvertRepository, AdvertRepository>();
        services.AddTransient<IAdvertService, AdvertService>();
        return services;
    }
    
}