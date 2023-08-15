using Application.Features.Files.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Extensions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using File = Domain.Entities.File;

namespace Application.Features.Files.Commands.Create;

public class CreateFileCommand : IRequest<CreatedFileResponse>
{
    public IFormFile FormFile { get; set; }

    public class CreateFileCommandHandler : IRequestHandler<CreateFileCommand, CreatedFileResponse>
    {
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public CreateFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IFileRepository fileRepository, FileBusinessRules fileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<CreatedFileResponse> Handle(CreateFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}