namespace PMS_Api.Model.Requests;

public record ChangeNameRequest(Guid UserId, string NewName);
