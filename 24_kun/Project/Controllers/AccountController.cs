using Microsoft.AspNetCore.Mvc;
using Project.Models;

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
    if (!ModelState.IsValid)
    {
      return View(model);
    }

    return RedirectToAction("Success");
  }

  public IActionResult Success()
  {
    return View();
  }
}
