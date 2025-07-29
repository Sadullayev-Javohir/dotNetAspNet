using Microsoft.AspNetCore.Mvc;

namespace CrudApp.Controllers
{
  public class ProductController : Controller
  {
    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
      ViewBag.ProductId = id;
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(string name)
    {
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      ViewBag.ProductId = id;
      return View();
    }

    [HttpPost]
    public IActionResult Edit(int id, string name)
    {
      // Mahsulotni yangilash
      return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      ViewBag.ProductId = id;
      return View();
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
      return RedirectToAction("Index");
    }
  }
}
