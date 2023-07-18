using Core.Application.Responses;

namespace Application.Features.Parents.Commands.Delete;

public class DeletedParentResponse : IResponse
{
    public int Id { get; set; }
}
