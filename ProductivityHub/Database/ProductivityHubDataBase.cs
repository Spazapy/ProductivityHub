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
    public DbSet<Author> Authors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasOne(g => g.Author).WithMany(a => a.Games).HasForeignKey(a => a.AuthorId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TaskItem>().HasOne(g => g.Author).WithMany(a => a.Tasks).HasForeignKey(a => a.AuthorId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Series>().HasOne(g => g.Author).WithMany(a => a.Series).HasForeignKey(a => a.AuthorId).OnDelete(DeleteBehavior.Restrict);
    }
}