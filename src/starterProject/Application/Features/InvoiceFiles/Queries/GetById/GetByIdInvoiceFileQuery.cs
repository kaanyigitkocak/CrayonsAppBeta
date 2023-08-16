using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Modes;
using File = Domain.Entities.File;

namespace Application.Features.InvoiceFiles.Queries.GetById;

public class GetByIdInvoiceFileQuery : IRequest<FileDownloadDto>
{
    public int Id { get; set; }

    public class GetByIdInvoiceFileQueryHandler : IRequestHandler<GetByIdInvoiceFileQuery, FileDownloadDto>
    {
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _invoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public GetByIdInvoiceFileQueryHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository invoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _invoiceFileRepository = invoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<FileDownloadDto> Handle(GetByIdInvoiceFileQuery request, CancellationToken cancellationToken)
        {
            InvoiceFile file = await _invoiceFileRepository.GetAsync(x => x.Id == request.Id);
            FileDownloadDto fileDownload = _fileStorage.Download(file);
            return fileDownload;
        }
    }
}

   
