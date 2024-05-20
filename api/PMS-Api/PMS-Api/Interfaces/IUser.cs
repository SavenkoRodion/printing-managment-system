namespace PMS_Api.Interfaces;

public interface IUser
{
    string Uuid { get; set; }
    string Email { get; set; }
    string Password { get; set; }
}