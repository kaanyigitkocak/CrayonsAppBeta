using Application.Features.Schools.Commands.Create;
using Application.Features.Schools.Commands.Delete;
using Application.Features.Schools.Commands.Update;
using Application.Features.Schools.Queries.GetById;
using Application.Features.Schools.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;

namespace Application.Features.Schools.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<School, CreateSchoolCommand>().ReverseMap();
        CreateMap<School, CreatedSchoolResponse>().ReverseMap();
        CreateMap<School, UpdateSchoolCommand>().ReverseMap();
        CreateMap<School, UpdatedSchoolResponse>().ReverseMap();
        CreateMap<School, DeleteSchoolCommand>().ReverseMap();
        CreateMap<School, DeletedSchoolResponse>().ReverseMap();
        CreateMap<School, GetByIdSchoolResponse>().ReverseMap();
        CreateMap<School, GetListSchoolListItemDto>().ReverseMap();
        CreateMap<IPaginate<School>, GetListResponse<GetListSchoolListItemDto>>().ReverseMap();
    }
}