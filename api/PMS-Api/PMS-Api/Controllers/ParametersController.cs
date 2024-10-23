using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.Scaffold;

namespace PMS_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParametersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetParameters()
    {
        var parameters = new List<Parameter>
        {
            new() { Id = 1, Name = "Parametr1" },
            new() { Id = 2, Name = "Parametr2" },
            new() { Id = 3, Name = "Parametr3" }
        };

        return Ok(parameters);
    }
}
