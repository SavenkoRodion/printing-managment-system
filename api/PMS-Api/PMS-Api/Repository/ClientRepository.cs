using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IClientRepository
{
    Task<IReadOnlyList<Client>> GetAllAsync(CancellationToken cancellationToken);
    Task<Client?> GetByIdAsync(int id, CancellationToken cancellationToken);

}

public class ClientRepository(PmsContext context) : IClientRepository
{
    public async Task<IReadOnlyList<Client>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Clients.AsNoTracking().ToListAsync(cancellationToken);
    }

  public async Task<Client?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var client = await context.Clients.FindAsync(id);
        return client ?? default;
    }
}
