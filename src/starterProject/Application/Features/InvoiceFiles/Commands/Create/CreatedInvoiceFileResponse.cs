using Core.Application.Responses;
using Domain.Entities;

namespace Application.Features.InvoiceFiles.Commands.Create;

public class CreatedInvoiceFileResponse : IResponse
{
    public Invoice Invoice { get; set; }
}