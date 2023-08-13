using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = Domain.Entities.File;

namespace Persistence.EntityConfigurations;

public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("Files").HasKey(x => x.Id);
        
        
        

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.FullPath)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.MimeType)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(x => x.Student)
     .WithOne(s => s.File)
     .HasForeignKey<Student>(s => s.FileId)
     .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Invoice)
    .WithOne(s => s.File)
    .HasForeignKey<Invoice>(s => s.FileId)
    .OnDelete(DeleteBehavior.NoAction);

    }
}