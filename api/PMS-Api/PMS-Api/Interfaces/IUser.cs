namespace PMS_Api.Interfaces;

public interface IUser
{
    Guid Uuid { get; init; }
    string Email { get; init; }
    string Password { get; init; }
}