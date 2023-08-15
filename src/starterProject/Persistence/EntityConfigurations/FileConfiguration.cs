using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Domain.Entities.File;

namespace Persistence.EntityConfigurations;

public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("Files");
        builder.HasKey(e => e.Id);
        

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.Discriminator).HasColumnName("Discriminator").IsRequired();
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.FullPath)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.MimeType)
            .IsRequired()
            .HasMaxLength(50);


    }
}