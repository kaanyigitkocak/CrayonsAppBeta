using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Application.Services.FileStorageService;
public interface IFileStorage
{
    Task<string> Upload(IFormFile file);
    Task<IActionResult> Download(string fullPath);
    Task<string> Update(string fullPath, IFormFile newFile);
    Task<string> Delete(string fullPath);
}
