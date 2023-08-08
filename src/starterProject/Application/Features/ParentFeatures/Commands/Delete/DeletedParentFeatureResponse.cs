using Core.Application.Responses;

namespace Application.Features.ParentFeatures.Commands.Delete;

public class DeletedParentFeatureResponse : IResponse
{
    public int Id { get; set; }
}