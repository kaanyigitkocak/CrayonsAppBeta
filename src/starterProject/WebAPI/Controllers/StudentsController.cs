using Application.Features.Students.Commands.Create;
using Application.Features.Students.Commands.Delete;
using Application.Features.Students.Commands.Update;
using Application.Features.Students.Queries.GetById;
using Application.Features.Students.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdStudentQuery getByIdStudentQuery)
    {
        GetByIdStudentResponse result = await Mediator.Send(getByIdStudentQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListStudentQuery getListStudentQuery = new(pageRequest);
        GetListResponse<GetListStudentListItemResponse> result = await Mediator.Send(getListStudentQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStudentCommand createStudentCommand)
    {
        CreatedStudentResponse result = await Mediator.Send(createStudentCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStudentCommand updateStudentCommand)
    {
        UpdatedStudentResponse result = await Mediator.Send(updateStudentCommand);
        return Ok(result);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(int id)
    {
        DeleteStudentCommand deleteStudentCommand = new(id);
        DeletedStudentResponse result = await Mediator.Send(deleteStudentCommand);
        return Ok(result);
    }
}