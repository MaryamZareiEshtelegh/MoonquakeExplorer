using MoonquakeExplorer.Data.Models;
using MoonquakeExplorer.Domain.Entities;
using MoonquakeExplorer.Domain.Enums;
using MoonquakeExplorer.Domain.ValueObjects;

namespace MoonquakeExplorer.Data.Mapping;

public class MoonquakeMapper
{
    private DateTime? BuildDateTime(int? year, int? julianDay, int? time)
    {
        if (year is null || julianDay is null || time is null)
            return null;

        var fullYear = 1900 + year.Value;
        var date = new DateTime(fullYear, 1, 1)
            .AddDays(julianDay.Value - 1);

        var hour = time.Value / 100;
        var minute = time.Value % 100;

        //if (hour == 99 && minute == 99 || time.Value == 9999)
        //{
             //throw new ArgumentOutOfRangeException("Invalid time value.");
       // }
        return DateTime.SpecifyKind(
        date.AddHours(hour).AddMinutes(minute),
        DateTimeKind.Utc);
        
      
    }
    public MoonquakeRecord Map(Moonquake moonquake)
    {
        var signalStartedAt = BuildDateTime(moonquake.Year, moonquake.JulianDay,moonquake.SignalStartTime);
        var signalStoppedAt = BuildDateTime(moonquake.Year, moonquake.JulianDay, moonquake.SignalStopTime);
        if (signalStartedAt.HasValue &&
            signalStoppedAt.HasValue &&
            signalStoppedAt.Value < signalStartedAt.Value)
        {
            signalStoppedAt = signalStoppedAt.Value.AddDays(1);
        }
        return new MoonquakeRecord
        {
            Year = moonquake.Year,
            JulianDay = moonquake.JulianDay,
            SignalStartTime = moonquake.SignalStartTime,
            SignalStopTime = moonquake.SignalStopTime,
            AmplitudeApollo11_12 = moonquake.AmplitudeApollo11_12,
            AmplitudeApollo14 = moonquake.AmplitudeApollo14,
            AmplitudeApollo15 = moonquake.AmplitudeApollo15,
            AmplitudeApollo16 = moonquake.AmplitudeApollo16,
            PlotAvailabilityApollo11_12 = moonquake.PlotAvailabilityApollo11_12,
            PlotAvailabilityApollo14 = moonquake.PlotAvailabilityApollo14,
            PlotAvailabilityApollo15 = moonquake.PlotAvailabilityApollo15,
            PlotAvailabilityApollo16 = moonquake.PlotAvailabilityApollo16,
            DataQualityApollo11_12 = moonquake.DataQualityApollo11_12,
            DataQualityApollo14 = moonquake.DataQualityApollo14,
            DataQualityApollo15 = moonquake.DataQualityApollo15,
            DataQualityApollo16 = moonquake.DataQualityApollo16,
            Comments = moonquake.Comments,
            OriginalEventType = moonquake.OriginalEventType,
            OriginalClusterNumber = moonquake.OriginalClusterNumber,
            EventType = moonquake.EventType,
            ClusterNumber = moonquake.ClusterNumber,
            Grade = moonquake.Grade,
            Traces = moonquake.Traces,
            Apollo12Lpx = moonquake.Apollo12Lpx,
            Apollo12Lpy = moonquake.Apollo12Lpy,
            Apollo12Lpz = moonquake.Apollo12Lpz,
            Apollo14Spz = moonquake.Apollo14Spz,
            Apollo14Lpx = moonquake.Apollo14Lpx,
            Apollo14Lpy = moonquake.Apollo14Lpy,
            Apollo14Lpz = moonquake.Apollo14Lpz,
            Apollo15Spz = moonquake.Apollo15Spz,
            Apollo15Lpx = moonquake.Apollo15Lpx,
            Apollo15Lpy = moonquake.Apollo15Lpy,
            Apollo15Lpz = moonquake.Apollo15Lpz,
            Apollo16Spz = moonquake.Apollo16Spz,
            Apollo16Lpx = moonquake.Apollo16Lpx,
            Apollo16Lpy = moonquake.Apollo16Lpy,
            Apollo16Lpz = moonquake.Apollo16Lpz,
            OccurredAt =  signalStartedAt,
            SignalStartedAt = signalStartedAt,
            SignalStoppedAt = signalStoppedAt
        };
    }
}
