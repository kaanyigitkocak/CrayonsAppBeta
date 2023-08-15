using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class StudentFileConfiguration : IEntityTypeConfiguration<StudentFile>
{
    public void Configure(EntityTypeBuilder<StudentFile> builder)
    {
        builder.HasOne(sf => sf.Student)
            .WithMany(s => s.StudentFiles)
            .HasForeignKey(sf => sf.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

    }
}


