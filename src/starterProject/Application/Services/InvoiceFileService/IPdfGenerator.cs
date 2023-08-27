using Application.Features.InvoiceFiles.Commands.GeneratePdf;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.InvoiceFileService;
public interface IPdfGenerator
{
    public PdfDto PdfGenerator();
}
