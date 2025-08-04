using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RazorIntroApp.Models;

namespace RazorIntroApp.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    // var model = new HomeViewModel
    // {
    //   Title = "Bosh sahifa (Model orqali)",
    //   Message = "Xabar Model orqali uzatiladi"
    // };

    ViewData["Hey"] = "Salom bu hey xabari";
    ViewData["User"] = new User { Name = "Ali", Age = 25 };
    return View();
  }
}
