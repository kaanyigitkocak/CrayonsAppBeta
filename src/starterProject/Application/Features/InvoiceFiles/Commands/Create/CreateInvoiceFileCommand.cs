using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Extensions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using File = Domain.Entities.File;

namespace Application.Features.InvoiceFiles.Commands.Create;

public class CreateInvoiceFileCommand : IRequest<CreatedInvoiceFileResponse>
{
    public int InvoiceId { get; set; }
    public IFormFile FormFile { get; set; }

    public class CreateInvoiceFileCommandHandler : IRequestHandler<CreateInvoiceFileCommand, CreatedInvoiceFileResponse>
    {
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _fileRepository;
        private readonly InvoiceFileBusinessRules _fileBusinessRules;

        public CreateInvoiceFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository fileRepository, InvoiceFileBusinessRules fileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<CreatedInvoiceFileResponse> Handle(CreateInvoiceFileCommand request, CancellationToken cancellationToken)
        {
            InvoiceFile invoiceFile = new() { InvoiceId = request.InvoiceId };

            FileUploadDto fileUploadDto = await _fileStorage.Upload(request.FormFile, invoiceFile);

            invoiceFile.FullPath = fileUploadDto.FullPath;
            invoiceFile.Name = fileUploadDto.Name;
            invoiceFile.MimeType = fileUploadDto.MimeType;

            InvoiceFile response = await _fileRepository.AddAsync(invoiceFile);

            CreatedInvoiceFileResponse  createdInvoiceFileResponse = _mapper.Map<CreatedInvoiceFileResponse>(response);
            return createdInvoiceFileResponse;
        }
    }
}