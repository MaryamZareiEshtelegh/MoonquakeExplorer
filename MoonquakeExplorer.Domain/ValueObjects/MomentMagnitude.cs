using MoonquakeExplorer.Domain.Exceptions;

namespace MoonquakeExplorer.Domain.ValueObjects;

/// <summary>
/// The strength of a moonquake. Recorded moonquakes have historically ranged
/// up to roughly 5.5 on the moment magnitude scale.
/// </summary>
public sealed record MomentMagnitude
{
    public double Value { get; }

    public MomentMagnitude(double value)
    {
        if (value is < 0 or > 10)
        {
            throw new DomainException("Magnitude must be between 0 and 10.");
        }

        Value = value;
    }

    public override string ToString() => Value.ToString("0.0");
}
