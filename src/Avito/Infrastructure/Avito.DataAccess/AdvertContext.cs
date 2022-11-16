using System.Data.Common;
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
}