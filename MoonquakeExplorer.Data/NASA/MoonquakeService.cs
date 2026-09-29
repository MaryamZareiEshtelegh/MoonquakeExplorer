using MoonquakeExplorer.Data.Mapping;
using MoonquakeExplorer.Data.Repositories;
using MoonquakeExplorer.Domain.Entities;

public class MoonquakeService
{
    private readonly INasaClient _nasaClient;
    private readonly IMoonquakeParser _moonquakeParser;
    private readonly IMoonquakeRepository _moonquakeRepository;
    private readonly MoonquakeMapper _moonquakeMapper;
    public MoonquakeService(INasaClient nasaClient, IMoonquakeParser parser, IMoonquakeRepository moonquakeRepository)
    {
        _nasaClient = nasaClient;
        _moonquakeParser = parser;
        _moonquakeRepository = moonquakeRepository;
        _moonquakeMapper = new MoonquakeMapper();
    }
    public async Task<List<Moonquake>> GetMoonquakesAsync()
    {
        var csvData = await _nasaClient.GetMoonquakesAsync();
        var moonquakes = _moonquakeParser.Parse(csvData);
        var moonquakeRecords = moonquakes.Select(m => _moonquakeMapper.Map(m)).ToList();
        await _moonquakeRepository.AddRangeAsync(moonquakeRecords);
        return moonquakes;
    }
}