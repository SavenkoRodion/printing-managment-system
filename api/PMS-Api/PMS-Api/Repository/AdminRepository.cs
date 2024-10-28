using Microsoft.EntityFrameworkCore;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public class AdminRepository(PmsContext context) : IUserRepository<Admin>
{
    public async Task<IReadOnlyList<Admin>> GetAll(CancellationToken cancellationToken)
        => await context.Admins.ToListAsync(cancellationToken);

    public async Task<Admin?> GetByCredentials(string email, string password, CancellationToken cancellationToken)
        => await context.Admins.FirstOrDefaultAsync(x => x.Email == email && x.Password == password, cancellationToken);

    public async Task<Admin?> GetByUuid(string uuid, CancellationToken cancellationToken)
        => await context.Admins.FirstOrDefaultAsync(x => x.Uuid == Guid.Parse(uuid), cancellationToken);
}