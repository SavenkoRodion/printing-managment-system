using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;
using PMS_Api.Repository;

namespace PMS_Api.Controllers;

[Authorize]
[Route("api/product")]
[ApiController]
public class ProductController(IProductRepository repository)
{
    [HttpGet]
    public async Task<IReadOnlyList<Product>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }

    [HttpPost]
    public async Task<bool> CreateAsync([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
    {
        return await repository.CreateAsync(request.ProductName, cancellationToken);
    }

    [HttpDelete("{productId}")]
    public async Task<bool> DeleteAsync([FromRoute] int productId, CancellationToken cancellationToken)
    {
        return await repository.DeleteAsync(productId, cancellationToken);
    }

    [HttpPut("replace")]
    public async Task<bool> PutAsync(ReplaceProductRequest request, CancellationToken cancellationToken)
    {
        var originalProduct = await repository.GetFirstOrDefaultAsync(request.Id, cancellationToken);
        return originalProduct is not null && await repository.ReplaceAsync(originalProduct, cancellationToken);
    }
}
