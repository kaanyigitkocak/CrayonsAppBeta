using Application.Features.Parents.Commands.Delete;
using Application.Features.Parents.Commands.Update;
using Application.Features.Parents.Dtos;
using Application.Features.Parents.Queries.GetById;
using Application.Features.Parents.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<Parent, CreateParentCommand>().ReverseMap();
        CreateMap<Parent, CreatedParentResponse>().ReverseMap();
        CreateMap<Parent, UpdateParentCommand> ().ReverseMap();
        CreateMap<Parent, UpdatedParentResponse>().ReverseMap();
        CreateMap<Parent, DeleteParentCommand>().ReverseMap();
        CreateMap<Parent, DeletedParentResponse>().ReverseMap();
        CreateMap<Parent, GetByIdParentResponse>().ReverseMap()
            .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.Students));
        CreateMap<Parent, GetListParentListItemDto>();
        CreateMap<IPaginate<Parent>, GetListResponse<GetListParentListItemDto>>().ReverseMap();

    }
}

