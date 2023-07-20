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
        builder.Property(t => t.SchoolId).HasColumnName("SchoolId");
        builder.Property(t => t.HireDate).HasColumnName("HireDate").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(t => t.School);
        builder.HasMany(t => t.Students)
            .WithOne(s => s.Teacher)
            .HasForeignKey(s => s.TeacherId).OnDelete(DeleteBehavior.NoAction);


        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);
        builder.HasData(GetTeacherSeeds());
    }

    private IEnumerable<Teacher> GetTeacherSeeds()
    {
        List<Teacher> teachers = new List<Teacher>();

        Teacher teacher1 = new Teacher
        {
            Id = 1,
            Name = "Mr. Smith",
            Email = "smith@example.com",
            PhoneNumber = "444-987-6543",
            HireDate = new DateTime(2010, 8, 20),
            SchoolId = 1,
        };
        teachers.Add(teacher1);

        Teacher teacher2 = new Teacher
        {
            Id = 2,
            Name = "Ms. Johnson",
            Email = "johnson@example.com",
            PhoneNumber = "111-222-3333",
            HireDate = new DateTime(2015, 3, 10),
            SchoolId = 2,
        };
        teachers.Add(teacher2);

        return teachers;
    }

}


