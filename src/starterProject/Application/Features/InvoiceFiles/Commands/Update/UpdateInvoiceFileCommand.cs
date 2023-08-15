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
    

    public class UpdateInvoiceFileCommandHandler : IRequestHandler<UpdateInvoiceFileCommand, UpdatedInvoiceFileResponse>
    {

        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _nvoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public UpdateInvoiceFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository nvoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _nvoiceFileRepository = nvoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<UpdatedInvoiceFileResponse> Handle(UpdateInvoiceFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}