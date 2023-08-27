using System;
using System.IO;
using System.Threading.Tasks;
using Application.Features.Files.Dtos;
using Application.Features.InvoiceFiles.Commands.GeneratePdf;
using Application.Services.FileStorageService;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.CrossCuttingConcerns.Extensions;
using iText.Forms.Form.Element;
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

        public async Task<FileUploadDto> Upload(IFormFile file, File fileDb)
        {
            if (file == null || file.Length == 0)
            {
                throw new NotImplementedException();
            }

            string uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, fileDb.Discriminator.ToString());
            Directory.CreateDirectory(uploadsPath);

            string mimeType = file.FileName.GetSubstringFile();
            string uniqueFileName = Guid.NewGuid().ToString() + mimeType;
            string filePath = Path.Combine(uploadsPath, uniqueFileName);

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            string returnPath = Path.Combine(fileDb.Discriminator.ToString(),uniqueFileName);
            return new FileUploadDto(returnPath, uniqueFileName,mimeType);
        }


        public FileDownloadDto Download(File fileDb)
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, fileDb.FullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string contentType = MimeTypes.GetMimeType(fileDb.MimeType);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    memoryStream.Seek(0, SeekOrigin.Begin);  // Reset the memory stream position to the beginning

                    return new FileDownloadDto() {  MsArray = memoryStream.ToArray(), ContentType = contentType, FileName = fileDb.Name };
                }
            }

        }

        public async Task<string> Update(File fileDb, IFormFile newFile)
        {
            //string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, fileDb.FullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new NotFoundException("File doesnt exist");                
            }

            FileSys.Delete(filePath);

            if (newFile != null && newFile.Length > 0)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    await newFile.CopyToAsync(stream);
                }

                return fileDb.FullPath;
            }

            throw new NotImplementedException();
        }

        public string Delete(File fileDb)
        {
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, fileDb.FullPath);

            if (!FileSys.Exists(filePath))
            {
                throw new NotFoundException();
            }

            FileSys.Delete(filePath);

            return fileDb.FullPath;
        }
        

    }
}
