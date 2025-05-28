using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductivityHub.Models;
using ProductivityHub.Models.Database;

namespace ProductivityHub.Controllers;

public class HomeController : Controller
{
    private ProductivityHubDataBase _db;

    public HomeController(ProductivityHubDataBase db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Search(string word)
    {
        var games = _db.Games;
        var series = _db.Series;
        var tasks = _db.TaskItems;
        var searchgames = from m in games select m;
        var searchseries = from m in series select m;
        var searchtasks = from m in tasks select m;

        if (!String.IsNullOrEmpty(word))
        {
            var lowerWord = word.ToLower();
            searchgames = searchgames.Where(s => s.Title.Contains(lowerWord)
                                                 || s.Platform.Contains(lowerWord)
                                                 || s.Genre.Contains(lowerWord)
                                                 || s.Notes.Contains(lowerWord)
                                                 || s.Status.Contains(lowerWord)
                                                 || s.UserId.Contains(lowerWord));
            searchseries = searchseries.Where(s => s.Title.Contains(lowerWord)
                                                   || s.Platform.Contains(lowerWord)
                                                   || s.Status.Contains(lowerWord)
                                                   || s.UserId.Contains(lowerWord));
            searchtasks = searchtasks.Where(s => s.Title.Contains(lowerWord)
                                                 || s.Description.Contains(lowerWord)
                                                 || s.Status.Contains(lowerWord)
                                                 || s.Priority.Contains(lowerWord)
                                                 || s.UserId.Contains(lowerWord));
            var viewModel = new SearchResults
            {
                Games = searchgames.ToList(),   // Materialize query results
                Series = searchseries.ToList(), // Materialize query results
                Tasks = searchtasks.ToList()    // Materialize query results
            };
            return View(viewModel);   
        }
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }
    public IActionResult Spiele()
    {
        var games = _db.Games;
        return View(games);
    }

    public IActionResult Serien()
    {
        return View();
    }

    public IActionResult Aufgaben()
    {
        return View();
    }
}