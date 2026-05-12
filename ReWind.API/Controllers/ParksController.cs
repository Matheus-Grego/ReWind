using Microsoft.AspNetCore.Mvc;

namespace ReWind.API.Controllers;

[ApiController]
[Route("api/parks")]
public class ParksController : ControllerBase
{
    public async Task<IActionResult> Get()
    {
        return NoContent();
    }
   
}