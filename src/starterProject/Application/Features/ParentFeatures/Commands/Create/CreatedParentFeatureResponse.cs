using Core.Application.Responses;

namespace Application.Features.ParentFeatures.Commands.Create;

public class CreatedParentFeatureResponse : IResponse
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }
}