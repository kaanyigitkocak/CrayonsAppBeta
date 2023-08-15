using Application.Features.Files.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Extensions;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using File = Domain.Entities.File;

namespace Application.Features.Files.Commands.Update;

public class UpdateFileCommand : IRequest<UpdatedFileResponse>
{
    public string FullPath { get; set; }
    public IFormFile File { get; set; }

    public class UpdateFileCommandHandler : IRequestHandler<UpdateFileCommand, UpdatedFileResponse>
    {

        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

     

        public UpdateFileCommandHandler(IFileStorage fileStorage, IMapper mapper, IFileRepository fileRepository, FileBusinessRules fileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<UpdatedFileResponse> Handle(UpdateFileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}