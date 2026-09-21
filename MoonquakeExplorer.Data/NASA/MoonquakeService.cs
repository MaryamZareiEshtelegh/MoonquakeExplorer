using MoonquakeExplorer.Domain.Entities;

public class MoonquakeService
{
    private readonly INasaClient _nasaClient;
    private readonly IMoonquakeParser _moonquakeParser;
    public MoonquakeService(INasaClient nasaClient, IMoonquakeParser parser)
    {
        _nasaClient = nasaClient;
        _moonquakeParser = parser;
    }

    public async Task<List<Moonquake>> GetMoonquakesAsync()
    {
        var csvData = await _nasaClient.GetMoonquakesAsync();
        return _moonquakeParser.Parse(csvData);
    }
}