using Microsoft.AspNetCore.Mvc;
using PMS_FileServer_Api.Model.Requests;

namespace PMS_FileServer_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectFileController(IWebHostEnvironment environment) : ControllerBase
{
    [HttpGet]
    public string lol()
    {
        return "lol";
    }


    [HttpPost]
    public async Task<IActionResult> SaveProjectAsync([FromBody] SaveProjectRequest request, CancellationToken cancellationToken)
    {
        if (request.File == null || request.File.Length == 0)
            return BadRequest("No file provided.");
        var lol = "lol";
        var uploadFolder = Path.Combine(environment.ContentRootPath, $"Projects/{(request.TemplateOrProject == Model.Enums.TemplateOrProjectEnum.Template ? "Templates" : "Projects")}");

        if (!Directory.Exists(uploadFolder))
            Directory.CreateDirectory(uploadFolder);

        var fileName = $"{request.TemplateOrProjectId}.pdf";
        var filePath = Path.Combine(uploadFolder, fileName);

        await using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await request.File.CopyToAsync(fileStream);
        }

        return Ok();
    }
}
