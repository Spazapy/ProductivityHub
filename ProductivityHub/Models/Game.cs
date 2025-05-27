using System.ComponentModel.DataAnnotations;
using ProductivityHub.Models.Database;

namespace ProductivityHub.Models;

public class Game
{
    public int Id { get; set; }
    [MaxLength(150)]
    public required string Title { get; set; }
    [MaxLength(150)]
    public required string Platform { get; set; }
    [MaxLength(150)]
    public required string Genre { get; set; }
    [MaxLength(150)]
    public required int Progress { get; set; } // 0-100 %
    [MaxLength(150)]
    public required string Status { get; set; } // Ungespielt, Spiele ich, Durchgespielt
    [MaxLength(150)]
    public required string Notes { get; set; }
    [MaxLength(150)]
    public required string UserId { get; set; }
    
}