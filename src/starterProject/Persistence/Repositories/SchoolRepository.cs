using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class SchoolRepository : EfRepositoryBase<School, int, BaseDbContext>, ISchoolRepository
{
    public SchoolRepository(BaseDbContext context) : base(context)
    {
    }
}