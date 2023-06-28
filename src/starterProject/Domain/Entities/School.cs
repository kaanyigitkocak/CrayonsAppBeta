using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class School : Entity<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<Teacher>? Teachers { get; set; }
    public virtual ICollection<Student>? Students { get; set; }

    public School()
    {
        Teachers = new HashSet<Teacher>();
        Students = new HashSet<Student>();
    }

    public School(
        int id,
        string name, 
        string address, 
        string phoneNumber) 
        : this()
    {
        Id = id;
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
    }
}
