using Core.Application.Responses;

namespace Application.Features.ParentFeatures.Queries.GetById;

public class GetByIdParentFeatureResponse : IResponse
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }
}