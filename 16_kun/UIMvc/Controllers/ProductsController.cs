using Microsoft.AspNetCore.Mvc;
using UIMvc.Models;
using System.Collections.Generic;

namespace UIMvc.Controllers;

public class ProductsController : Controller
{
  public IActionResult Index()
  {
    var products = new List<Product>
    {
      new Product { Id=1, Name="Mahsulot 1", Price=10000, ImageUrl="/images/p1.jpg", Description="Tavsif 1" },
                new Product { Id=2, Name="Mahsulot 2", Price=20000, ImageUrl="/images/p2.jpg", Description="Tavsif 2" },
    };
    return View(products);
  }
}
