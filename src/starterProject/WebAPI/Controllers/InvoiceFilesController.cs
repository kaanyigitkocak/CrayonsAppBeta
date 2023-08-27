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
    [HttpGet("generatepdf")]
    public IActionResult GeneratePDF(string InvoiceNo)
    {

        using (MemoryStream ms = new MemoryStream())
        {
            PdfWriter writer = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("ORDER DETAIL").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            document.Add(header);

            Paragraph subheader = new Paragraph("PDF CREATED USING ASP.NET C# WITH iTExT7 LIBRARY").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);
            document.Add(subheader);

            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            Paragraph sellerHeader = new Paragraph("Sold by:").SetBold().SetTextAlignment(TextAlignment.LEFT);
            Paragraph sellerDetail = new Paragraph("Seller Company").SetTextAlignment(TextAlignment.LEFT);
            Paragraph sellerAddress = new Paragraph("Mumbai, Maharashtra India").SetTextAlignment(TextAlignment.LEFT);
            Paragraph sellerContact = new Paragraph("+91 1000000000").SetTextAlignment(TextAlignment.LEFT);

            document.Add(sellerHeader);
            document.Add(sellerDetail);
            document.Add(sellerAddress);
            document.Add(sellerContact);

            Paragraph customerHeader = new Paragraph("Customer details:").SetBold().SetTextAlignment(TextAlignment.RIGHT);
            Paragraph customerDetail = new Paragraph("Customer ABC").SetTextAlignment(TextAlignment.RIGHT);
            Paragraph customerAddress1 = new Paragraph("R783, Rose Apartments, Santacruz (E)").SetTextAlignment(TextAlignment.RIGHT);
            Paragraph customerAddress2 = new Paragraph("Mumbai 400054, Maharashtra India").SetTextAlignment(TextAlignment.RIGHT);

            Paragraph customerContact = new Paragraph("+91 0000000000").SetTextAlignment(TextAlignment.RIGHT);

            document.Add(customerHeader);
            document.Add(customerDetail);
            document.Add(customerAddress1);
            document.Add(customerAddress2);
            document.Add(customerContact);

            Paragraph orderNo = new Paragraph("Order No:15484659").SetBold().SetTextAlignment(TextAlignment.LEFT);
            Paragraph invoiceNo = new Paragraph("Invoice No:MH-MU-1077").SetTextAlignment(TextAlignment.LEFT);
            Paragraph invoiceTimestamp = new Paragraph("Date: 30/05/2021 04:25:37 PM").SetTextAlignment(TextAlignment.LEFT);

            document.Add(orderNo);
            document.Add(invoiceNo);
            document.Add(invoiceTimestamp);

            Table table = new Table(5, true);

            table.SetFontSize(9);
            Cell headerProductId = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Code"));
            Cell headerProduct = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Product"));
            Cell headerProductPrice = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Price"));
            Cell headerProductQty = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Qty"));
            Cell headerTotal = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph("Total"));

            table.AddCell(headerProductId);
            table.AddCell(headerProduct);
            table.AddCell(headerProductPrice);
            table.AddCell(headerProductQty);
            table.AddCell(headerTotal);

            double grandTotalVal = 0;


            Cell grandTotalHeader = new Cell(1, 4).SetTextAlignment(TextAlignment.RIGHT).Add(new Paragraph("Total: "));
            Cell grandTotal = new Cell(1, 1).SetTextAlignment(TextAlignment.LEFT).Add(new Paragraph(" " + grandTotalVal.ToString()));

            table.AddCell(grandTotalHeader);
            table.AddCell(grandTotal);
            document.Add(table);

            string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "1676653124767.jpeg");



            Image img = new Image(ImageDataFactory.Create(imagePath));
            img.SetAutoScale(true);
            img.ScaleToFit(150f, 150f);
            img.SetFixedPosition(pdf.GetLastPage().GetPageSize().GetWidth() - 180f, 40f);
            document.Add(img);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            Paragraph crayonsAppParagraph = new Paragraph("CrayonsApp").SetFont(font).SetFontSize(10);
            crayonsAppParagraph.SetFixedPosition(pdf.GetLastPage().GetPageSize().GetWidth() - 152f, 40f, 100f);
            document.Add(crayonsAppParagraph);


            table.Flush();
            table.Complete();
            document.Close();

            return File(ms.ToArray(), "application/pdf", "Invoice.pdf");
        }
    }
    [HttpGet("generatepdf2")]
    public async Task<IActionResult> GeneratePDF2(int InvoiceNo)
    {
        GeneratePdfResponse response = await Mediator.Send(new GeneratePdfCommand {invoiceId=InvoiceNo });
        return File(response.Ms,response.ContentType,response.PdfName);
    }
}
