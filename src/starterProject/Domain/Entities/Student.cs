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

    public virtual Parent? Parent { get; set; }
    public virtual School? School { get; set; }
    public virtual Teacher? Teacher { get; set; }

    public Student()
    {
    }

    public Student(
        int id,
        Parent? parent,
        School? school,
        Teacher? teacher,
        string name, 
        DateTime dateOfBirth, 
        string studentClass) 
        : this()
    {
        Id = id;
        Parent = parent;
        School = school;
        Teacher = teacher;
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
    }
}

