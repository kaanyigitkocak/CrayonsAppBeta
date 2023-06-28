using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class TeacherRepository : EfRepositoryBase<Teacher, int, BaseDbContext>, ITeacherRepository
{
    public TeacherRepository(BaseDbContext context)
        : base(context) { }
}
