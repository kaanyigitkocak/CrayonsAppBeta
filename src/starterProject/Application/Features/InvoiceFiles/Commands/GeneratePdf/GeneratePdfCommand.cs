using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Commands.Create;
using Application.Features.InvoiceFiles.Rules;
using Application.Services.FileStorageService;
using Application.Services.InvoiceFileService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.InvoiceFiles.Commands.GeneratePdf;
public class GeneratePdfCommand : IRequest<GeneratePdfResponse>
{
    public int invoiceId { get; set; }

    public class GeneratePdfCommandHandler : IRequestHandler<GeneratePdfCommand, GeneratePdfResponse>
    {
        private readonly IPdfGenerator _pdfGenerator;
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _fileRepository;
        private readonly InvoiceFileBusinessRules _fileBusinessRules;

        public GeneratePdfCommandHandler(IPdfGenerator pdfGenerator, IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository fileRepository, InvoiceFileBusinessRules fileBusinessRules)
        {
            _pdfGenerator = pdfGenerator;
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<GeneratePdfResponse> Handle(GeneratePdfCommand request, CancellationToken cancellationToken)
        {
            InvoiceFile invoiceFile = new() {InvoiceId = request.invoiceId, Discriminator = "InvoiceFile" };
            PdfDto file = await _pdfGenerator.InvoicePdfGenerator(request.invoiceId);
            FileUploadDto fileUploadDto = await _fileStorage.Upload(file.File, invoiceFile);
            invoiceFile.FullPath = fileUploadDto.FullPath;
            invoiceFile.Name = fileUploadDto.Name;
            invoiceFile.MimeType = fileUploadDto.MimeType;
            await _fileRepository.AddAsync(invoiceFile);
            return new() { Ms = file.MsArray, ContentType = file.ContentType, PdfName = fileUploadDto.Name};
        }
    }
}