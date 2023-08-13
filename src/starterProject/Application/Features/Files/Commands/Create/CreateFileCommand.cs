using Application.Features.Files.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

using File = Domain.Entities.File;
namespace Application.Features.Files.Commands.Create;

public class CreateFileCommand : IRequest<CreatedFileResponse>
{
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }

    public class CreateFileCommandHandler : IRequestHandler<CreateFileCommand, CreatedFileResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public CreateFileCommandHandler(IMapper mapper, IFileRepository fileRepository,
                                         FileBusinessRules fileBusinessRules)
        {
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<CreatedFileResponse> Handle(CreateFileCommand request, CancellationToken cancellationToken)
        {
            File file = _mapper.Map<File>(request);
            await _fileRepository.AddAsync(file);

            CreatedFileResponse response = _mapper.Map<CreatedFileResponse>(file);
            return response;
        }
    }
}