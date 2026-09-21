namespace MoonquakeExplorer.Data.Models;
public class NasaMoonquakeDto
{
    public int Y { get; set; }
    public int JD { get; set; }
    public int S { get; set; }
    public int E { get; set; }

    public double? A1 { get; set; }
    public double? A2 { get; set; }
    public double? A3 { get; set; }
    public double? A4 { get; set; }

    public string? T1 { get; set; }
    public int? N1 { get; set; }

    public string? T2 { get; set; }
    public int? N2 { get; set; }

    public string? Grade { get; set; }
    public int? Traces { get; set; }
}