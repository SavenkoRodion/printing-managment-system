using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IProjectRepository
{
    Task<bool> DeleteAsync(Project project, CancellationToken cancellationToken);
    Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken);
    Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Project?> AddProjectAsync(Project project, CancellationToken cancellationToken);

}

public class ProjectRepository(PmsContext context) : IProjectRepository
{
    public async Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).ToListAsync(cancellationToken);
    }

    public async Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id) ?? null;
    }



    public async Task<Project?> AddProjectAsync(Project project, CancellationToken cancellationToken)
    {
        try
        {
            context.Projects.Add(project);
            await context.SaveChangesAsync(cancellationToken);
            return project;
        }
        catch
        {
            return null;
        }
    }

    public async Task<bool> DeleteAsync(Project project, CancellationToken cancellationToken)
    {
        try
        {
            context.Projects.Remove(project);
            await context.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
