using Core.Application.Responses;

namespace Application.Features.ParentFeatures.Commands.Update;

public class UpdatedParentFeatureResponse : IResponse
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }
}