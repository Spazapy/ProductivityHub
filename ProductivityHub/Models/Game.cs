namespace ProductivityHub.Models;

public class Game
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Platform { get; set; }
    public string Genre { get; set; }
    public int Progress { get; set; } // 0-100 %
    public string Status { get; set; } // Ungespielt, Spiele ich, Durchgespielt
    public string Notes { get; set; }
    public string UserId { get; set; }
}