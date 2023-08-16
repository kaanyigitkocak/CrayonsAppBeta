using Application.Features.Files.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Application.Services.FileStorageService;
public interface IFileStorage
{
    Task<FileUploadDto> Upload(IFormFile file, File fileDb);
    FileDownloadDto Download(File fileDb);
    Task<string> Update(File fileDb, IFormFile newFile);
    string Delete(File fileDb);
}
