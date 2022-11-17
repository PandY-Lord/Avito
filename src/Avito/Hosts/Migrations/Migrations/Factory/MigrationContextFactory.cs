using ConfigurationBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Migrations.Factory;

public class MigrationContextFactory : IDesignTimeDbContextFactory<MigrationsDbContext>
{
    public MigrationContextFactory()
    {
    }

    public MigrationsDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MigrationsDbContext>();

        //получение конфигура из файла appsetings.json
        Microsoft.Extensions.Configuration.ConfigurationBuilder builder =
            new Microsoft.Extensions.Configuration.ConfigurationBuilder();
        builder.AddJsonFile(Directory.GetCurrentDirectory());
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        IConfigurationRoot config = builder.Build();

        //получаем строку подключения из файла appsetings.json
        string connectionString = config.GetConnectionString("PostgresAvitoDb");
        optionsBuilder.UseNpgsql(connectionString, opts => opts
            .CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
            .MigrationsAssembly(typeof(MigrationContextFactory).Assembly.FullName)
        );


        return new MigrationsDbContext(optionsBuilder.Options);
    }
}