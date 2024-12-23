using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;

namespace PMS_Api.Repository;

public interface IProjectRepository
{
    Task<bool> DeleteAsync(Project project, CancellationToken cancellationToken);
    Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken);
    Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Project?> AddProjectAsync(Project project, CancellationToken cancellationToken);
    Task<bool> EditAsync(EditProjectRequest request, CancellationToken cancellationToken);

}

public class ProjectRepository(PmsContext context) : IProjectRepository
{
    public async Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.ProjectType).ToListAsync(cancellationToken);
    }

    public async Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.ProjectType).FirstOrDefaultAsync(x => x.Id == id) ?? null;
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

    public async Task<bool> EditAsync(EditProjectRequest request, CancellationToken cancellationToken)
    {
        var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == request.ProjectId, cancellationToken);
        if (project is null)
            return false;

        project.Name = request.NewProjectName;
        project.ClientId = request.NewClientId;
        project.ProjectTypeId = request.NewProjectTypeId;
        project.Format = request.NewFormat;

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
