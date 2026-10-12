using MoonquakeExplorer.Data;
using MoonquakeExplorer.Data.Mapping;
using MoonquakeExplorer.Domain.Entities;
using Xunit;

namespace MoonquakeExplorer.Tests;

public class MoonquakeMapperTests
{
    [Fact]
    // given = function name, when = input, then = output.....  and you need to care about the naming convention of the test method
    // his is a unit test for the Map function in the MoonquakeMapper class.
    //  It tests the scenario where the signal crosses midnight, and the stop time should be moved to the next day.
    public void Map_WhenSignalCrossesMidnight_ShouldMoveStopTimeToNextDay()
    {
        var mapper = new MoonquakeMapper();

        var moonquake = new Moonquake
        {
            Year = 69,
            JulianDay = 208,
            SignalStartTime = 2348,
            SignalStopTime = 40
        };

        var result = mapper.Map(moonquake);
        var expectedStartedAt = new DateTime(1969, 7, 27, 23, 48, 0, DateTimeKind.Utc);
        var expectedStoppedAt = new DateTime(1969, 7, 28, 0, 40, 0, DateTimeKind.Utc);

        Assert.Equal(expectedStartedAt, result.SignalStartedAt);

        Assert.Equal(expectedStoppedAt, result.SignalStoppedAt);
    }

    [Fact]
    public void Map_WhenSignalStartTimeIsMissing_ShouldReturnNullForSignalStartedAt()
    {
        // Arrange
        var mapper = new MoonquakeMapper();
        var moonquake = new Moonquake
        {
            Year = 69,
            JulianDay = 208,
            SignalStartTime = null, // SignalStartTime is missing
            SignalStopTime = 40
        };
        // Act
        var result = mapper.Map(moonquake);
        // Assert that the SignalStartedAt property is null when the SignalStartTime is missing
        Assert.Null(result.SignalStartedAt);
    }

    [Theory]
    [InlineData(null, 208, 2348, 40)]
    [InlineData(70, null, 2348, 30)]
    [InlineData(69, 365, null, 1)]
    public void Map_WhenDatePartIsMissing_ShouldReturnNullForSignalStartedAt(int? year, int? julianDay, int? signalStartTime, int signalStopTime)
    {
        // Arrange
        var mapper = new MoonquakeMapper();
        var moonquake = new Moonquake
        {
            Year = year,
            JulianDay = julianDay,
            SignalStartTime = signalStartTime,
            SignalStopTime = signalStopTime
        };
        // Act
        var result = mapper.Map(moonquake);
        // Assert
        Assert.Null(result.SignalStartedAt);
    }

    [Theory]
    [InlineData(72, 366, 1200, 1972, 12, 31, 12, 0)]
    [InlineData(69, 208, 2348, 1969, 7, 27, 23, 48)]
    [InlineData(69, 1, 0, 1969, 1, 1, 0, 0)]
    [InlineData(70, 1, 1230, 1970, 1, 1, 12, 30)]
    [InlineData(69, 365, 1200, 1969, 12, 31, 12, 0)]
    public void Map_WhenDateIsValid_ShouldCreateCorrectSignalStartDate(
    int year,
    int julianDay,
    int signalStartTime,
    int expectedYear,
    int expectedMonth,
    int expectedDay,
    int expectedHour,
    int expectedMinute)
    {
        // Arrange
        var mapper = new MoonquakeMapper();

        var moonquake = new Moonquake
        {
            Year = year,
            JulianDay = julianDay,
            SignalStartTime = signalStartTime,
            SignalStopTime = 1300
        };

        // Act
        var result = mapper.Map(moonquake);
        // Assert
        var expectedDate = new DateTime(
            expectedYear,
            expectedMonth,
            expectedDay,
            expectedHour,
            expectedMinute,
            0,
            DateTimeKind.Utc);

        Assert.Equal(expectedDate, result.SignalStartedAt);
    }

}