using MoonquakeExplorer.Data.Models;
using MoonquakeExplorer.Domain.Entities;
using MoonquakeExplorer.Domain.Enums;
using MoonquakeExplorer.Domain.ValueObjects;

namespace MoonquakeExplorer.Data.Mapping;

/// <summary>
/// Converts between domain entities and their EF Core persistence models.
/// </summary>
public static class MoonquakeMapper
{
   
    public static SeismicStation ToDomain(this SeismicStationRecord record) => new(
        record.Id,
        record.Name,
        new SelenographicCoordinate(record.Latitude, record.Longitude),
        record.IsActive);

    public static SeismicStationRecord ToRecord(this SeismicStation station) => new()
    {
        Id = station.Id,
        Name = station.Name,
        Latitude = station.Location.Latitude,
        Longitude = station.Location.Longitude,
        IsActive = station.IsActive
    };
}
