using MoonquakeExplorer.Domain.Exceptions;

namespace MoonquakeExplorer.Domain.ValueObjects;

/// <summary>
/// A location on the Moon's surface expressed in selenographic latitude/longitude,
/// the lunar equivalent of Earth's geographic coordinate system.
/// </summary>
public sealed record SelenographicCoordinate
{
    public double Latitude { get; }

    public double Longitude { get; }

    public SelenographicCoordinate(double latitude, double longitude)
    {
        if (latitude is < -90 or > 90)
        {
            throw new DomainException("Latitude must be between -90 and 90 degrees.");
        }

        if (longitude is < -180 or > 180)
        {
            throw new DomainException("Longitude must be between -180 and 180 degrees.");
        }

        Latitude = latitude;
        Longitude = longitude;
    }
}
