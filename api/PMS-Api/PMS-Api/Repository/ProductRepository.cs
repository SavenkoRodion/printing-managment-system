using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.Scaffold;

namespace PMS_Api.Repository;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken cancellationToken);
    Task<bool> CreateAsync(string productName, CancellationToken cancellationToken);
}

public class ProductRepository(PmsContext context) : IProductRepository
{
    public async Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Products.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<bool> CreateAsync(string productName, CancellationToken cancellationToken)
    {
        await context.Products.AddAsync(new Product() { Name = productName, DateOfCreation = DateTime.Now }, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
