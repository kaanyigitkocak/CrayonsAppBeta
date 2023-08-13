using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using MediatR;
using File = Domain.Entities.File;

namespace Application.Features.Files.Queries.GetList;

public class GetListFileQuery : IRequest<GetListResponse<GetListFileListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListFileQueryHandler : IRequestHandler<GetListFileQuery, GetListResponse<GetListFileListItemDto>>
    {
        private readonly IFileRepository _fileRepository;
        private readonly IMapper _mapper;

        public GetListFileQueryHandler(IFileRepository fileRepository, IMapper mapper)
        {
            _fileRepository = fileRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListFileListItemDto>> Handle(GetListFileQuery request, CancellationToken cancellationToken)
        {
            IPaginate<File> files = await _fileRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListFileListItemDto> response = _mapper.Map<GetListResponse<GetListFileListItemDto>>(files);
            return response;
        }
    }
}