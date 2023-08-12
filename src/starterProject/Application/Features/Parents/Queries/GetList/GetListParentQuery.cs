using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Performance;
using Core.Application.Pipelines.Timeout;
using Core.Application.Pipelines.Transaction;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Queries.GetList;
public class GetListParentQuery : IRequest<GetListResponse<GetListParentListItemDto>>, ITimeoutRequest, IIntervalRequest, ITransactionalRequest
{
    public PageRequest PageRequest { get; set; }

    public TimeSpan TimeoutTime => TimeSpan.FromMilliseconds(3000);

    public TimeSpan Interval => TimeSpan.FromMilliseconds(3000);

    public GetListParentQuery()
    {
        PageRequest = new PageRequest { PageIndex = 0, PageSize = 10 };
    }

    public GetListParentQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest.PageSize == 0 && pageRequest.PageIndex == 0
        ? new PageRequest { PageIndex = 0, PageSize = 10 }
        :  pageRequest;
        
    }

    public class GetListParentQueryHandler : IRequestHandler<GetListParentQuery, GetListResponse<GetListParentListItemDto>>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;

        public GetListParentQueryHandler(IParentRepository parentRepository, IMapper mapper)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListParentListItemDto>> Handle(GetListParentQuery request, CancellationToken cancellationToken)
        {
            await Task.Delay(3001);
            IPaginate<Parent> parents = await _parentRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                include : p => p.Include(p => p.Students),
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListParentListItemDto> response = _mapper.Map<GetListResponse<GetListParentListItemDto>>(parents);
            return response;
        }
    }
}
