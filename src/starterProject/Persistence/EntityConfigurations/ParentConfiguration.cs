using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.EntityConfigurations;
public class ParentConfiguration : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.ToTable("Parents").HasKey(t => t.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.StudentId).HasColumnName("StudentId").IsRequired();
        builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
        builder.Property(t => t.Email).HasColumnName("Email").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(t => t.Student)
            .WithOne(s => s.Parent)
            .HasForeignKey<Student>(s => s.ParentId)
            .OnDelete(DeleteBehavior.NoAction);
        

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

    }
}
