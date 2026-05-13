using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Application.Queries.Parks.GetParkById;

namespace ReWind.API.Controllers;

[ApiController]
[Route("api/parks")]
public class ParksController : ControllerBase
{
    private readonly IMediator _mediator;
    public ParksController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllParks()
    {
        var result = await _mediator.Send(new GetAllParksQuery());
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetParkById(Guid id)
    {
        var result = await _mediator.Send(new GetParkByIdQuery(id));
        return Ok(result);    
    }
   
}