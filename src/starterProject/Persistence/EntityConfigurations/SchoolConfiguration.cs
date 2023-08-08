using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SchoolConfiguration : IEntityTypeConfiguration<School>
{
    public void Configure(EntityTypeBuilder<School> builder)
    {
        builder.ToTable("Schools").HasKey(s => s.Id);

        builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
        builder.Property(s => s.Name).HasColumnName("Name");
        builder.Property(s => s.Address).HasColumnName("Address");
        builder.Property(s => s.PhoneNumber).HasColumnName("PhoneNumber");
        builder.Property(s => s.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(s => s.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(s => s.DeletedDate).HasColumnName("DeletedDate");

        builder.HasMany(t => t.Teachers).WithOne(t => t.School).HasForeignKey(s => s.SchoolId).OnDelete(DeleteBehavior.Restrict);
        builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
        builder.HasData(GetSChoolSeeds());
    }
    private IEnumerable<School> GetSChoolSeeds()
    {
        List<School> schools = new List<School>();

        School school1 = new School
        {
            Id = 1,
            Name = "Sample School 1",
            Address = "123 Main St",
            PhoneNumber = "555-1234",
            CreatedDate = DateTime.Now,

        };
       schools.Add(school1);
        School school2 = new School
        {
            Id = 2,
            Name = "Sample School 2",
            Address = "1234 Main St",
            PhoneNumber = "555-12342",
            CreatedDate = DateTime.Now,

        };
        schools.Add(school2);


        return schools;
    }
}