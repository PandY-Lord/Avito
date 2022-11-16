using Avito.Contracts;
using Avito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avito.DataAccess.EntityConfiguration.Category;

public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Categorys>
{
    public void Configure(EntityTypeBuilder<Domain.Categorys> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(b => b.CategoryId);
        builder.Property(b => b.CategoryId).ValueGeneratedOnAdd();

        builder.HasMany(p => p.CategorysAdvert)
            .WithOne(w => w.Category).HasForeignKey(s => s.Id);

    }
}