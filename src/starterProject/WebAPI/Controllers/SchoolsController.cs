using Application.Features.Schools.Commands.Create;
using Application.Features.Schools.Commands.Delete;
using Application.Features.Schools.Commands.Update;
using Application.Features.Schools.Queries.GetById;
using Application.Features.Schools.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SchoolsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSchoolCommand createSchoolCommand)
    {
        CreatedSchoolResponse response = await Mediator.Send(createSchoolCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSchoolCommand updateSchoolCommand)
    {
        UpdatedSchoolResponse response = await Mediator.Send(updateSchoolCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeletedSchoolResponse response = await Mediator.Send(new DeleteSchoolCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        GetByIdSchoolResponse response = await Mediator.Send(new GetByIdSchoolQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSchoolQuery getListSchoolQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListSchoolListItemDto> response = await Mediator.Send(getListSchoolQuery);
        return Ok(response);
    }
}