using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IProjectRepository
{
    Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken);
    Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken);

}

public class ProjectRepository(PmsContext context) : IProjectRepository
{
    public async Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x=>x.Author).Include(x=>x.Client).Include(x=>x.Product).ToListAsync(cancellationToken);
    }
 public async Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var project = await context.Projects.FindAsync(id);
        return project ?? default;
    }
}
