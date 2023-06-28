using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students").HasKey(t => t.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.Class).HasColumnName("Class").IsRequired();
        builder.Property(t => t.SchoolId).HasColumnName("SchoolId").IsRequired();
        builder.Property(t => t.ParentId).HasColumnName("ParentId").IsRequired();
        builder.Property(t => t.TeacherId).HasColumnName("TeacherId").IsRequired();
        builder.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(t => t.School);
        builder.HasOne(t => t.Parent);
        builder.HasOne(t => t.Teacher);

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

    }
}


