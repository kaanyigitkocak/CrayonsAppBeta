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
    public string FullPath { get; set; }

    public class GetByIdInvoiceFileQueryHandler : IRequestHandler<GetByIdInvoiceFileQuery, FileDownloadDto>
    {
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _nvoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public GetByIdInvoiceFileQueryHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository nvoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _nvoiceFileRepository = nvoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<FileDownloadDto> Handle(GetByIdInvoiceFileQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();

        }
    }
}

   
