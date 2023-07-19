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
public string StudentName { get; set; }
public DateTime StudentDateOfBirth { get; set; }
public string StudentClass { get; set; }



    public GetListParentListItemDto()
{
    Name = string.Empty;
    Email = string.Empty;
    PhoneNumber = default;
}

public GetListParentListItemDto(int id, string name, int phoneNumber, string email)
{
    Id = id;
    Name = name;
    PhoneNumber = phoneNumber;
    Email = email;
}
}
