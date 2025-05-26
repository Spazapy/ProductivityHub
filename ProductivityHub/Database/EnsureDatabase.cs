using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProductivityHub.Models;
using ProductivityHub.Models.Database;

namespace ProductivityHub.Database;

public class EnsureDatabase
{
    public static void ExecuteMigrations(IApplicationBuilder app)
    {
        var _ctx = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ProductivityHubDataBase>();
        if (_ctx.Database.GetPendingMigrations().Any())
        {
            _ctx.Database.Migrate();
        }
    }

    public static void SeedDatabase(IApplicationBuilder app)
    {
        var _ctx = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ProductivityHubDataBase>();
        if (!_ctx.Authors.Any())
        {
            _ctx.Authors.AddRange(
                new Author()
                {
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Author()
                {
                    FirstName = "Marcel",
                    LastName = "Test"
                });
            _ctx.SaveChanges();
        }

        if (!_ctx.Games.Any())
        {
            _ctx.Games.AddRange(
                new Game()
                {
                    Title = "Game 1",
                    Platform = "Xbox One",
                    Genre = "Hack'n'Slay",
                    Progress= 10,
                    Status = "Started",
                    Notes = "Very hard",
                    UserId = "Marcel",
                    AuthorId = _ctx.Authors.FirstOrDefault(a => a.FirstName == "John")!.Id
                });
            _ctx.SaveChanges();
        }
        if (!_ctx.Series.Any())
        {
            _ctx.Series.AddRange(
                new Series()
                {
                    Title = "Series 1",
                    SeasonsWatched = 2,
                    Platform = "Netflix",
                    TotalSeasons = 15,
                    Status = "Started",
                    UserId = "Marcel",
                    AuthorId = _ctx.Authors.FirstOrDefault(a => a.FirstName == "John")!.Id
                    
                });
            _ctx.SaveChanges();
        }
        if (!_ctx.TaskItems.Any())
        {
            _ctx.TaskItems.AddRange(
                new TaskItem()
                {
                    Title = "John",
                    Description = "Doe",
                    DueDate = (DateTime.Now),
                    Status = "Started",
                    UserId = "Marcel",
                    Priority = "high",
                    AuthorId = _ctx.Authors.FirstOrDefault(a => a.FirstName == "John")!.Id
                    
                });
            _ctx.SaveChanges();
        }
    }
}