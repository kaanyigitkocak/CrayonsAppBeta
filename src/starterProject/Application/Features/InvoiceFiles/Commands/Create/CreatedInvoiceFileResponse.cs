using Core.Application.Responses;
using Domain.Entities;

namespace Application.Features.InvoiceFiles.Commands.Create;

public class CreatedInvoiceFileResponse : IResponse
{
    public int Id { get; set; }
    public int InvoiceId { get; set; }
}