using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class InvoiceFileRepository : EfRepositoryBase<InvoiceFile, int, BaseDbContext>, IInvoiceFileRepository
{
    public InvoiceFileRepository(BaseDbContext context) : base(context)
    {
    }


}