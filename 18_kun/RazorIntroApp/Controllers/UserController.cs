using Microsoft.AspNetCore.Mvc;
using RazorIntroApp.Models;

namespace RazorIntroApp.Controllers;

public class UserController : Controller
{
  public IActionResult Index()
  {
    ViewData["User"] = new User { Name = "Ali", Age = 25 };
    // ViewData["Message"] = "Salom, bu ViewData orqali uzatildi";
    return View();
  }
}
