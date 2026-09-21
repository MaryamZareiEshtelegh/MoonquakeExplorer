using Microsoft.Extensions.Configuration;

namespace MoonquakeExplorer.Data.NASA;

public class NasaClient : INasaClient
{
    public NasaClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    public string? MoonquakeUrl { get { return _configuration["NasaApi:MoonquakeUrl"]; } }

    public async Task<string> GetMoonquakesAsync()
    {
        var response = await _httpClient.GetAsync(MoonquakeUrl);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    
}