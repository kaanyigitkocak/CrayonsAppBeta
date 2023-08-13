using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IInvoiceRepository : IAsyncRepository<Invoice, int>, IRepository<Invoice, int>
{
}