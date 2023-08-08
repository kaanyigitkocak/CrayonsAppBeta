using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.ParentFeatures;

public interface IParentFeaturesService
{
    Task<ParentFeature?> GetAsync(
        Expression<Func<ParentFeature, bool>> predicate,
        Func<IQueryable<ParentFeature>, IIncludableQueryable<ParentFeature, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<ParentFeature>?> GetListAsync(
        Expression<Func<ParentFeature, bool>>? predicate = null,
        Func<IQueryable<ParentFeature>, IOrderedQueryable<ParentFeature>>? orderBy = null,
        Func<IQueryable<ParentFeature>, IIncludableQueryable<ParentFeature, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<ParentFeature> AddAsync(ParentFeature parentFeature);
    Task<ParentFeature> UpdateAsync(ParentFeature parentFeature);
    Task<ParentFeature> DeleteAsync(ParentFeature parentFeature, bool permanent = false);
}
