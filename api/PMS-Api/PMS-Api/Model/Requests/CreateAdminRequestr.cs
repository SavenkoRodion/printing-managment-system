using System.ComponentModel.DataAnnotations;

namespace PMS_Api.Model.Requests;
public record CreateAdminRequest([Required] string AdminName, string AdminEmail, string Password);
