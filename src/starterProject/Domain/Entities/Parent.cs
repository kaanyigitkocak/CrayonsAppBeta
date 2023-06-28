using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Parent : Entity<int>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int StudentId { get; set; }
    public virtual Student? Student { get; set; }

    public Parent()
    {
    }

    public Parent(
        int id,
        Student? student,
        string name, 
        string email, 
        string phoneNumber) 
        : this()
    {
        Id = id;
        Student = student;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}