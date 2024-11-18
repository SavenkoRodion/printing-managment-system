using System.ComponentModel.DataAnnotations;

namespace PMS_Api.Model.Requests;
public record CreateAdminRequest(string AdminName, string AdminEmail, string Password);
