using Core.Application.Dtos;

namespace Application.Features.Schools.Queries.GetList;

public class GetListSchoolListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}