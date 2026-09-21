using MoonquakeExplorer.Domain.Common;
using MoonquakeExplorer.Domain.Exceptions;
using MoonquakeExplorer.Domain.ValueObjects;

namespace MoonquakeExplorer.Domain.Entities;

/// <summary>
/// A seismometer station that recorded moonquakes, such as the Apollo Passive
/// Seismic Experiment stations left on the Moon between 1969 and 1972.
/// </summary>
public sealed class SeismicStation : Entity
{
    public string Name { get; private set; }

    public SelenographicCoordinate Location { get; private set; }

    public bool IsActive { get; private set; }

    public SeismicStation(string name, SelenographicCoordinate location, bool isActive = true)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new DomainException("Station name is required.");
        }

        Name = name;
        Location = location;
        IsActive = isActive;
    }

    /// <summary>Reconstructs a station with a known Id, e.g. when loading it back from storage.</summary>
    public SeismicStation(Guid id, string name, SelenographicCoordinate location, bool isActive = true)
        : this(name, location, isActive)
    {
        Id = id;
    }

    public void Decommission() => IsActive = false;
}
