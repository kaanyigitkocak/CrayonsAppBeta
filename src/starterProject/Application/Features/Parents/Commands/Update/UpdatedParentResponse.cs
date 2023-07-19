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
    public int PhoneNumber { get; set; }
    public UpdatedParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = default;
    }

    public UpdatedParentResponse(int id, int studentId, string name, int phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
