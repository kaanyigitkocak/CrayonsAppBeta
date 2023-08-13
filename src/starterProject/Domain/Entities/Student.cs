using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Student : Entity<int>
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public int TeacherId { get; set; }
    public int ParentId { get; set; }
    public int SchoolId { get; set; }
    public int FileId { get; set; }
    public virtual File? File { get; set; }

    public virtual Parent? Parent { get; set; }
    public virtual School? School { get; set; }
    public virtual Teacher? Teacher { get; set; }

    public Student()
    {
    }

    public Student(
        int id,
        int parentId,
        int schoolId,
        int teacherId,
        string name, 
        DateTime dateOfBirth, 
        string studentClass) 
        : this()
    {
        Id = id;
        ParentId = parentId;
        SchoolId = schoolId;
        TeacherId = teacherId;
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
    }
}

