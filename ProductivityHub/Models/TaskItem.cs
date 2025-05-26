using System.ComponentModel.DataAnnotations;
using ProductivityHub.Models.Database;

public class TaskItem
{
    public int Id { get; set; }
    [MaxLength(150)]
    public required string Title { get; set; }
    [MaxLength(150)]
    public required string Description { get; set; }
    public required DateTime? DueDate { get; set; }
    [MaxLength(150)]
    public required string Status { get; set; } // Offen, In Bearbeitung, Erledigt
    [MaxLength(150)]
    public required string Priority { get; set; } // Hoch, Mittel, Niedrig
    [MaxLength(150)]
    public required string UserId { get; set; }
    public int? AuthorId { get; set; }
    public Author? Author { get; set; }
}