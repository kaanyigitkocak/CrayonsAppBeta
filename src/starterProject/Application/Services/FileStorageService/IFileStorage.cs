using Application.Features.Files.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Application.Services.FileStorageService;
public interface IFileStorage
{
    Task<FileUploadDto> Upload(IFormFile file, File fileDb);
    Task<FileDownloadDto> Download(File fileDb);
    Task<string> Update(File fileDb, IFormFile newFile);
    Task<string> Delete(File fileDb);
}
