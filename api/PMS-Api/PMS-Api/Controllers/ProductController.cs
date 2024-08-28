using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Model.Requests;
using PMS_Api.Model.Scaffold;
using PMS_Api.Repository;

namespace PMS_Api.Controllers;

[Authorize]
[Route("api/product")]
[ApiController]
public class ProductController(IProductRepository repository)
{
    [HttpGet("/")]
    public async Task<IReadOnlyList<Product>> GetAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAllAsync(cancellationToken);
    }

    [HttpPost("/")]
    public async Task<bool> CreateAsync([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
    {
        return await repository.CreateAsync(request.ProductName, cancellationToken);
    }
}
