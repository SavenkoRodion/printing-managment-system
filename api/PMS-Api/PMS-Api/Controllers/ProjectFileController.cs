using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectFileController() : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> UploadAsync([FromBody] SaveProjectRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        var response = await httpClient.PostAsJsonAsync("https://localhost:7159/ProjectFile", request);
        return response.IsSuccessStatusCode ? Ok() : Problem();
    }

}
