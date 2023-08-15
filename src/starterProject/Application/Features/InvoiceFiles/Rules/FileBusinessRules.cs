
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using File = Domain.Entities.File;

namespace Application.Features.InvoiceFiles.Rules;

public class InvoiceFileBusinessRules : BaseBusinessRules
{
    private readonly IInvoiceFileRepository _invoiceFileRepository;

    public InvoiceFileBusinessRules(IInvoiceFileRepository invoiceFileRepository)
    {
        _invoiceFileRepository = invoiceFileRepository;
    }

}