using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ParentRepository : EfRepositoryBase<Parent, int, BaseDbContext>, IParentRepository
{
    public ParentRepository(BaseDbContext context)
        : base(context) { }
}
