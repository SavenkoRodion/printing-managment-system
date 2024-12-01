namespace PMS_Api.Model.Requests;

public record EditClientRequest(Guid Uuid, string Name, string Address, string Email);
