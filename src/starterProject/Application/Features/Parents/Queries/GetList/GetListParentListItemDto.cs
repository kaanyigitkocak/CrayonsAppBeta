using Application.Features.Parents.Dtos;
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
    public string PhoneNumber { get; set; }
    public IEnumerable<StudentDto> Students { get; set; }



    public GetListParentListItemDto()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        Students = new List<StudentDto>();
    }

    public GetListParentListItemDto(int id, string name, IEnumerable<StudentDto> students, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        Students = students;
    }
}
