using System;
using System.IO;
using System.Threading.Tasks;
using Application.Services.FileStorageService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = Domain.Entities.File;

namespace Infrastructure.FileStorage.Local
{
    public class LocalFileStorage : IFileStorage
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LocalFileStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return new BadRequestResult();
            }

            var uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
            Directory.CreateDirectory(uploadsPath);

            var uniqueFileName = Guid.NewGuid().ToString();
            var filePath = Path.Combine(uploadsPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return new OkObjectResult(uniqueFileName);
        }


        public async Task<IActionResult> Download(string fullPath)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!System.IO.File.Exists(fullPath))
            {
                return new NotFoundResult();
            }

            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return new FileStreamResult(fileStream, "image/jpeg");
            }
        }

        public async Task<IActionResult> Update(string fullPath, IFormFile newFile)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!System.IO.File.Exists(filePath))
            {
                return new NotFoundResult();
            }

            System.IO.File.Delete(filePath);

            if (newFile != null && newFile.Length > 0)
            {
                var uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsPath);

                var newFilePath = Path.Combine(uploadsPath, fullPath);

                using (var stream = new FileStream(newFilePath, FileMode.Create))
                {
                    await newFile.CopyToAsync(stream);
                }

                return new OkObjectResult(fullPath);
            }

            return new BadRequestResult(); 
        }

        public async Task<IActionResult> Delete(string fullPath)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!System.IO.File.Exists(filePath))
            {
                return new NotFoundResult();
            }

            System.IO.File.Delete(filePath);

            return new OkResult();
        }
        public string GetSubstringFile(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            int dotIndex = input.IndexOf('.');

            if (dotIndex == -1 || dotIndex == input.Length - 1)
            {
                return string.Empty;
            }

            return input.Substring(dotIndex);
        }

    }
}
