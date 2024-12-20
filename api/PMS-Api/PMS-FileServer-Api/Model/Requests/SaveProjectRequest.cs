using PMS_FileServer_Api.Model.Enums;

namespace PMS_FileServer_Api.Model.Requests;

public record SaveProjectRequest(IFormFile File, TemplateOrProjectEnum TemplateOrProject, Guid TemplateOrProjectId);
