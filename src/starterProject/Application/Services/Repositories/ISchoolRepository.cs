using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ISchoolRepository : IAsyncRepository<School, int>, IRepository<School, int> { }
