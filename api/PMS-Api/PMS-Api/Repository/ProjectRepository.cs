using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IProjectRepository
{
    Task<bool> DeleteAsync(Project project, CancellationToken cancellationToken);
    Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken);
    Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<Project> AddProjectAsync(Project project, CancellationToken cancellationToken);

}

public class ProjectRepository(PmsContext context) : IProjectRepository
{
    public async Task<IReadOnlyList<Project>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).ToListAsync(cancellationToken);
    }

    public async Task<Project?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await context.Projects.Include(x => x.Author).Include(x => x.Client).Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id) ?? default;
    }

    

    public async Task<Project> AddProjectAsync(Project project, CancellationToken cancellationToken)
    {
        try
        {
            context.Projects.Add(project);
            await context.SaveChangesAsync(cancellationToken);
            return project;
        }
        catch (DbUpdateException dbEx)
        {
            Console.Error.WriteLine($"Database update error: {dbEx.Message}");
            throw new Exception("An error occurred while saving the project to the database.");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Unexpected error: {ex.Message}");
            throw new Exception("An unexpected error occurred while processing the request.");
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
