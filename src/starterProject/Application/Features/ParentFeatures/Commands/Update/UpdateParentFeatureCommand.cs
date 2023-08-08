using Application.Features.ParentFeatures.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ParentFeatures.Commands.Update;

public class UpdateParentFeatureCommand : IRequest<UpdatedParentFeatureResponse>
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }
    public Parent Parent { get; set; }

    public class UpdateParentFeatureCommandHandler : IRequestHandler<UpdateParentFeatureCommand, UpdatedParentFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IParentFeatureRepository _parentFeatureRepository;
        private readonly ParentFeatureBusinessRules _parentFeatureBusinessRules;

        public UpdateParentFeatureCommandHandler(IMapper mapper, IParentFeatureRepository parentFeatureRepository,
                                         ParentFeatureBusinessRules parentFeatureBusinessRules)
        {
            _mapper = mapper;
            _parentFeatureRepository = parentFeatureRepository;
            _parentFeatureBusinessRules = parentFeatureBusinessRules;
        }

        public async Task<UpdatedParentFeatureResponse> Handle(UpdateParentFeatureCommand request, CancellationToken cancellationToken)
        {
            ParentFeature? parentFeature = await _parentFeatureRepository.GetAsync(predicate: pf => pf.Id == request.Id, cancellationToken: cancellationToken);
            await _parentFeatureBusinessRules.ParentFeatureShouldExistWhenSelected(parentFeature);
            parentFeature = _mapper.Map(request, parentFeature);

            await _parentFeatureRepository.UpdateAsync(parentFeature!);

            UpdatedParentFeatureResponse response = _mapper.Map<UpdatedParentFeatureResponse>(parentFeature);
            return response;
        }
    }
}