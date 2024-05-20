namespace PMS_Api.Interfaces;

public interface IUserRepository<User> where User : IUser
{
    Task<IReadOnlyList<User>> GetAll(CancellationToken cancellationToken);
    Task<User?> GetByCredentials(string email, string password, CancellationToken cancellationToken);
}
