using MoonquakeExplorer.Domain.Entities;

public class MoonquakeParser : IMoonquakeParser
{
    public List<Moonquake> Parse(string csv)
    {
        try
        {
            var moonquakes = new List<Moonquake>();
            var lines = csv.Split('\n');
            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var fields = line.Split(',');
                var moonquake = new Moonquake
                {
                    Year = int.TryParse(fields[0], out var year) ? year : (int?)null,
                    JulianDay = int.TryParse(fields[1], out var julianDay) ? julianDay : (int?)null,
                    SignalStartTime = int.TryParse(fields[2], out var signalStartTime) ? signalStartTime : (int?)null,
                    SignalStopTime = int.TryParse(fields[3], out var signalStopTime) ? signalStopTime : (int?)null,
                    AmplitudeApollo11_12 = double.TryParse(fields[4], out var amplitudeApollo11_12) ? amplitudeApollo11_12 : (double?)null,
                    AmplitudeApollo14 = double.TryParse(fields[5], out var amplitudeApollo14) ? amplitudeApollo14 : (double?)null,
                    AmplitudeApollo15 = double.TryParse(fields[6], out var amplitudeApollo15) ? amplitudeApollo15 : (double?)null,
                    AmplitudeApollo16 = double.TryParse(fields[7], out var amplitudeApollo16) ? amplitudeApollo16 : (double?)null,
                    PlotAvailabilityApollo11_12 = int.TryParse(fields[8], out var plotAvailabilityApollo11_12) ? plotAvailabilityApollo11_12 : (int?)null,
                    PlotAvailabilityApollo14 = int.TryParse(fields[9], out var plotAvailabilityApollo14) ? plotAvailabilityApollo14 : (int?)null,
                    PlotAvailabilityApollo15 = int.TryParse(fields[10], out var plotAvailabilityApollo15) ? plotAvailabilityApollo15 : (int?)null,
                    PlotAvailabilityApollo16 = int.TryParse(fields[11], out var plotAvailabilityApollo16) ? plotAvailabilityApollo16 : (int?)null,
                    DataQualityApollo11_12 = int.TryParse(fields[12], out var dataQualityApollo11_12) ? dataQualityApollo11_12 : (int?)null,
                    DataQualityApollo14 = int.TryParse(fields[13], out var dataQualityApollo14) ? dataQualityApollo14 : (int?)null,
                    DataQualityApollo15 = int.TryParse(fields[14], out var dataQualityApollo15) ? dataQualityApollo15 : (int?)null,
                    DataQualityApollo16 = int.TryParse(fields[15], out var dataQualityApollo16) ? dataQualityApollo16 : (int?)null,
                    Comments = fields[16],
                    OriginalEventType = fields[17],
                    OriginalClusterNumber = int.TryParse(fields[18], out var originalClusterNumber) ? originalClusterNumber : (int?)null,
                    EventType = fields[19],
                    ClusterNumber = int.TryParse(fields[20], out var clusterNumber) ? clusterNumber : (int?)null,
                    Grade = fields[21],
                    Traces = int.TryParse(fields[22], out var traces) ? traces : (int?)null,
                    Apollo12Lpx = int.TryParse(fields[23], out var apollo12Lpx) ? apollo12Lpx : (int?)null,
                    Apollo12Lpy = int.TryParse(fields[24], out var apollo12Lpy) ? apollo12Lpy : (int?)null,
                    Apollo12Lpz = int.TryParse(fields[25], out var apollo12Lpz) ? apollo12Lpz : (int?)null,
                    Apollo14Spz = int.TryParse(fields[26], out var apollo14Spz) ? apollo14Spz : (int?)null,
                    Apollo14Lpx = int.TryParse(fields[27], out var apollo14Lpx) ? apollo14Lpx : (int?)null,
                    Apollo14Lpy = int.TryParse(fields[28], out var apollo14Lpy) ? apollo14Lpy : (int?)null,
                    Apollo14Lpz = int.TryParse(fields[29], out var apollo14Lpz) ? apollo14Lpz : (int?)null,
                    Apollo15Spz = int.TryParse(fields[30], out var apollo15Spz) ? apollo15Spz : (int?)null,
                    Apollo15Lpx = int.TryParse(fields[31], out var apollo15Lpx) ? apollo15Lpx : (int?)null,
                    Apollo15Lpy = int.TryParse(fields[32], out var apollo15Lpy) ? apollo15Lpy : (int?)null,
                    Apollo15Lpz = int.TryParse(fields[33], out var apollo15Lpz) ? apollo15Lpz : (int?)null,
                    Apollo16Spz = int.TryParse(fields[34], out var apollo16Spz) ? apollo16Spz : (int?)null,
                    Apollo16Lpx = int.TryParse(fields[35], out var apollo16Lpx) ? apollo16Lpx : (int?)null,
                    Apollo16Lpy = int.TryParse(fields[36], out var apollo16Lpy) ? apollo16Lpy : (int?)null,
                    Apollo16Lpz = int.TryParse(fields[37], out var apollo16Lpz) ? apollo16Lpz : (int?)null
                };
                moonquakes.Add(moonquake);
            }
            return moonquakes;
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to parse moonquake CSV data.", ex);
        }


    }
}