using Application.Features.ParentFeatures.Commands.Create;
using Application.Features.ParentFeatures.Commands.Delete;
using Application.Features.ParentFeatures.Commands.Update;
using Application.Features.ParentFeatures.Queries.GetById;
using Application.Features.ParentFeatures.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.ParentFeatures.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<ParentFeature, CreateParentFeatureCommand>().ReverseMap();
        CreateMap<ParentFeature, CreatedParentFeatureResponse>().ReverseMap();
        CreateMap<ParentFeature, UpdateParentFeatureCommand>().ReverseMap();
        CreateMap<ParentFeature, UpdatedParentFeatureResponse>().ReverseMap();
        CreateMap<ParentFeature, DeleteParentFeatureCommand>().ReverseMap();
        CreateMap<ParentFeature, DeletedParentFeatureResponse>().ReverseMap();
        CreateMap<ParentFeature, GetByIdParentFeatureResponse>().ReverseMap();
        CreateMap<ParentFeature, GetListParentFeatureListItemDto>().ReverseMap();
        CreateMap<IPaginate<ParentFeature>, GetListResponse<GetListParentFeatureListItemDto>>().ReverseMap();
    }
}