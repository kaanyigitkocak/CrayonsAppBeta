using Application.Features.Parents.Commands.Delete;
using Application.Features.Parents.Commands.Update;
using Application.Features.Parents.Queries.GetById;
using Application.Features.Parents.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ParentsController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdParentQuery getByIdParentQuery)
    {
        GetByIdParentResponse result = await Mediator.Send(getByIdParentQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListParentQuery getListParentQuery = new(pageRequest);
        GetListResponse<GetListParentListItemDto> result = await Mediator.Send(getListParentQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateParentCommand createParentCommand)
    {
        CreatedParentResponse result = await Mediator.Send(createParentCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateParentCommand updateParentCommand)
    {
        UpdatedParentResponse result = await Mediator.Send(updateParentCommand);
        return Ok(result);
    }


    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteParentCommand deleteParentCommand)
    {
        DeletedParentResponse result = await Mediator.Send(deleteParentCommand);
        return Ok(result);
    }

}
