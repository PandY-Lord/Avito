using Avito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avito.DataAccess.EntityConfiguration.Picture;

public class PictureConfiguration : IEntityTypeConfiguration<Pictures>
{
    public void Configure(EntityTypeBuilder<Pictures> builder)
    {
        builder.ToTable("Picture");

        builder.HasKey(b => b.PicturesId);
        builder.Property(b => b.PicturesId).ValueGeneratedOnAdd();
        
        // builder.HasOne(p=> p.PicturesAdvert).WithMany(s =>s.)
        builder.HasOne(p => p.PicturesAdvert).WithMany(s => s.Pictures).HasForeignKey(s => s.PicturesId);
    }
}