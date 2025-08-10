using Microsoft.AspNetCore.Mvc;
using File.Models;
namespace File.Controllers;

public class AccountController : Controller
{
  [HttpGet]
  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Register(RegisterViewModel model)
  {
    if (ModelState.IsValid)
    {
      return RedirectToAction("Success");
    }
    return View(model);
  }

  public IActionResult Success()
  {
    return View();
  }
}
