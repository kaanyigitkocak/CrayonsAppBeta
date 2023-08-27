using Application.Features.Files.Commands.Create;
using Application.Features.Files.Commands.Delete;
using Application.Features.Files.Commands.Update;
using Application.Features.Files.Dtos;
using Application.Features.Files.Queries.GetById;
using Application.Features.Files.Queries.GetList;
using Application.Features.Files.Commands.Update;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.CrossCuttingConcerns.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Nest;

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
    public async Task<IActionResult> Add( IFormFile formFile)
    { 
        CreateFileCommand createFileCommand = new ()
        {
            FormFile = formFile
        };
        CreatedFileResponse response = await Mediator.Send(createFileCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update( IFormFile formFile,string fullPath)
    {
        UpdateFileCommand updateFileCommand = new() { FullPath = fullPath, File = formFile };
        UpdatedFileResponse response = await Mediator.Send(updateFileCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeletedFileResponse response = await Mediator.Send(new DeleteFileCommand { Id = id });

        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetById(string fullPath)
    {

        FileDownloadDto response = await Mediator.Send(new GetByIdFileQuery { FullPath = fullPath });

        return File(response.MsArray, response.ContentType, response.FileName);
    }

  
}