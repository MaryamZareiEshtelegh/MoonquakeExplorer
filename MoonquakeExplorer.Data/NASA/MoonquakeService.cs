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
        try
        {
            var csvData = await _nasaClient.GetMoonquakesAsync();
            var moonquakes = _moonquakeParser.Parse(csvData);

            var moonquakeRecords = moonquakes.Select(m => _moonquakeMapper.Map(m)).ToList();
            var occurredAts = moonquakeRecords.Where(x => x.OccurredAt.HasValue).Select(x => x.OccurredAt!.Value).ToList();

            var existingOccurredAts = await _moonquakeRepository.GetExistingOccurredAtAsync(occurredAts);
            //var newRecords = moonquakeRecords.Where(x => x.OccurredAt.HasValue && !existingOccurredAts.Contains(x.OccurredAt.Value)).ToList();

            var newRecords = moonquakeRecords
            .Where(x => x.OccurredAt.HasValue)
            .DistinctBy(x => x.OccurredAt!.Value)
            .Where(x => !existingOccurredAts.Contains(x.OccurredAt!.Value))
            .ToList();
            if (newRecords.Count > 0)
            {
                await _moonquakeRepository.AddRangeAsync(newRecords);
            }
            return moonquakes;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("An error occurred while retrieving moonquake data.", ex);
        }
    }
    public async Task<List<Moonquake>> GetStoredMoonquakesAsync()
    {
        var records = await _moonquakeRepository.GetAllAsync();

        return records
            .Select(record => _moonquakeMapper.MapToDomain(record))
            .ToList();
    }
}