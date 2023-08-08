using Core.Application.Responses;

namespace Application.Features.Schools.Commands.Update;

public class UpdatedSchoolResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}