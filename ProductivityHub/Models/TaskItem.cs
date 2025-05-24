namespace ProductivityHub.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? DueDate { get; set; }
    public string Status { get; set; } // Offen, In Bearbeitung, Erledigt
    public string Priority { get; set; } // Hoch, Mittel, Niedrig
    public string UserId { get; set; }
}