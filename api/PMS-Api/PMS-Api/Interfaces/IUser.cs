namespace PMS_Api.Interfaces;

public interface IUser
{
    string Uuid { get; init; }
    string Email { get; init; }
    string Password { get; init; }
}

public record User(string Uuid, string Email, string Password) : IUser;