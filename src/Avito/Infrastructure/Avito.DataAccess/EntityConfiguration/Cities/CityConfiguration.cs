using Avito.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avito.DataAccess.EntityConfiguration.Cities;

public class CityConfiguration : IEntityTypeConfiguration<Domain.Cities>
{
    public void Configure(EntityTypeBuilder<Domain.Cities> builder)
    {
        builder.ToTable("Cities");

        builder.HasKey(b => b.LocationId);
        builder.Property(b => b.LocationId).ValueGeneratedOnAdd();

        builder.Property(b => b.LocationName).HasMaxLength(666);

        builder.HasMany(p => p.CitiesAdverts)
            .WithOne(s => s.Location).HasForeignKey(s => s.Id);
    }
}