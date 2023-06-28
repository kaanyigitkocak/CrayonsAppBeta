using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teachers").HasKey(t => t.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
        builder.Property(t => t.Email).HasColumnName("Email").IsRequired();
        builder.Property(t => t.SchoolId).HasColumnName("SchoolId").IsRequired();
        builder.Property(t => t.HireDate).HasColumnName("HireDate").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(t => t.School);
        builder.HasMany(t => t.Students)
            .WithOne(s => s.Teacher)
            .HasForeignKey(s => s.TeacherId).OnDelete(DeleteBehavior.NoAction);
        

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

    }
}


