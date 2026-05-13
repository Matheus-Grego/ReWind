using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReWind.Application.Queries.Parks.GetAllParks;

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
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllParksQuery());
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetParkById(Guid id)
    {
        return NoContent();
    }
   
}