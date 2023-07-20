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
        builder.Property(t => t.SchoolId).HasColumnName("SchoolId");
        builder.Property(t => t.ParentId).HasColumnName("ParentId");
        builder.Property(t => t.TeacherId).HasColumnName("TeacherId");
        builder.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(t => t.School);
        builder.HasOne(t => t.Parent);
        builder.HasOne(t => t.Teacher);

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

        builder.HasData(GetStudentSeeds());

    }
    private IEnumerable<Student> GetStudentSeeds()
    {
        List<Student> students = new List<Student>();

        Student student1 = new Student
        {
            Id = 1,
            Name = "Jane Doe",
            DateOfBirth = new DateTime(2005, 5, 15),
            Class = "Grade 10",
            TeacherId = 1,
            ParentId = 1,
            SchoolId = 1,
        };
        students.Add(student1);

        Student student2 = new Student
        {
            Id = 2,
            Name = "Bob Johnson",
            DateOfBirth = new DateTime(2006, 8, 20),
            Class = "Grade 8",
            TeacherId = 2,
            ParentId = 2,
            SchoolId = 2,
        };
        students.Add(student2);


        return students;
    }

}


