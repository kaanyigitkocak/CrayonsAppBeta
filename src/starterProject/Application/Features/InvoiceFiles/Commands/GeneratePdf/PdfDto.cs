using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.InvoiceFiles.Commands.GeneratePdf;
public class PdfDto
{
    public IFormFile File { get; set; }
    public byte[] MsArray { get; set; }
    public string ContentType { get; set; }
    public string PdfName { get; set; }
}
