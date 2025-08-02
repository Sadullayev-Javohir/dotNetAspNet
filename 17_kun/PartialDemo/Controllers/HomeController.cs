using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialDemo.Models;

namespace PartialDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    var user = new UserCard
    {
      Name = "Olimjon Tursunov",
      Job = "Full-Stack Dasturchi",
      ImageUrl = "https://picsum.photos/300"
    };
        return View(user);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
