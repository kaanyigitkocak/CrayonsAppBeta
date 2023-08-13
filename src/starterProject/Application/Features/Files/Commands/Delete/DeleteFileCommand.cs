using Application.Features.Files.Constants;
using Application.Features.Files.Rules;
using Application.Services.FileStorageService;
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

        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public DeleteFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IFileRepository fileRepository, FileBusinessRules fileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<DeletedFileResponse> Handle(DeleteFileCommand request, CancellationToken cancellationToken)
        {
            File? file = await _fileRepository.GetAsync(predicate: f => f.Id == request.Id, cancellationToken: cancellationToken);
            await _fileBusinessRules.FileShouldExistWhenSelected(file);

            await _fileRepository.DeleteAsync(file!);
            await _fileStorage.Delete(file!.FullPath);

            DeletedFileResponse response = _mapper.Map<DeletedFileResponse>(file);
            return response;
        }
    }
}