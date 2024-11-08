namespace PMS_Api.Interfaces;

public interface IUserRepository<User> where User : IUser
{
    Task<IReadOnlyList<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User?> GetByCredentialsAsync(string email, string password, CancellationToken cancellationToken);
    Task<User?> GetByUuidAsync(string uuid, CancellationToken cancellationToken);
    Task<bool> ChangePasswordAsync(Guid adminId, string password, CancellationToken cancellationToken);
}