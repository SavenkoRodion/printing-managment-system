namespace PMS_Api.Model.Requests;

public record ChangePasswordRequest(Guid UserId, string NewPassword);
