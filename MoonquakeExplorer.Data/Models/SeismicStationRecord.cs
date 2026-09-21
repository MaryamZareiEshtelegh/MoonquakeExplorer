namespace MoonquakeExplorer.Data.Models;

/// <summary>
/// EF Core persistence model for a seismic station.
/// </summary>
public class SeismicStationRecord
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public bool IsActive { get; set; }
}
