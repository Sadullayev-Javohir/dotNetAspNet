using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
  [HttpGet]
  public IActionResult Register() => View();

  [HttpPost]
  public IActionResult Register(RegisterViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }

    return RedirectToAction("Success");
  }

  public IActionResult Success() => Content("Ro'yxatdan o'tish muvaffaqiyatli ");
}
