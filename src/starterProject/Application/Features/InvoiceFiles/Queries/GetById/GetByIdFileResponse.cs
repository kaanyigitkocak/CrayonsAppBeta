using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Application.Features.InvoiceFiles.Queries.GetById;

public class GetByIdInvoiceFileResponse : IResponse
{
    public IActionResult Result { get; set; }
}