using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class SchoolRepository : EfRepositoryBase<School, int, BaseDbContext>, ISchoolRepository
{
    public SchoolRepository(BaseDbContext context)
        : base(context) { }
}
