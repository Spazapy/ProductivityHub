using Microsoft.EntityFrameworkCore;

namespace ProductivityHub.Models.Database;

public class ProductivityHubDataBase : DbContext
{
    public ProductivityHubDataBase(DbContextOptions<ProductivityHubDataBase> options) : base(options)
    {
        
    }

    public DbSet<Game> Games { get; set; }
    public DbSet<Series> Series { get; set; }
    public DbSet<TaskItem> TaskItems { get; set; }
    
}