using Microsoft.AspNetCore.Mvc;
using CustomValidation.Models;

namespace CustomValidation.Controllers;

public class AccountController : Controller
{
  [HttpGet]
  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Register(RegisterModel model)
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
