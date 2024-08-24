namespace CodingTrackerLibrary.Models;

internal class CodingSession
{
    public static string[] headers = { "id", "startDate", "endDate", "duration", "units" };
    public int? id { get; set; }
    public string? startDate { get; set; }
    public string? endDate { get; set; }
    public float? duration { get; set; }
    public string? units { get; set; } 

    public CodingSession(int id, string startDate, string endDate, float duration)
    {
        this.id = id; 
        this.startDate = startDate; 
        this.endDate = endDate;
        this.duration = duration;
    }

    public CodingSession(int id, string startDate, string endDate, float duration, string units)
    {
        this.id = id;
        this.startDate = startDate;
        this.endDate = endDate;
        this.duration = duration;
        this.units = units;
    }

    public CodingSession(string startDate, string endDate, float duration)
    {
        this.startDate = startDate;
        this.endDate = endDate;
        this.duration = duration;
    }

    public CodingSession(string startDate)
    {
        this.startDate = startDate;
    }

    public CodingSession(int id)
    {
        this.id = id;
    }
}