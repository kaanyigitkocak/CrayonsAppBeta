using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class StudentRepository : EfRepositoryBase<Student, int, BaseDbContext>, IStudentRepository
{
    public StudentRepository(BaseDbContext context)
        : base(context) { }
}
