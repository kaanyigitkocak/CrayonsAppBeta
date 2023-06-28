using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IParentRepository : IAsyncRepository<Parent, int>, IRepository<Parent, int> { }
