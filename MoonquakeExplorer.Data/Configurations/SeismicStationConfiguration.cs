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

        builder.Property(s => s.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasData(
            new SeismicStationRecord
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Apollo 12",
                Latitude = -3.0098,
                Longitude = -23.4249,
                IsActive = true
            },
            new SeismicStationRecord
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Apollo 14",
                Latitude = -3.64419,
                Longitude = -17.47768,
                IsActive = true
            },
            new SeismicStationRecord
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Apollo 15",
                Latitude = 26.13406,
                Longitude = 3.62991,
                IsActive = true
            },
            new SeismicStationRecord
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Apollo 16",
                Latitude = -8.9759,
                Longitude = 15.4986,
                IsActive = true
            }
        );
    }
}
