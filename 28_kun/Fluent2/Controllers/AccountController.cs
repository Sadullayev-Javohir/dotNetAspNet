using Microsoft.AspNetCore.Mvc;
using Fluent2.Models;

namespace Fluent2.Controllers;

public class AccountController : Controller
{
  [HttpGet]
  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Regiseter(RegisterViewModel model)
  {
    if (ModelState.IsValid)
    {
      TempData["Success"] = "Muvaffaqiyatli ro'yxatdan o'tdingiz";
      return RedirectToAction("Register");
    }

    return View(model);
  }
}
