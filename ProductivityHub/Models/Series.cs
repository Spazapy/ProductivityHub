using System.ComponentModel.DataAnnotations;
using ProductivityHub.Models.Database;

namespace ProductivityHub.Models;

public class Series
{
    public int Id { get; set; }
    [MaxLength(150)]
    public required string Title { get; set; }
    public required int SeasonsWatched { get; set; }
    public required int TotalSeasons { get; set; }
    [MaxLength(150)]
    public required string Platform { get; set; }
    [MaxLength(150)]
    public required string Status { get; set; } 
    [MaxLength(150)]
    public required string UserId { get; set; }
    public int? AuthorId { get; set; }
    public Author? Author { get; set; }
}