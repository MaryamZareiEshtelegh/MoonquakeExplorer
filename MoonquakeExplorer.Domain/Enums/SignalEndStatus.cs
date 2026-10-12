namespace MoonquakeExplorer.Domain.Enums;

public enum SignalEndStatus
{
    Known = 0, // The signal end time is known and clearly defined.
    ContinuesUntilNextEvent = 1, // The signal end time is not known, and the signal continues until the next event occurs.
    Unknown = 2 // The signal end time is not known, and it is null .
}
