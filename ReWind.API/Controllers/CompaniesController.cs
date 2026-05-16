using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReWind.Application.DTOs;
using ReWind.Application.Queries.Companies.GetAllCompanies;
using ReWind.Application.Queries.Companies.GetCompanyById;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Application.Queries.Parks.GetParkById;

namespace ReWind.API.Controllers;

[ApiController]
[Route("api/companies")]
public class CompaniesController : ControllerBase
{
    private readonly IMediator _mediator;
    public CompaniesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllCompanies()
    {
        var result = await _mediator.Send(new GetAllCompaniesQuery());
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCompanyById(Guid id)
    {
        var result = await _mediator.Send(new GetCompanyByIdQuery(id));
        return Ok(result);    
    }
   
}