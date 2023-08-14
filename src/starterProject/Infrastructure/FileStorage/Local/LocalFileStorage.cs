using System;
using System.IO;
using System.Threading.Tasks;
using Application.Services.FileStorageService;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.CrossCuttingConcerns.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using File = Domain.Entities.File;
using FileSys = System.IO.File;

namespace Infrastructure.FileStorage.Local
{
    public class LocalFileStorage : IFileStorage
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public LocalFileStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new NotImplementedException();
            }

            string uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
            Directory.CreateDirectory(uploadsPath);

            string uniqueFileName = Guid.NewGuid().ToString()+ file.FileName.GetSubstringFile();
            string filePath = Path.Combine(uploadsPath, uniqueFileName);

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return uniqueFileName;
        }


        public async Task<IActionResult> Download(string fullPath)
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string contentType = MimeTypes.GetMimeType(filePath.GetSubstringFile());

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            
            return new FileStreamResult(fileStream, contentType);
            
        }

        public async Task<string> Update(string fullPath, IFormFile newFile)
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new NotFoundException("File doesnt exist");                
            }

            FileSys.Delete(filePath);

            if (newFile != null && newFile.Length > 0)
            {
                string uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsPath);

                string newFilePath = Path.Combine(uploadsPath, fullPath);

                using (FileStream stream = new FileStream(newFilePath, FileMode.Create))
                {
                    await newFile.CopyToAsync(stream);
                }

                return fullPath;
            }

            throw new NotImplementedException();
        }

        public async Task<string> Delete(string fullPath)
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new NotFoundException();
            }

            FileSys.Delete(filePath);

            return fullPath;
        }
        

    }
}
