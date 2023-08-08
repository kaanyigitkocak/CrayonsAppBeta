using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ISchoolRepository : IAsyncRepository<School, int>, IRepository<School, int>
{
}