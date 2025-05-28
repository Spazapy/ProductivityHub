namespace ProductivityHub.Models;

public class SearchResults
{
    public IEnumerable<Game> Games { get; set; }
    public IEnumerable<Series> Series { get; set; }
    public IEnumerable<TaskItem> Tasks { get; set; }
}