namespace ProductivityHub.Models;

public class Series
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int SeasonsWatched { get; set; }
    public int TotalSeasons { get; set; }
    public string Platform { get; set; }
    public string Status { get; set; } // z.B. "Abgeschlossen", "Läuft noch"
    public string UserId { get; set; }
}