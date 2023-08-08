using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Features.ParentFeatures.Queries.GetList;

public class GetListParentFeatureQuery : IRequest<GetListResponse<GetListParentFeatureListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListParentFeatureQueryHandler : IRequestHandler<GetListParentFeatureQuery, GetListResponse<GetListParentFeatureListItemDto>>
    {
        private readonly IParentFeatureRepository _parentFeatureRepository;
        private readonly IMapper _mapper;

        public GetListParentFeatureQueryHandler(IParentFeatureRepository parentFeatureRepository, IMapper mapper)
        {
            _parentFeatureRepository = parentFeatureRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListParentFeatureListItemDto>> Handle(GetListParentFeatureQuery request, CancellationToken cancellationToken)
        {
            IPaginate<ParentFeature> parentFeatures = await _parentFeatureRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListParentFeatureListItemDto> response = _mapper.Map<GetListResponse<GetListParentFeatureListItemDto>>(parentFeatures);
            return response;
        }
    }
}