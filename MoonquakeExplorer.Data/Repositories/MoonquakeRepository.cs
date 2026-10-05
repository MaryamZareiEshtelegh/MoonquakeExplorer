using MoonquakeExplorer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MoonquakeExplorer.Data.Repositories;

public class MoonquakeRepository : IMoonquakeRepository
{
    private readonly MoonquakeDbContext _dbContext;
    public MoonquakeRepository(MoonquakeDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<List<MoonquakeRecord>> GetAllAsync()
    {
        return _dbContext.Moonquakes.ToListAsync();
    }
    public async Task AddRangeAsync(List<MoonquakeRecord> moonquakes)
    {
        await _dbContext.Moonquakes.AddRangeAsync(moonquakes);
        await _dbContext.SaveChangesAsync();
    }
    public Task<HashSet<DateTime>> GetExistingOccurredAtAsync(List<DateTime> occurredAts)
    {
        return _dbContext.Moonquakes
            .Where(m => m.OccurredAt.HasValue && occurredAts.Contains(m.OccurredAt.Value))
            .Select(m => m.OccurredAt!.Value)
            .ToHashSetAsync();
    }
}