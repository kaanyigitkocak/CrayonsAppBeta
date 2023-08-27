using Core.Application.Responses;

namespace Application.Features.InvoiceFiles.Commands.GeneratePdf;

public class GeneratePdfResponse : IResponse
{
    public byte[] Ms { get; set; }
    public string ContentType { get; set; }
    public string PdfName { get; set; }
}