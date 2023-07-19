using Core.Application.Responses;

namespace Application.Features.Parents.Commands.Delete;

public class DeletedParentResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int StudentId { get; set; }

    public DeletedParentResponse()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        StudentId = 0;
    }

    public DeletedParentResponse(int id, int studentId, string name, string phoneNumber, string email)
    {
        Id = id;
        StudentId = studentId;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}    
