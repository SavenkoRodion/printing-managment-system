using Microsoft.EntityFrameworkCore;
using PMS_Api.Model.DbModel;

namespace PMS_Api.Repository;

public interface IPatternRepository
{
    Task<IReadOnlyList<Pattern>> GetAllAsync(CancellationToken cancellationToken);
    Task<Pattern?> GetByIdAsync(int id, CancellationToken cancellationToken);

}

public class PatternRepository(PmsContext context) : IPatternRepository
{
    public async Task<IReadOnlyList<Pattern>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await context.Patterns.AsNoTracking().ToListAsync(cancellationToken);
    }

    public async Task<Pattern?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        var pattern = await context.Patterns.FindAsync(id);
        return pattern ?? default;
    }

}
