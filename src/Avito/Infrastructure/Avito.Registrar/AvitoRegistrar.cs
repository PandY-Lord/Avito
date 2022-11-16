using System.Globalization;
using Avito.DataAccess;
using Avito.DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
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
        return services;
    }
    
}