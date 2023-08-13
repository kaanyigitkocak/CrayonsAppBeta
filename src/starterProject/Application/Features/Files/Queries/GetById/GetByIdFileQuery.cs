using Application.Features.Files.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Application.Features.Files.Queries.GetById;

public class GetByIdFileQuery : IRequest<IActionResult>
{
    public string FullPath { get; set; }

    public class GetByIdFileQueryHandler : IRequestHandler<GetByIdFileQuery, IActionResult>
    {
        private readonly IFileStorage _fileStorage;
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public GetByIdFileQueryHandler(IFileStorage fileStorage, IMapper mapper, IFileRepository fileRepository, FileBusinessRules fileBusinessRules)
        {
            _fileStorage = fileStorage;
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<IActionResult> Handle(GetByIdFileQuery request, CancellationToken cancellationToken)
        {
            File? file = await _fileRepository.GetAsync(predicate: f => f.FullPath == request.FullPath, cancellationToken: cancellationToken);
            IActionResult fileResult = await _fileStorage.Download(request.FullPath);

            return fileResult;
        }
    }
}