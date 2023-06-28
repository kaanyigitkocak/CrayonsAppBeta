using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Teacher : Entity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int SchoolId { get; set; }
        public virtual School? School { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

        public Teacher()
        {
            Students = new HashSet<Student>();
        }

        public Teacher(
            int id,
            School? school,
            string name, 
            string email, 
            string phoneNumber, 
            DateTime hireDate) 
            : this()
        {
            Id=id;
            School=school;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            HireDate = hireDate;
        }
    }

   
    

    

}
