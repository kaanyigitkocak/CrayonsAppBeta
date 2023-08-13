using Application.Features.Files.Constants;
using Application.Features.Files.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

using File = Domain.Entities.File;

namespace Application.Features.Files.Commands.Delete;

public class DeleteFileCommand : IRequest<DeletedFileResponse>
{
    public int Id { get; set; }

    public class DeleteFileCommandHandler : IRequestHandler<DeleteFileCommand, DeletedFileResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public DeleteFileCommandHandler(IMapper mapper, IFileRepository fileRepository,
                                         FileBusinessRules fileBusinessRules)
        {
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<DeletedFileResponse> Handle(DeleteFileCommand request, CancellationToken cancellationToken)
        {
            File? file = await _fileRepository.GetAsync(predicate: f => f.Id == request.Id, cancellationToken: cancellationToken);
            await _fileBusinessRules.FileShouldExistWhenSelected(file);

            await _fileRepository.DeleteAsync(file!);

            DeletedFileResponse response = _mapper.Map<DeletedFileResponse>(file);
            return response;
        }
    }
}