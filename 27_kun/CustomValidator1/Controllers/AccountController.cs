using Microsoft.AspNetCore.Mvc;
using CustomValidator1.Models;

namespace CustomValidator1.Controllers;

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
      TempData["Successs"] = "Muvaffaqiyatli ro'yxatdan o'tdingiz";
      return RedirectToAction("Register");
    }
    return View(model);
  }
}
