using Core.Application.Dtos;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Queries.GetList;

public class GetListParentListItemDto : IDto
{ 
public int Id { get; set; }
public string Name { get; set; }
public string Email { get; set; }
public int PhoneNumber { get; set; }
public bool Status { get; set; }

public GetListParentListItemDto()
{
    Name = string.Empty;
    Email = string.Empty;
    PhoneNumber = default;
}

public GetListParentListItemDto(int id, string name, int phoneNumber, string email, bool status)
{
    Id = id;
    Name = name;
    PhoneNumber = phoneNumber;
    Email = email;
    Status = status;
}
}
