using PMS_Api.Model.Db.Scaffold;

namespace PMS_Api.Model.Responses;

public record AuthenticateAdminResponse(Admin User, string Token);
