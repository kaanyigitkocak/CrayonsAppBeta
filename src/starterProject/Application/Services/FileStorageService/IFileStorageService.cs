using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Application.Services.FileStorageService;
public interface IFileStorage
{
    Task<IActionResult> Upload(IFormFile file);
    Task<IActionResult> Download(string fullPath);
    Task<IActionResult> Update(string fullPath, IFormFile newFile);
    Task<IActionResult> Delete(string fullPath);
}
