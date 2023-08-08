using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Parent : Entity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public ParentFeature ParentFeature { get; set; }
    public Parent()
    {
        Students = new HashSet<Student>();
    }

    public Parent(
        int id,
        string name, 
        string email, 
        string phoneNumber) 
        : this()
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}