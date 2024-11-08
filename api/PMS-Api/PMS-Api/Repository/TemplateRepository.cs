using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface ITemplateRepository
{
    Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken);
    Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken);

}

public class TemplateRepository(PmsContext context) : ITemplateRepository
{
    public async Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Templates.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).ToListAsync(cancellationToken);
    }

    public async Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var template = await context.Templates.FindAsync(id);
        return template ?? default;
    }

}
