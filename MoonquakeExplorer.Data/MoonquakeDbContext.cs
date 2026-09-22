using Microsoft.EntityFrameworkCore;
using MoonquakeExplorer.Data.Models;

namespace MoonquakeExplorer.Data;

public class MoonquakeDbContext : DbContext
{
    public MoonquakeDbContext(DbContextOptions<MoonquakeDbContext> options) : base(options)
    {
        
    }
    public DbSet<MoonquakeRecord> MoonquakeRecords =>
    Set<MoonquakeRecord>();

    public DbSet<SeismicStationRecord> SeismicStations =>
    Set<SeismicStationRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MoonquakeDbContext).Assembly);
    }
}
