using Avito.Contracts;
using Avito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avito.DataAccess.EntityConfiguration.Avito;
/// <summary>
/// Конфигурация таблици объявлений
/// </summary>
public class AvitoConfiguration : IEntityTypeConfiguration<Domain.Advert>
{
    public void Configure(EntityTypeBuilder<Advert> builder)
    {
        builder.ToTable("AvitoDtoAdvert");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).ValueGeneratedOnAdd();

        builder.Property(b => b.Description).HasMaxLength(1200);
        builder.Property(b => b.Title).HasMaxLength(135);


        // builder.HasOne(p => p.Category)
            // .WithMany(s => s.CategorysAdvert).HasForeignKey(s => s.Id);

    }
}