using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Commands.Update;
public class UpdatedParentResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int StudentId { get; set; }
    public UpdatedParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
    }

    public UpdatedParentResponse(int id, int studentId, string name, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        StudentId = studentId;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
