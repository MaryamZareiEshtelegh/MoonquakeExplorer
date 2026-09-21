using Microsoft.AspNetCore.Mvc;

public class MoonquakeController : ControllerBase
{
    private readonly MoonquakeService _moonquakeService;
    public MoonquakeController(MoonquakeService moonquakeService)
    {
        _moonquakeService = moonquakeService;
    }

    [HttpGet("api/moonquakes")]
    public async Task<IActionResult> GetMoonquakesAsync()
    {
        try
        {
            var moonquakes = await _moonquakeService.GetMoonquakesAsync();
            return Ok(moonquakes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}