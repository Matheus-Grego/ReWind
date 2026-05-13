using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReWind.Application.Commands.Wastes.InsertWaste;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Application.Queries.Parks.GetParkById;
using ReWind.Application.Queries.Wastes.GetAllWastes;

namespace ReWind.API.Controllers;

[ApiController]
[Route("api/wastes")]
public class WastesController : ControllerBase
{
    private readonly IMediator _mediator;
    public WastesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllWastes()
    {
        var result = await _mediator.Send(new GetAllWastesQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> InsertWaste(InsertWasteCommand command)
    {
        var result = await _mediator.Send(command);
        return NoContent();
    }
}