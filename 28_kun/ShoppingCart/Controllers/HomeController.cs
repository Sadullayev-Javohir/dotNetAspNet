using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    // ViewBag
    ViewBag.Message = "Salom";
    var msg = ViewBag.Message;

    // TempData
    TempData["Alert"] = "Xabar saqlandi";

    // Session
    HttpContext.Session.SetString("username", "Javohir");

    return View();
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
