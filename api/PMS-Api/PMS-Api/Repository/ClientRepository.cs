using Microsoft.EntityFrameworkCore;
using PMS_Api.Enums;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IClientRepository
{
    Task<IReadOnlyList<Client>> GetAllAsync(CancellationToken cancellationToken);
    Task<Client?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<CreateClientResult> CreateClientAsync(string clientName, string clientEmail, string address, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(Guid clientId, CancellationToken cancellationToken);
    Task<bool> EditAsync(Guid clientId, string newClientName, string newClientEmail, string newClientAddress, CancellationToken cancellationToken);
    
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

    public async Task<CreateClientResult> CreateClientAsync(string clientName, string clientEmail, string address, CancellationToken cancellationToken)
    {
        bool clientExists = await context.Clients.AnyAsync(x => x.Email == clientEmail, cancellationToken);

        if (clientExists)
        {
            return CreateClientResult.Duplicate;
        }
        await context.Clients.AddAsync(new Client()
        {
            Name = clientName,
            Email = clientEmail,
            Address = address,
            Uuid = Guid.NewGuid(),
            DateOfCreation = DateTime.Now.Date
        }, cancellationToken);

        try
        {
            await context.SaveChangesAsync(cancellationToken);
            return CreateClientResult.Success;
        }
        catch
        {
            return CreateClientResult.Failure;
        }
    }

    public async Task<bool> DeleteAsync(Guid clientId, CancellationToken cancellationToken)
    {
        try
        {
            await context.Clients.Where(x => x.Uuid == clientId).ExecuteDeleteAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> EditAsync(Guid clientId, string newClientName, string newClientEmail, string newClientAddress, CancellationToken cancellationToken)
    {
        var client = await context.Clients.FirstOrDefaultAsync(x => x.Uuid == clientId, cancellationToken);
        if (client is null)
            return false;

        client.Name = newClientName;
        client.Email = newClientEmail;
        client.Address = newClientAddress;

        try
        {
            await context.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            return false;
        }

        return true;
    }
}
