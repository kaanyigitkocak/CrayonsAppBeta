using Application.Features.Files.Rules;
using Application.Features.InvoiceFiles.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Extensions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using File = Domain.Entities.File;

namespace Application.Features.InvoiceFiles.Commands.Update;

public class UpdateInvoiceFileCommand : IRequest<UpdatedInvoiceFileResponse>
{
    public IFormFile FormFile { get; set; }
    public int Id { get; set; }

    public class UpdateInvoiceFileCommandHandler : IRequestHandler<UpdateInvoiceFileCommand, UpdatedInvoiceFileResponse>
    {

        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _invoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public UpdateInvoiceFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository invoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _invoiceFileRepository = invoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<UpdatedInvoiceFileResponse> Handle(UpdateInvoiceFileCommand request, CancellationToken cancellationToken)
        {
            InvoiceFile file = await _invoiceFileRepository.GetAsync(x => x.Id == request.Id);
            
            await _fileStorage.Update(file, request.FormFile);
            await _invoiceFileRepository.UpdateAsync(file);
            return new UpdatedInvoiceFileResponse() {Id = request.Id };

        }
    }
}