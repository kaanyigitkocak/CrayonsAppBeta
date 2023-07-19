using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Commands.Update;
public class CreatedParentResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int StudentId { get; set; }

    public CreatedParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        StudentId = 0;
    }

    public CreatedParentResponse(int id, int studentId, string name, string phoneNumber, string email)
    {
        Id = id;
        StudentId = studentId;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
