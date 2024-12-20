using PMS_Api.Enums;

namespace PMS_Api.Model.Requests;

public record SaveProjectRequest(IFormFile File, TemplateOrProjectEnum TemplateOrProject, Guid TemplateOrProjectId);
