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