using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReWind.Application.Commands.ParkWastes.UpdateParkWaste;
using ReWind.Application.Commands.Wastes.InsertWaste;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Application.Queries.Parks.GetParkById;
using ReWind.Application.Queries.ParkWastes.GetParkWasteById;
using ReWind.Application.Queries.ParkWastes.GetParkWastesByParkId;
using ReWind.Application.Queries.Wastes.GetAllWastes;

namespace ReWind.API.Controllers;

[ApiController]
[Route("api/parkWastes")]
public class ParkWastesController : ControllerBase
{
    private readonly IMediator _mediator;
    public ParkWastesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("Parks/{id}")]
    public async Task<IActionResult> GetParkWastesByParkId(Guid id)
    {
        var result = await _mediator.Send(new GetParkWastesByParkIdQuery(id));
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetParkWasteById(Guid id)
    {
        var result = await _mediator.Send(new GetParkWasteByIdQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateParkWaste(UpdateParkWasteCommand command)
    {
        var result = await _mediator.Send(command);
        return NoContent();
    }
    
    
}