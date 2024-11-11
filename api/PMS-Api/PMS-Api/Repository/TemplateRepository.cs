using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface ITemplateRepository
{
    Task<bool> DeleteAsync(Template template, CancellationToken cancellationToken);
    Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken);
    Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Template> AddTemplateAsync(Template template, CancellationToken cancellationToken);

}

public class TemplateRepository(PmsContext context) : ITemplateRepository
{
    public async Task<IReadOnlyList<Template>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Templates.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).ToListAsync(cancellationToken);
    }

    public async Task<Template?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Templates.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id) ?? default;
    }

    

    public async Task<Template> AddTemplateAsync(Template template, CancellationToken cancellationToken)
    {
        try
        {
            context.Templates.Add(template);
            await context.SaveChangesAsync(cancellationToken);
            return template;
        }
        catch (DbUpdateException dbEx)
        {
            Console.Error.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while saving the template to the database.");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Unexpected error: {ex.Message}");
            throw new Exception("An unexpected error occurred while processing the request.");
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
}
