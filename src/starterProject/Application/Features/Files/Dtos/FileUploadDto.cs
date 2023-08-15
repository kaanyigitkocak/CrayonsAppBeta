using Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Files.Dtos;
public class FileUploadDto : IDto
{
    public FileUploadDto(string fullPath, string name, string mimeType)
    {
        FullPath = fullPath;
        Name = name;
        MimeType = mimeType;
    }

    public string FullPath { get; set; }
    public string Name { get; set; }
    public  string MimeType  { get; set; }
}