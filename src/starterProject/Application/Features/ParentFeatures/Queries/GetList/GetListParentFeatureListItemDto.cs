using Core.Application.Dtos;

namespace Application.Features.ParentFeatures.Queries.GetList;

public class GetListParentFeatureListItemDto : IDto
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }
}