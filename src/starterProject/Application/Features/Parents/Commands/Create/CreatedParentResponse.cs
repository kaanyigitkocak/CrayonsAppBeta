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

    public CreatedParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
    }

    public CreatedParentResponse(int id, string name, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
