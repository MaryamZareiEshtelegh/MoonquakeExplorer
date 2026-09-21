using Microsoft.AspNetCore.Mvc;

namespace MoonquakeExplorer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalendarController : ControllerBase
{
    [HttpGet("dates")]
    public ActionResult<IEnumerable<DateOnly>> GetDates([FromQuery] int? year)
    {
        var requestedYear = year ?? DateTime.UtcNow.Year;

        if (requestedYear is < 1 or > 9999)
        {
            return BadRequest("Year must be between 1 and 9999.");
        }

        var firstDate = new DateOnly(requestedYear, 1, 1);
        var numberOfDays = DateTime.IsLeapYear(requestedYear) ? 366 : 365;
        var dates = Enumerable.Range(0, numberOfDays)
            .Select(firstDate.AddDays)
            .ToArray();
        return Ok(dates);
    }
}
