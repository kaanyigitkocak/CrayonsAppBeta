using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class InvoiceRepository : EfRepositoryBase<Invoice, int, BaseDbContext>, IInvoiceRepository
{
    public InvoiceRepository(BaseDbContext context) : base(context)
    {
    }
}