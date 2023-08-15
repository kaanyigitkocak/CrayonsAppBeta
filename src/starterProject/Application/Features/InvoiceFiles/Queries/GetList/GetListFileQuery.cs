using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using File = Domain.Entities.File;

namespace Application.Features.InvoiceFiles.Queries.GetList;

public class GetListInvoiceFileQuery : IRequest<GetListResponse<GetListInvoiceFileListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListFileQueryHandler : IRequestHandler<GetListInvoiceFileQuery, GetListResponse<GetListInvoiceFileListItemDto>>
    {
        private readonly IInvoiceFileRepository _invoiceFileRepository;
        private readonly IMapper _mapper;

        public GetListFileQueryHandler(IInvoiceFileRepository invoiceFileRepository, IMapper mapper)
        {
            _invoiceFileRepository = invoiceFileRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListInvoiceFileListItemDto>> Handle(GetListInvoiceFileQuery request, CancellationToken cancellationToken)
        {
         throw new NotImplementedException();

        }
    }
}