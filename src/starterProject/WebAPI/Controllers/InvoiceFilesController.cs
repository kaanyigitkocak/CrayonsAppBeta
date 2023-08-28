using Application.Features.InvoiceFiles.Commands.Create;
using Application.Features.InvoiceFiles.Commands.Delete;
using Application.Features.InvoiceFiles.Commands.Update;
using Application.Features.InvoiceFiles.Commands.GeneratePdf;
using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Queries.GetById;
using Application.Features.InvoiceFiles.Commands.Create;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Invoices.Commands.Delete;
using Application.Features.Invoices.Commands.Update;
using Application.Features.Invoices.Queries.GetById;
using Application.Features.Invoices.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.IO.Image;
using Microsoft.AspNetCore.Hosting;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using Infrastructure.PdfGenerator;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InvoiceFilesController : BaseController

{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public InvoiceFilesController(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    [HttpPost]
    public async Task<IActionResult> Add(IFormFile formFile, int invoiceId)
    {
        CreateInvoiceFileCommand command = new CreateInvoiceFileCommand()
        { FormFile = formFile, InvoiceId = invoiceId };
        CreatedInvoiceFileResponse response = await Mediator.Send(command);

        return Created(uri: "", response);
    }
    [HttpPut]
    public async Task<IActionResult> Update(IFormFile formFile, int id)
    {
        UpdatedInvoiceFileResponse response = await Mediator.Send(new UpdateInvoiceFileCommand() { FormFile = formFile, Id = id });

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
        FileDownloadDto response = await Mediator.Send(new GetByIdInvoiceFileQuery { Id = id });
        return File(response.MsArray, response.ContentType, response.FileName);
    }
   
    [HttpPost("generatepdf2")]
    public async Task<IActionResult> GeneratePDF2(int InvoiceNo)
    {
        GeneratePdfResponse response = await Mediator.Send(new GeneratePdfCommand {invoiceId=InvoiceNo });
        return File(response.Ms,response.ContentType,response.PdfName);
    }
}
