using Microsoft.AspNetCore.Mvc;

namespace MvcExampleApp.Controllers
{
  public class ProductController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Details(int id)
    {
      ViewBag.ProductId = id;
      return View();
    }
  }
}
