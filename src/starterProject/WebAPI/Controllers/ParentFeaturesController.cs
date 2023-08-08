using Application.Features.ParentFeatures.Commands.Create;
using Application.Features.ParentFeatures.Commands.Delete;
using Application.Features.ParentFeatures.Commands.Update;
using Application.Features.ParentFeatures.Queries.GetById;
using Application.Features.ParentFeatures.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParentFeaturesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateParentFeatureCommand createParentFeatureCommand)
    {
        CreatedParentFeatureResponse response = await Mediator.Send(createParentFeatureCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateParentFeatureCommand updateParentFeatureCommand)
    {
        UpdatedParentFeatureResponse response = await Mediator.Send(updateParentFeatureCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeletedParentFeatureResponse response = await Mediator.Send(new DeleteParentFeatureCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        GetByIdParentFeatureResponse response = await Mediator.Send(new GetByIdParentFeatureQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListParentFeatureQuery getListParentFeatureQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListParentFeatureListItemDto> response = await Mediator.Send(getListParentFeatureQuery);
        return Ok(response);
    }
}