namespace MoonquakeExplorer.Data.Models;

public class MoonquakeRecord
{
    public Guid Id { get; set; }
    public int? Year { get; set; }
    public int? JulianDay { get; set; }
    public int? SignalStartTime { get; set; }
    public int? SignalStopTime { get; set; }
    public DateTime? SignalStartedAt { get; set; }
    public DateTime? SignalStoppedAt { get; set; }
    public DateTime? OccurredAt { get; set; }
    public double? AmplitudeApollo11_12 { get; set; }
    public double? AmplitudeApollo14 { get; set; }
    public double? AmplitudeApollo15 { get; set; }
    public double? AmplitudeApollo16 { get; set; }
    public int? PlotAvailabilityApollo11_12 { get; set; }
    public int? PlotAvailabilityApollo14 { get; set; }
    public int? PlotAvailabilityApollo15 { get; set; }
    public int? PlotAvailabilityApollo16 { get; set; }
    public int? DataQualityApollo11_12 { get; set; }
    public int? DataQualityApollo14 { get; set; }
    public int? DataQualityApollo15 { get; set; }
    public int? DataQualityApollo16 { get; set; }
    public string? Comments { get; set; }
    public string? OriginalEventType { get; set; }
    public int? OriginalClusterNumber { get; set; }
    public string? EventType { get; set; }
    public int? ClusterNumber { get; set; }
    public string? Grade { get; set; }
    public int? Traces { get; set; }
    public int? Apollo12Lpx { get; set; }
    public int? Apollo12Lpy { get; set; }
    public int? Apollo12Lpz { get; set; }
    public int? Apollo14Spz { get; set; }
    public int? Apollo14Lpx { get; set; }
    public int? Apollo14Lpy { get; set; }
    public int? Apollo14Lpz { get; set; }
    public int? Apollo15Spz { get; set; }
    public int? Apollo15Lpx { get; set; }
    public int? Apollo15Lpy { get; set; }
    public int? Apollo15Lpz { get; set; }
    public int? Apollo16Spz { get; set; }
    public int? Apollo16Lpx { get; set; }
    public int? Apollo16Lpy { get; set; }
    public int? Apollo16Lpz { get; set; }
}