using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers;

public class ProductController : Controller
{
  [HttpGet]
  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Create(Product model)
  {
    if (ModelState.IsValid)
    {
      ViewBag.Message = "Mahsulot muvaffaqiyatli qo'shildi";
    }
    return View(model);
  }
}
