using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder.ToTable("Schools").HasKey(t => t.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
        builder.Property(t => t.Address).HasColumnName("Address").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        
        builder.HasMany(t => t.Students)
            .WithOne(s => s.School)
            .HasForeignKey(s => s.SchoolId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(t => t.Teachers)
            .WithOne(s => s.School)
            .HasForeignKey(s => s.SchoolId).OnDelete(DeleteBehavior.NoAction);

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

    }
}


