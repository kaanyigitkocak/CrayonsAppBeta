using Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ParentService;
public interface IParentService
{
    Task<Parent?> GetAsync(
        Expression<Func<Parent, bool>> predicate,
        Func<IQueryable<Parent>, IIncludableQueryable<Parent, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<IPaginate<Parent>?> GetListAsync(
        Expression<Func<Parent, bool>>? predicate = null,
        Func<IQueryable<Parent>, IOrderedQueryable<Parent>>? orderBy = null,
        Func<IQueryable<Parent>, IIncludableQueryable<Parent, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

    Task<Parent> AddAsync(Parent parent);
    Task<Parent> UpdateAsync(Parent parent);
    Task<Parent> DeleteAsync(Parent parent, bool permanent = false);
}
