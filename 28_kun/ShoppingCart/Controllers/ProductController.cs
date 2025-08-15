using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers;

public class ProductController : Controller
{
  public IActionResult Index()
  {
    var products = new List<Product>
    {
      new Product {Id = 1, Name = "Telefon", Price = 300},
      new Product {Id = 2, Name = "Noutbuk", Price = 800},
      new Product {Id = 3, Name = "Sichqoncha", Price = 20}
    };
    return View(products);
  }
}
