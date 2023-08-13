using Application.Features.Files.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

using File = Domain.Entities.File;

namespace Application.Features.Files.Queries.GetById;

public class GetByIdFileQuery : IRequest<GetByIdFileResponse>
{
    public int Id { get; set; }

    public class GetByIdFileQueryHandler : IRequestHandler<GetByIdFileQuery, GetByIdFileResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public GetByIdFileQueryHandler(IMapper mapper, IFileRepository fileRepository, FileBusinessRules fileBusinessRules)
        {
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<GetByIdFileResponse> Handle(GetByIdFileQuery request, CancellationToken cancellationToken)
        {
            File? file = await _fileRepository.GetAsync(predicate: f => f.Id == request.Id, cancellationToken: cancellationToken);
            await _fileBusinessRules.FileShouldExistWhenSelected(file);

            GetByIdFileResponse response = _mapper.Map<GetByIdFileResponse>(file);
            return response;
        }
    }
}