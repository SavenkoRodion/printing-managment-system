using Microsoft.AspNetCore.Mvc;
using PMS_Api.Enums;

namespace PMS_Api.Model.Requests;

public record SaveProjectRequest([FromForm(Name = "File")] IFormFile File, [FromForm(Name = "TemplateOrProject")] TemplateOrProjectEnum TemplateOrProject, [FromForm(Name = "TemplateOrProjectId")] int TemplateOrProjectId);
