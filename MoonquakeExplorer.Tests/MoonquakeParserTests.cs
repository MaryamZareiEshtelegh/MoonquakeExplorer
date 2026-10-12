using MoonquakeExplorer.Data.NASA;
using Xunit;

namespace MoonquakeExplorer.Tests;

public class MoonquakeParserTests
{
    [Fact]
    public void Parse_WhenSignalStopTimeIs9999_ShouldPreserveOriginalValue()
    {
        // Arrange
        var parser = new MoonquakeParser();

        var csv = """
            Y,JD,S,E,A1,A2,A3,A4,P1,P2,P3,P4,Q1,Q2,Q3,Q4,COMMENTS,T1,N1,T2,N2,Grade,Traces,12LPX,12LPY,12LPZ,14SPZ,14LPX,14LPY,14LPZ,15SPZ,15LPX,15LPY,15LPZ,16SPZ,16LPX,16LPY,16LPZ
            69,208,2348,9999,3.1,,,,,,,,5,,,,11Z AMPLITUDE,M,,M,,,,,,,,,,,,,,,,,,
            """;


        var fields = csv.Split('\n')[1].Split(',');
        Console.WriteLine($"Number of fields: {fields.Length}");    
        // Act
        var result = parser.Parse(csv);

        // Assert
        Assert.Single(result);
        Assert.Equal(9999, result[0].SignalStopTime);
    }

    [Theory]
    [InlineData("40", 40)]
    [InlineData("2359", 2359)]
    [InlineData("9999", 9999)]
    public void Parse_WhenSignalStopTimeHasValue_ShouldPreserveOriginalValue(
    string csvValue,
    int expectedValue)
    {
        var parser = new MoonquakeParser();

        var csv = $"""
        Y,JD,S,E,A1,A2,A3,A4,P1,P2,P3,P4,Q1,Q2,Q3,Q4,COMMENTS,T1,N1,T2,N2,Grade,Traces,12LPX,12LPY,12LPZ,14SPZ,14LPX,14LPY,14LPZ,15SPZ,15LPX,15LPY,15LPZ,16SPZ,16LPX,16LPY,16LPZ
        69,208,2348,{csvValue},3.1,,,,,,,,5,,,,11Z AMPLITUDE,M,,M,,,,,,,,,,,,,,,,,,
        """;

        var result = parser.Parse(csv);

        Assert.Single(result);
        Assert.Equal(expectedValue, result[0].SignalStopTime);
    }

    [Fact]
    public void Parse_WhenSignalStopTimeIsEmpty_ShouldReturnNull()
    {
        // Arrange
        var parser = new MoonquakeParser();
        var csv = """
        Y,JD,S,E,A1,A2,A3,A4,P1,P2,P3,P4,Q1,Q2,Q3,Q4,COMMENTS,T1,N1,T2,N2,Grade,Traces,12LPX,12LPY,12LPZ,14SPZ,14LPX,14LPY,14LPZ,15SPZ,15LPX,15LPY,15LPZ,16SPZ,16LPX,16LPY,16LPZ
        69,208,2348,,3.1,,,,,,,,5,,,,11Z AMPLITUDE,M,,M,,,,,,,,,,,,,,,,,,
        """;
        // Act
        var result = parser.Parse(csv);
        // Assert
        Assert.Single(result);
        Assert.Null(result[0].SignalStopTime);
    }
}