
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
        private readonly IInvoiceFileRepository _invoiceFileRepository;
        private readonly InvoiceFileBusinessRules _invoiceFileBusinessRules;

        public DeleteInvoiceFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IInvoiceFileRepository invoiceFileRepository, InvoiceFileBusinessRules invoiceFileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _invoiceFileRepository = invoiceFileRepository;
            _invoiceFileBusinessRules = invoiceFileBusinessRules;
        }

        public async Task<DeletedInvoiceFileResponse> Handle(DeleteInvoiceFileCommand request, CancellationToken cancellationToken)
        {

            InvoiceFile deleteFile = await _invoiceFileRepository.GetAsync( x => x.Id == request.Id);
            await _invoiceFileRepository.DeleteAsync(deleteFile);
            _fileStorage.Delete(deleteFile);
            return new DeletedInvoiceFileResponse() { Id = request.Id };
        }
    }
}