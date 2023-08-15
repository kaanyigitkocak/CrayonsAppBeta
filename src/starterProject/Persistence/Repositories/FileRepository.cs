using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Persistence.Contexts;
using File = Domain.Entities.File;

namespace Persistence.Repositories;

public partial class FileRepository : EfRepositoryBase<File, int, BaseDbContext>, IFileRepository
{
    public FileRepository(BaseDbContext context) : base(context)
    {
    }
}