using MoonquakeExplorer.Domain.Entities;

public interface IMoonquakeParser
{
    List<Moonquake> Parse(string csv);
}