using Microsoft.AspNetCore.Mvc;
using CustomValidator.Models;

namespace CustomValidator.Controllers;

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
      TempData["Success"] = "Muvaffaqiyatli ro'yxatdan o'tdingiz";
      return RedirectToAction("Register");
    }

    return View(model);
  }
}
