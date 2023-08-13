using Application.Features.Files.Commands.Create;
using Application.Features.Files.Commands.Delete;
using Application.Features.Files.Commands.Update;
using Application.Features.Files.Queries.GetById;
using Application.Features.Files.Queries.GetList;
using Application.Services.FileStorageService;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.FileStorage.Local;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilesController : BaseController
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FilesController(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }
    [HttpPost]
    public async Task<IActionResult> Add(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return new BadRequestResult();
        }

        var uploadsPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
        Directory.CreateDirectory(uploadsPath);

        var uniqueFileName = Guid.NewGuid().ToString() + GetSubstringFile(file.FileName);
        var filePath = Path.Combine(uploadsPath, uniqueFileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return new OkObjectResult(uniqueFileName);

    }
    [HttpGet("download/{fileName}")]
    public IActionResult DownloadFile(string fileName)
    {
        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fileName);

        if (!System.IO.File.Exists(filePath))
        {
            return new NotFoundResult();
        }

        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        return new FileStreamResult(fileStream, "image/jpeg");

    }
    [HttpPut]
    public async Task<IActionResult> Update(string fullPath, IFormFile newFile)
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(string fullPath)
    {
        var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", fullPath);

        if (!System.IO.File.Exists(filePath))
        {
            return new NotFoundResult();
        }

        // Delete the file
        System.IO.File.Delete(filePath);

        return new OkResult();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        GetByIdFileResponse response = await Mediator.Send(new GetByIdFileQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFileQuery getListFileQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListFileListItemDto> response = await Mediator.Send(getListFileQuery);
        return Ok(response);
    }
    private string GetSubstringFile(string input)
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