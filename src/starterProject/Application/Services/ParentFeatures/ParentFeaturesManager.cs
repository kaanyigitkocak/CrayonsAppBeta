using Application.Features.ParentFeatures.Rules;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.ParentFeatures;

public class ParentFeaturesManager : IParentFeaturesService
{
    private readonly IParentFeatureRepository _parentFeatureRepository;
    private readonly ParentFeatureBusinessRules _parentFeatureBusinessRules;

    public ParentFeaturesManager(IParentFeatureRepository parentFeatureRepository, ParentFeatureBusinessRules parentFeatureBusinessRules)
    {
        _parentFeatureRepository = parentFeatureRepository;
        _parentFeatureBusinessRules = parentFeatureBusinessRules;
    }

    public async Task<ParentFeature?> GetAsync(
        Expression<Func<ParentFeature, bool>> predicate,
        Func<IQueryable<ParentFeature>, IIncludableQueryable<ParentFeature, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        ParentFeature? parentFeature = await _parentFeatureRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return parentFeature;
    }

    public async Task<IPaginate<ParentFeature>?> GetListAsync(
        Expression<Func<ParentFeature, bool>>? predicate = null,
        Func<IQueryable<ParentFeature>, IOrderedQueryable<ParentFeature>>? orderBy = null,
        Func<IQueryable<ParentFeature>, IIncludableQueryable<ParentFeature, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<ParentFeature> parentFeatureList = await _parentFeatureRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return parentFeatureList;
    }

    public async Task<ParentFeature> AddAsync(ParentFeature parentFeature)
    {
        ParentFeature addedParentFeature = await _parentFeatureRepository.AddAsync(parentFeature);

        return addedParentFeature;
    }

    public async Task<ParentFeature> UpdateAsync(ParentFeature parentFeature)
    {
        ParentFeature updatedParentFeature = await _parentFeatureRepository.UpdateAsync(parentFeature);

        return updatedParentFeature;
    }

    public async Task<ParentFeature> DeleteAsync(ParentFeature parentFeature, bool permanent = false)
    {
        ParentFeature deletedParentFeature = await _parentFeatureRepository.DeleteAsync(parentFeature);

        return deletedParentFeature;
    }
}
