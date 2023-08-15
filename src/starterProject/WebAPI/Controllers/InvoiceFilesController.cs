using Application.Features.InvoiceFiles.Commands.Create;
using Application.Features.InvoiceFiles.Commands.Delete;
using Application.Features.InvoiceFiles.Commands.Update;
using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Queries.GetById;
using Application.Features.InvoiceFiles.Commands.Create;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Invoices.Commands.Delete;
using Application.Features.Invoices.Commands.Update;
using Application.Features.Invoices.Queries.GetById;
using Application.Features.Invoices.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InvoiceFilesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add(IFormFile formFile,[FromRoute] int id)
    {
        CreateInvoiceFileCommand command = new CreateInvoiceFileCommand()
        { FormFile = formFile, InvoiceId = id};
        CreatedInvoiceFileResponse response = await Mediator.Send(command);

        return Created(uri: "", response);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateInvoiceFileCommand updateInvoiceCommand)
    {
        UpdatedInvoiceFileResponse response = await Mediator.Send(updateInvoiceCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeletedInvoiceFileResponse response = await Mediator.Send(new DeleteInvoiceFileCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        DeletedInvoiceFileResponse response = await Mediator.Send(new DeleteInvoiceFileCommand { });
        return Ok(response);
    }
}
