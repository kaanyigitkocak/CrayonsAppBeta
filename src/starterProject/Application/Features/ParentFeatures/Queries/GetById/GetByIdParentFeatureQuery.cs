using Application.Features.ParentFeatures.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ParentFeatures.Queries.GetById;

public class GetByIdParentFeatureQuery : IRequest<GetByIdParentFeatureResponse>
{
    public int Id { get; set; }

    public class GetByIdParentFeatureQueryHandler : IRequestHandler<GetByIdParentFeatureQuery, GetByIdParentFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IParentFeatureRepository _parentFeatureRepository;
        private readonly ParentFeatureBusinessRules _parentFeatureBusinessRules;

        public GetByIdParentFeatureQueryHandler(IMapper mapper, IParentFeatureRepository parentFeatureRepository, ParentFeatureBusinessRules parentFeatureBusinessRules)
        {
            _mapper = mapper;
            _parentFeatureRepository = parentFeatureRepository;
            _parentFeatureBusinessRules = parentFeatureBusinessRules;
        }

        public async Task<GetByIdParentFeatureResponse> Handle(GetByIdParentFeatureQuery request, CancellationToken cancellationToken)
        {
            ParentFeature? parentFeature = await _parentFeatureRepository.GetAsync(predicate: pf => pf.Id == request.Id, cancellationToken: cancellationToken);
            await _parentFeatureBusinessRules.ParentFeatureShouldExistWhenSelected(parentFeature);

            GetByIdParentFeatureResponse response = _mapper.Map<GetByIdParentFeatureResponse>(parentFeature);
            return response;
        }
    }
}