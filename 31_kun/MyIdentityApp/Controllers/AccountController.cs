using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyIdentityApp.Models;

namespace MyIdentityApp.Controllers
{
  public class AccountController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager; // User yaratish, update, delete
    private readonly SignInManager<ApplicationUser> _signInManager; // Login/Logout boshqaruvi

    public AccountController(UserManager<ApplicationUser> userManager,
      SignInManager<ApplicationUser> signInManager)
    {
      _userManager = userManager;
      _signInManager = signInManager;
    }

    // Register GET -> formani ko'rsatish
    public IActionResult Register() => View();

    // Register POST -> foydalanuvchini DB ga yozish
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
      if (ModelState.IsValid) // validation o'tsa
      {
        // Yangi foydalanuvchi yaratamiz
        var user = new ApplicationUser
        {
          UserName = model.Email, // Identity uchun UserName odatda email bo'ladi
          Email = model.Email,
          FullName = model.FullName
        };

        // Userni DB ga yozamiz (parol ham qo'shiladi)
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded) // hammasi muvaffaqiyatli bo'lsa
        {
          // Yaratilgan userni tizimga avtomatik login qilamiz
          await _signInManager.SignInAsync(user, isPersistent: false);
          return RedirectToAction("Index", "Home");
        }

        // Agar xatolik bo'lsa (masalan, parol juda oddiy)
        foreach (var error in result.Errors)
          ModelState.AddModelError("", error.Description);
      }
      return View(model); // Agar validation o'tmasa -> formani qaytaradi
    }

    // Login GET -> formani ko'rsatish
    public IActionResult Login() => View();

    // Login POST -> tizimga kirishni tekshirish
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
      if (ModelState.IsValid) // validation o'tsa
      {
        // Userning email va paroli to'g'ri ekanligini tekshiramiz
        var result = await _signInManager.PasswordSignInAsync(
            model.Email, model.Password, model.RememberMe, false);

        if (result.Succeeded) // muvaffaqiyatli bo'lsa
          return RedirectToAction("Index", "Home");

        // noto'g'ri bo'lsa
        ModelState.AddModelError("", "Login yoki parol noto‘g‘ri!");
      }
      return View(model);
    }

    // Logout -> tizimdan chiqish
    public async Task<IActionResult> Logout()
    {
      await _signInManager.SignOutAsync(); // cookie o'chiriladi
      return RedirectToAction("Index", "Home");
    }
  }
}
