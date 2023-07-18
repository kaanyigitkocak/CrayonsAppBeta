using Application.Features.Parents.Commands.Delete;
using Application.Features.Parents.Commands.Update;
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
        CreateMap<Parent, CreateParentCommand>().ReverseMap();
        CreateMap<Parent, CreatedParentResponse>().ReverseMap();
        CreateMap<Parent, UpdateParentCommand>().ReverseMap();
        CreateMap<Parent, UpdatedParentResponse>().ReverseMap();
        CreateMap<Parent, DeleteParentCommand>().ReverseMap();
        CreateMap<Parent, DeletedParentResponse>().ReverseMap();
        CreateMap<Parent, GetByIdParentResponse>().ReverseMap();
        CreateMap<Parent, GetListParentListItemDto>().ReverseMap();
        CreateMap<IPaginate<Parent>, GetListResponse<GetListParentListItemDto>>().ReverseMap();
    }
}

