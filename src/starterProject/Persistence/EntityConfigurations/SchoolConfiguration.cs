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
        builder.HasData(GetSchoolSeeds());
    }

    private IEnumerable<School> GetSchoolSeeds()
    {
        List<School> schools = new List<School>();

        School school1 = new School
        {
            Id = 1,
            Name = "Example School",
            Address = "123 Main St",
            PhoneNumber = "555-123-4567",
        };
        schools.Add(school1);

        School school2 = new School
        {
            Id = 2,
            Name = "Another School",
            Address = "456 Elm Ave",
            PhoneNumber = "555-987-6543",
        };
        schools.Add(school2);


        return schools;
    }

}


