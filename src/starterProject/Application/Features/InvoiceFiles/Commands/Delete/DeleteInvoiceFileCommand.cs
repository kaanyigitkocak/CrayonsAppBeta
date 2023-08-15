
using Application.Features.InvoiceFiles.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;


namespace Application.Features.InvoiceFiles.Commands.Delete;

public class DeleteInvoiceFileCommand : IRequest<DeletedInvoiceFileResponse>
{
    public int Id { get; set; }

    public class DeleteInvoiceFileCommandHandler : IRequestHandler<DeleteInvoiceFileCommand, DeletedInvoiceFileResponse>
    {

        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IInvoiceFileRepository _nvoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public DeleteInvoiceFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository nvoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _nvoiceFileRepository = nvoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<DeletedInvoiceFileResponse> Handle(DeleteInvoiceFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}