using PMS_Api.Enums;

namespace PMS_Api.Interfaces;

public interface IUserRepository<User> where User : IUser
{
    Task<IReadOnlyList<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User?> GetByCredentialsAsync(string email, string password, CancellationToken cancellationToken);
    Task<User?> GetByUuidAsync(string uuid, CancellationToken cancellationToken);
    Task<bool> ChangePasswordAsync(Guid adminId, string password, CancellationToken cancellationToken);
    Task<bool> UpdateNameAsync(Guid userId, string newName, CancellationToken cancellationToken);
    Task<CreateAdminResult> CreateAdminAsync(string adminName, string adminEmail, string password, CancellationToken cancellationToken);
    Task<bool> DeleteAdminAsync(Guid adminId, CancellationToken cancellationToken);
}