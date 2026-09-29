using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoonquakeExplorer.Data.Models;

namespace MoonquakeExplorer.Data.Configurations;

public class MoonquakeConfiguration : IEntityTypeConfiguration<MoonquakeRecord>
{
    public void Configure(EntityTypeBuilder<MoonquakeRecord> builder)
    {
        builder.ToTable("Moonquakes");
        builder.HasKey(m => m.Id);
        builder.HasIndex(m => m.OccurredAt).IsUnique();
    }
}