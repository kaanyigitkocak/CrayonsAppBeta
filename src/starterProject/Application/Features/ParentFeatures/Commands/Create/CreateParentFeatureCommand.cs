using Application.Features.ParentFeatures.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Transaction;
using Domain.Entities;
using MediatR;

namespace Application.Features.ParentFeatures.Commands.Create;

public class CreateParentFeatureCommand : IRequest<CreatedParentFeatureResponse>,ITransactionalRequest
{
    public string FeatureName { get; set; }
    public int ParentId { get; set; }

    public class CreateParentFeatureCommandHandler : IRequestHandler<CreateParentFeatureCommand, CreatedParentFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IParentFeatureRepository _parentFeatureRepository;
        private readonly ParentFeatureBusinessRules _parentFeatureBusinessRules;

        public CreateParentFeatureCommandHandler(IMapper mapper, IParentFeatureRepository parentFeatureRepository,
                                         ParentFeatureBusinessRules parentFeatureBusinessRules)
        {
            _mapper = mapper;
            _parentFeatureRepository = parentFeatureRepository;
            _parentFeatureBusinessRules = parentFeatureBusinessRules;
        }

        public async Task<CreatedParentFeatureResponse> Handle(CreateParentFeatureCommand request, CancellationToken cancellationToken)
        {
            ParentFeature parentFeature = _mapper.Map<ParentFeature>(request);
            
            //payment db
            //payment api

            await _parentFeatureRepository.AddAsync(parentFeature);
            await _parentFeatureRepository.AddAsync(parentFeature);

            CreatedParentFeatureResponse response = _mapper.Map<CreatedParentFeatureResponse>(parentFeature);
            return response;
        }
    }
}