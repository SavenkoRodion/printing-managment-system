using Microsoft.AspNetCore.Mvc;

namespace PMS_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestFileController : ControllerBase
{
    [HttpPost]
    public void Test(IFormFile file)
    {
        var lol = 1;
        var lo1l = file;
    }

}
