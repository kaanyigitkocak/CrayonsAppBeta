using Application.Features.Files.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

using File = Domain.Entities.File;

namespace Application.Features.Files.Commands.Update;

public class UpdateFileCommand : IRequest<UpdatedFileResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }

    public class UpdateFileCommandHandler : IRequestHandler<UpdateFileCommand, UpdatedFileResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFileRepository _fileRepository;
        private readonly FileBusinessRules _fileBusinessRules;

        public UpdateFileCommandHandler(IMapper mapper, IFileRepository fileRepository,
                                         FileBusinessRules fileBusinessRules)
        {
            _mapper = mapper;
            _fileRepository = fileRepository;
            _fileBusinessRules = fileBusinessRules;
        }

        public async Task<UpdatedFileResponse> Handle(UpdateFileCommand request, CancellationToken cancellationToken)
        {
            File? file = await _fileRepository.GetAsync(predicate: f => f.Id == request.Id, cancellationToken: cancellationToken);
            await _fileBusinessRules.FileShouldExistWhenSelected(file);
            file = _mapper.Map(request, file);

            await _fileRepository.UpdateAsync(file!);

            UpdatedFileResponse response = _mapper.Map<UpdatedFileResponse>(file);
            return response;
        }
    }
}