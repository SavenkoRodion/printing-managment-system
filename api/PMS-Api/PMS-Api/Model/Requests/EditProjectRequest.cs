namespace PMS_Api.Model.Requests;

public record EditProjectRequest(int ProjectId, string NewProjectName, Guid NewClientId, int NewProductId, string NewFormat);
