using Application.Features.Invoices.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
using Domain.Entities;
using MediatR;

namespace Application.Features.Invoices.Commands.Create;

public class CreateInvoiceCommand : IRequest<CreatedInvoiceResponse>, ICacheRemoverRequest
{
    public string InvoiceNumber { get; set; }
    public string Detail { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public DateTime DueDate { get; set; }
    public int ParentId { get; set; }
    public int FileId { get; set; }

    public bool BypassCache => false;

    public string? CacheKey => $"CreateInvoiceCommand";

    public string? CacheGroupKey => "GetInvoice";

    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, CreatedInvoiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly InvoiceBusinessRules _invoiceBusinessRules;

        public CreateInvoiceCommandHandler(IMapper mapper, IInvoiceRepository invoiceRepository,
                                         InvoiceBusinessRules invoiceBusinessRules)
        {
            _mapper = mapper;
            _invoiceRepository = invoiceRepository;
            _invoiceBusinessRules = invoiceBusinessRules;
        }

        public async Task<CreatedInvoiceResponse> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            Invoice invoice = _mapper.Map<Invoice>(request);

            await _invoiceRepository.AddAsync(invoice);

            CreatedInvoiceResponse response = _mapper.Map<CreatedInvoiceResponse>(invoice);
            return response;
        }
    }
}