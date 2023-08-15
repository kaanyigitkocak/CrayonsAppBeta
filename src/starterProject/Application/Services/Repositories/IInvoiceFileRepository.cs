using Domain.Entities;
using Core.Persistence.Repositories;


namespace Application.Services.Repositories;

public interface IInvoiceFileRepository : IAsyncRepository<InvoiceFile, int>, IRepository<InvoiceFile, int>
{
}