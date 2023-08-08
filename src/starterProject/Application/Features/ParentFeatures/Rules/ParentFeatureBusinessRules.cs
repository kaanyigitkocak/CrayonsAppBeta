using Application.Features.ParentFeatures.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.ParentFeatures.Rules;

public class ParentFeatureBusinessRules : BaseBusinessRules
{
    private readonly IParentFeatureRepository _parentFeatureRepository;

    public ParentFeatureBusinessRules(IParentFeatureRepository parentFeatureRepository)
    {
        _parentFeatureRepository = parentFeatureRepository;
    }

    public Task ParentFeatureShouldExistWhenSelected(ParentFeature? parentFeature)
    {
        if (parentFeature == null)
            throw new BusinessException(ParentFeaturesBusinessMessages.ParentFeatureNotExists);
        return Task.CompletedTask;
    }

    public async Task ParentFeatureIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        ParentFeature? parentFeature = await _parentFeatureRepository.GetAsync(
            predicate: pf => pf.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ParentFeatureShouldExistWhenSelected(parentFeature);
    }
}