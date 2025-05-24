using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductivityHub.Models;

namespace ProductivityHub.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Spiele()
    {
        return View();
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