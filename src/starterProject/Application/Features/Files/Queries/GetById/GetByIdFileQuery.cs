using Application.Features.Files.Dtos;
using Application.Features.Files.Rules;
using Application.Services.FileStorageService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Modes;
using File = Domain.Entities.File;

namespace Application.Features.Files.Queries.GetById;

public class GetByIdFileQuery : IRequest<FileDownloadDto>
{
    public string FullPath { get; set; }

    public class GetByIdFileQueryHandler : IRequestHandler<GetByIdFileQuery, FileDownloadDto>
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

        public async Task<FileDownloadDto> Handle(GetByIdFileQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}