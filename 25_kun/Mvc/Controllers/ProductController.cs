using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers;

public class ProductController : Controller
{
  public IActionResult Index()
  {
    var products = new List<Product>
    {
      new Product {Id = 1, Name = "Telefon", Price = 1200},
      new Product {Id = 2, Name = "Noutbuk", Price = 5500}
    };
    return View(products);
  }
}
