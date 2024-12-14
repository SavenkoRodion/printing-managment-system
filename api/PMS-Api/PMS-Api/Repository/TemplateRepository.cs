using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;

namespace PMS_Api.Repository;

public interface ITemplateRepository
{
    Task<bool> DeleteAsync(Template template, CancellationToken cancellationToken);
    Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken);
    Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Template?> AddTemplateAsync(Template template, CancellationToken cancellationToken);
    Task<bool> EditAsync(EditTemplateRequest request, CancellationToken cancellationToken);

}

public class TemplateRepository(PmsContext context) : ITemplateRepository
{
    public async Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Templates.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).ToListAsync(cancellationToken);
    }

    public async Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Templates.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id) ?? null;
    }



    public async Task<Template?> AddTemplateAsync(Template template, CancellationToken cancellationToken)
    {
        try
        {
            context.Templates.Add(template);
            await context.SaveChangesAsync(cancellationToken);
            return template;
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> DeleteAsync(Template template, CancellationToken cancellationToken)
    {
        try
        {
            context.Templates.Remove(template);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> EditAsync(EditTemplateRequest request, CancellationToken cancellationToken)
    {
        var template = await context.Templates.FirstOrDefaultAsync(x => x.Id == request.TemplateId, cancellationToken);
        if (template is null)
            return false;

        template.Name = request.NewTemplateName;
        template.ClientId = request.NewClientId;
        template.ProductId = request.NewProductId;
        template.Format = request.NewFormat;

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
