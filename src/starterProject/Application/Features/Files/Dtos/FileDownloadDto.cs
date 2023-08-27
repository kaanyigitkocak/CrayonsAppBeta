using Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Files.Dtos;
public class FileDownloadDto : IDto
{
    public byte[] MsArray { get; set; }
    public string ContentType { get; set; }
    public string FileName { get; set; }
}
