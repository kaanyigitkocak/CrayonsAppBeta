using Core.Application.Responses;

namespace Application.Features.InvoiceFiles.Commands.Delete;

public class DeletedInvoiceFileResponse : IResponse
{
    public int Id { get; set; }
}