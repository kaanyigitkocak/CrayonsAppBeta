using Application.Features.ParentFeatures.Constants;
using Application.Features.ParentFeatures.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ParentFeatures.Commands.Delete;

public class DeleteParentFeatureCommand : IRequest<DeletedParentFeatureResponse>
{
    public int Id { get; set; }

    public class DeleteParentFeatureCommandHandler : IRequestHandler<DeleteParentFeatureCommand, DeletedParentFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IParentFeatureRepository _parentFeatureRepository;
        private readonly ParentFeatureBusinessRules _parentFeatureBusinessRules;

        public DeleteParentFeatureCommandHandler(IMapper mapper, IParentFeatureRepository parentFeatureRepository,
                                         ParentFeatureBusinessRules parentFeatureBusinessRules)
        {
            _mapper = mapper;
            _parentFeatureRepository = parentFeatureRepository;
            _parentFeatureBusinessRules = parentFeatureBusinessRules;
        }

        public async Task<DeletedParentFeatureResponse> Handle(DeleteParentFeatureCommand request, CancellationToken cancellationToken)
        {
            ParentFeature? parentFeature = await _parentFeatureRepository.GetAsync(predicate: pf => pf.Id == request.Id, cancellationToken: cancellationToken);
            await _parentFeatureBusinessRules.ParentFeatureShouldExistWhenSelected(parentFeature);

            await _parentFeatureRepository.DeleteAsync(parentFeature!);

            DeletedParentFeatureResponse response = _mapper.Map<DeletedParentFeatureResponse>(parentFeature);
            return response;
        }
    }
}