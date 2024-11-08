using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken cancellationToken);
    Task<Product?> GetFirstOrDefaultAsync(int productId, CancellationToken cancellationToken);
    Task<bool> CreateAsync(string productName, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(int productId, CancellationToken cancellationToken);
    Task<bool> RenameAsync(string newProductName, int productId, CancellationToken cancellationToken);
}

public class ProductRepository(PmsContext context) : IProductRepository
{
    public async Task<IReadOnlyList<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Products.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<Product?> GetFirstOrDefaultAsync(int productId, CancellationToken cancellationToken)
    {
        return await context.Products.AsNoTracking().FirstOrDefaultAsync(product => product.Id == productId, cancellationToken);
    }

    public async Task<bool> CreateAsync(string productName, CancellationToken cancellationToken)
    {
        await context.Products.AddAsync(new Product() { Name = productName, DateOfCreation = DateTime.Now }, cancellationToken);
        try
        {
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int productId, CancellationToken cancellationToken)
    {
        try
        {
            await context.Products.Where(x => x.Id == productId).ExecuteDeleteAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> RenameAsync(string newProductName, int productId, CancellationToken cancellationToken)
    {
        var product = await context.Products.FirstOrDefaultAsync(x => x.Id == productId, cancellationToken);
        if (product is null)
            return false;

        product.Name = newProductName;

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
