using Microsoft.AspNetCore.Mvc;
using MvcExampleApp.Models;

namespace MvcExample.Controllers
{
  public class BoshqaController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Saqlash(Talaba talaba)
    {
      if (!ModelState.IsValid)
      {
        return View("Index", talaba);
      }
      return View("Natija", talaba);
    }
  }
}
