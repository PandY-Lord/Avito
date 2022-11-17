using Avito.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Migrations;

public class MigrationsDbContext : AdvertContext
{
    public MigrationsDbContext(DbContextOptions options) : base(options)
    {
    }
}