using Microsoft.AspNetCore.Mvc;using Microsoft.AspNetCore.Identity;
using Project2.Models;
using Project2.ViewModels;


public class AccountController : Controller
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;

  public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
  {
    _userManager = userManager;
    _signInManager = signInManager;
  }

  public IActionResult Index()
  {
    var users = _userManager.Users.ToList();
    return View(users);
  }

  [HttpGet]
  public IActionResult Register() => View();

  [HttpPost]
  public async Task<IActionResult> Register(RegisterViewModel model)
  {
    if (!ModelState.IsValid) return View(model);

    var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FullName = model.FullName };
    var result = await _userManager.CreateAsync(user, model.Password);

    if (result.Succeeded)
    {
      await _signInManager.SignInAsync(user, isPersistent: false);
      return RedirectToAction("Index", "Account");
    }

    foreach (var error in result.Errors)
    {
      ModelState.AddModelError("", error.Description);
    }
    return View(model);
  }

  [HttpGet]
  public IActionResult Login() => View();

  [HttpPost]
  public async Task<IActionResult> Login(LoginViewModel model)
  {
    if (!ModelState.IsValid) return View(model);

    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

    if (result.Succeeded)
      return RedirectToAction("Index", "Account");

    ModelState.AddModelError("", "Login yoki password xato");
    return View(model);
  }

  [HttpPost]
  public async Task<IActionResult> LogOut()
  {
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index", "Home");
  }
}
