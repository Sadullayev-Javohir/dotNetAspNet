using Microsoft.AspNetCore.Mvc;
using MvcBasicApp.Models;

namespace MvcBasicApp.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Form()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Form(UserForm model)
  {
    if (ModelState.IsValid)
    {
      ViewBag.Message = $"Xush kelibsiz, {model.Name}";
    }
    return View(model);
  }
}
