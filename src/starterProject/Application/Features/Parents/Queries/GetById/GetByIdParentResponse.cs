using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Queries.GetById;
public class GetByIdParentResponse : IResponse
{
 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string StudentName { get; set; }
    public DateTime StudentDateOfBirth { get; set; }
    public string StudentClass { get; set; }



    public GetByIdParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        StudentClass = string.Empty;
        StudentName = string.Empty;
        StudentDateOfBirth = DateTime.MinValue;
    }

    public GetByIdParentResponse(int id, string name,string studentName, string studentClass, DateTime studentDateOfBirth, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        StudentDateOfBirth = studentDateOfBirth;
        StudentClass = studentClass;
        StudentName = studentName;
    }
}
