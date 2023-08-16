using Core.Application.Responses;

namespace Application.Features.InvoiceFiles.Commands.Update;

public class UpdatedInvoiceFileResponse : IResponse
{
    public int Id { get; set; }
}