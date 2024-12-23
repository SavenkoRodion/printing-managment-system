using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IProjectTypeRepository
{
    Task<IReadOnlyList<ProjectType>> GetAllAsync(CancellationToken cancellationToken);
    Task<ProjectType?> GetFirstOrDefaultAsync(int projectTypeId, CancellationToken cancellationToken);
    Task<bool> CreateAsync(string projectTypeName, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(int projectTypeId, CancellationToken cancellationToken);
    Task<bool> RenameAsync(string newProjectTypeName, int projectTypeId, CancellationToken cancellationToken);
}

public class ProjectTypeRepository(PmsContext context) : IProjectTypeRepository
{
    public async Task<IReadOnlyList<ProjectType>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.ProjectTypes.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<ProjectType?> GetFirstOrDefaultAsync(int projectTypeId, CancellationToken cancellationToken)
    {
        return await context.ProjectTypes.AsNoTracking().FirstOrDefaultAsync(projectType => projectType.Id == projectTypeId, cancellationToken);
    }

    public async Task<bool> CreateAsync(string projectTypeName, CancellationToken cancellationToken)
    {
        await context.ProjectTypes.AddAsync(new ProjectType() { Name = projectTypeName, DateOfCreation = DateTime.Now }, cancellationToken);
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

    public async Task<bool> DeleteAsync(int projectTypeId, CancellationToken cancellationToken)
    {
        try
        {
            await context.ProjectTypes.Where(x => x.Id == projectTypeId).ExecuteDeleteAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> RenameAsync(string newProjectTypeName, int projectTypeId, CancellationToken cancellationToken)
    {
        var projectType = await context.ProjectTypes.FirstOrDefaultAsync(x => x.Id == projectTypeId, cancellationToken);
        if (projectType is null)
            return false;

        projectType.Name = newProjectTypeName;

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
