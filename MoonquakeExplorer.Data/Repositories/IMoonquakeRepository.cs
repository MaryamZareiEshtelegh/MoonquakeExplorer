using MoonquakeExplorer.Data.Models;

namespace MoonquakeExplorer.Data.Repositories;

public interface IMoonquakeRepository
{
    Task<List<MoonquakeRecord>> GetAllAsync();
    Task AddRangeAsync(List<MoonquakeRecord> moonquakes);
}