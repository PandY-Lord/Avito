using System.Data.Common;
using Avito.DataAccess.EntityConfiguration.Avito;
using Avito.DataAccess.EntityConfiguration.Category;
using Avito.DataAccess.EntityConfiguration.Cities;
using Avito.DataAccess.EntityConfiguration.Picture;
using Microsoft.EntityFrameworkCore;

namespace Avito.DataAccess;

public class AdvertContext : DbContext
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="AdvertContext"/>
    /// </summary>
    /// <param name="options"></param>
    public AdvertContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration( new AvitoConfiguration());
        modelBuilder.ApplyConfiguration( new CategoryConfiguration());
        modelBuilder.ApplyConfiguration( new CityConfiguration());
        modelBuilder.ApplyConfiguration( new PictureConfiguration()); 
    }
}