using Microsoft.EntityFrameworkCore;
using PMS_Api.Interfaces;

namespace PMS_Api.Repository;

public class UserRepository(PmsContext context) : IUserRepository<User>
{
    public async Task<IReadOnlyList<User>> GetAll(CancellationToken cancellationToken)
        => await context.Admins.ToListAsync(cancellationToken);

    public async Task<User?> GetByCredentials(string email, string password, CancellationToken cancellationToken)
        => await context.Admins.FirstOrDefaultAsync(x => x.Email == email && x.Password == password, cancellationToken);
}
