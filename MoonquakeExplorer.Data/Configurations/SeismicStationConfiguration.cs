using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoonquakeExplorer.Data.Models;

namespace MoonquakeExplorer.Data.Configurations;

public class SeismicStationConfiguration : IEntityTypeConfiguration<SeismicStationRecord>
{
    public void Configure(EntityTypeBuilder<SeismicStationRecord> builder)
    {
        builder.ToTable("SeismicStations");
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
    }
}
