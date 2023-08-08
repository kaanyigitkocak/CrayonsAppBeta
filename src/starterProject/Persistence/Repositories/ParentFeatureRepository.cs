using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ParentFeatureRepository : EfRepositoryBase<ParentFeature, int, BaseDbContext>, IParentFeatureRepository
{
    public ParentFeatureRepository(BaseDbContext context) : base(context)
    {
    }
}