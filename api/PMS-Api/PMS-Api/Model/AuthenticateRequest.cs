using System.ComponentModel.DataAnnotations;

namespace PMS_Api.Model;

public class AuthenticateRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}