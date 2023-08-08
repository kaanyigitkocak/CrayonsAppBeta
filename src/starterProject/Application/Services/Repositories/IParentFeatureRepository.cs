using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IParentFeatureRepository : IAsyncRepository<ParentFeature, int>, IRepository<ParentFeature, int>
{
}