namespace ProductivityHub.Models.Database;

public class Author
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public virtual ICollection<TaskItem> Tasks { get; set; } = [];
    public virtual ICollection<Series> Series { get; set; } = [];
    public virtual ICollection<Game> Games { get; set; } = [];
}