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
        builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
        builder.Property(t => t.Email).HasColumnName("Email").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasMany(t => t.Students)
            .WithOne(s => s.Parent)
            .HasForeignKey(s => s.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.ParentFeature)
           .WithOne(pf => pf.Parent)
           .HasForeignKey<ParentFeature>(pf => pf.ParentId)
           .OnDelete(DeleteBehavior.Cascade);


        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);
        builder.HasData(GetParentSeeds());
    }

    private IEnumerable<Parent> GetParentSeeds()
    {
        List<Parent> parents = new List<Parent>();

        Parent parent1 = new Parent
        {
            Id = 1,
            Name = "John Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123-456-7890",
        };
        parents.Add(parent1);

        Parent parent2 = new Parent
        {
            Id = 2,
            Name = "Alice Smith",
            Email = "alice.smith@example.com",
            PhoneNumber = "987-654-3210",
        };
        parents.Add(parent2);

        return parents;
    }
}
