namespace MoonquakeExplorer.Domain.Enums;

/// <summary>
/// The classification used by lunar seismology (per Apollo Passive Seismic Experiment data)
/// to describe what generated a moonquake.
/// </summary>
public enum MoonquakeCategory
{
    /// <summary>Originates ~700-1200 km below the surface, tied to tidal stress from Earth's gravity.</summary>
    DeepMoonquake,

    /// <summary>Originates within ~200 km of the surface; rarer but far more energetic than deep moonquakes.</summary>
    ShallowMoonquake,

    /// <summary>Caused by a meteoroid striking the lunar surface.</summary>
    MeteoroidImpact,

    /// <summary>Caused by thermal expansion/contraction of the surface across the lunar day/night cycle.</summary>
    ThermalMoonquake
}
