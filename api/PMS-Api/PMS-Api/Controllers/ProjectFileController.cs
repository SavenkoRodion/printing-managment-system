using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Enums;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProjectFileController(IWebHostEnvironment environment) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IFormFile>> GetAsync(int id, TemplateOrProjectEnum templateOrProject)
    {
        var filePath = Path.Combine(environment.ContentRootPath, $"Files/{(templateOrProject == TemplateOrProjectEnum.Template ? "Templates" : "Projects")}", $"{id}.pdf");

        if (!System.IO.File.Exists(filePath))
        {
            return NotFound();
        }

        var fileBytes = await System.IO.File.ReadAllBytesAsync(filePath);

        return File(fileBytes, "application/pdf", $"{id}.pdf");
    }

    [HttpPost]
    public async Task<IActionResult> UploadAsync([FromForm] SaveProjectRequest request, CancellationToken cancellationToken)
    {
        if (request.File == null || request.File.Length == 0)
            return BadRequest();

        var uploadFolder = Path.Combine(environment.ContentRootPath, $"Files/{(request.TemplateOrProject == TemplateOrProjectEnum.Template ? "Templates" : "Projects")}");

        if (!Directory.Exists(uploadFolder))
            Directory.CreateDirectory(uploadFolder);

        var fileName = $"{request.TemplateOrProjectId}.pdf";
        var filePath = Path.Combine(uploadFolder, fileName);

        await using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await request.File.CopyToAsync(fileStream, cancellationToken);
        }

        return Ok();
    }
}
