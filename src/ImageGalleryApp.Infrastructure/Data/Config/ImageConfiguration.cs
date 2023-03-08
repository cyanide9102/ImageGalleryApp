using ImageGalleryApp.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImageGalleryApp.Infrastructure.Data.Config;
public class ImageConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
               .IsRequired()
               .HasMaxLength(256);

        builder.Property(i => i.Path)
               .IsRequired()
               .HasMaxLength(2048);
    }
}
