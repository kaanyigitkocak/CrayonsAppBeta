
using Application.Services.ParentService;
using Application.Services.Repositories;
using Core.Persistence.Paging;
using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.UsersService
{
    public class ParentManager : IParentService
    {
        private readonly IParentRepository _parentRepository;

        public ParentManager(IParentRepository parentRepository)
        {
            _parentRepository = parentRepository;
            
        }

        public async Task<Parent?> GetAsync(
            Expression<Func<Parent, bool>> predicate,
            Func<IQueryable<Parent>, IIncludableQueryable<Parent, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        )
        {
            Parent? parent = await _parentRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
            return parent;
        }

        public async Task<IPaginate<Parent>?> GetListAsync(
            Expression<Func<Parent, bool>>? predicate = null,
            Func<IQueryable<Parent>, IOrderedQueryable<Parent>>? orderBy = null,
            Func<IQueryable<Parent>, IIncludableQueryable<Parent, object>>? include = null,
            int index = 0,
            int size = 10,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        )
        {
            IPaginate<Parent> parentList = await _parentRepository.GetListAsync(
                predicate,
                orderBy,
                include,
                index,
                size,
                withDeleted,
                enableTracking,
                cancellationToken
            );
            return parentList;
        }

        public async Task<Parent> AddAsync(Parent parent)
        {

            Parent addedParent = await _parentRepository.AddAsync(parent);

            return addedParent;
        }

        public async Task<Parent> UpdateAsync(Parent parent)
        {

            Parent updatedParent = await _parentRepository.UpdateAsync(parent);

            return updatedParent;
        }

        public async Task<Parent> DeleteAsync(Parent parent, bool permanent = false)
        {
            Parent deletedParent = await _parentRepository.DeleteAsync(parent);

            return deletedParent;
        }
    }
}
