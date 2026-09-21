namespace MoonquakeExplorer.Data.Models;

/// <summary>
/// EF Core persistence model for a moonquake. Kept separate from the domain's
/// <c>Moonquake</c> entity so storage concerns never leak into the domain layer.
/// </summary>
public class MoonquakeRecord
{
    public Guid Id { get; set; }

    public string Category { get; set; } = string.Empty;

    public double Magnitude { get; set; }

    public double DepthKilometers { get; set; }

    public double EpicenterLatitude { get; set; }

    public double EpicenterLongitude { get; set; }

    public DateTimeOffset OccurredAt { get; set; }

    public Guid RecordingStationId { get; set; }
}
