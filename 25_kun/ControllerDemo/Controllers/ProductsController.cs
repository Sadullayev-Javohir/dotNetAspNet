using Microsoft.AspNetCore.Mvc;
using ControllerDemo.Models;
using System.Linq;
using System.Collections.Generic;

namespace ControllerDemo.Controllers;

public class ProductsController : Controller
{
  private static List<Product> _products = new List<Product>()
  {
    new Product {Id = 1, Name = "Laptop", Price = 1500},
    new Product {Id = 2, Name = "Mouse", Price = 25}
  };

  [HttpGet]
  public IActionResult Index()
  {
    return View(_products);
  }

  [HttpGet]
  public IActionResult Details(int id)
  {
    var product = _products.FirstOrDefault(p => p.Id == id);
    if (product == null) return NotFound();
    return View(product);
  }

  [HttpGet]
  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Create(Product product)
  {
    product.Id = _products.Max(p => p.Id) + 1;
    _products.Add(product);
    return RedirectToAction(nameof(Index));
  }

  [HttpGet]
  public IActionResult Edit(int id)
  {
    var product = _products.FirstOrDefault(p => p.Id == id);
    if (product == null) return NotFound();
    return View(product);
  }

  [HttpPost]
  public IActionResult Edit(Product updateProduct)
  {
    var product = _products.FirstOrDefault(p => p.Id == updateProduct.Id);
    if (product == null) return NotFound();

    product.Name = updateProduct.Name;
    product.Price = updateProduct.Price;

    return RedirectToAction(nameof(Index));
  }

  [HttpPost]
  public IActionResult Delete(int Id)
  {
    var product = _products.FirstOrDefault(p => p.Id == Id);

    if (product != null)
    {
      _products.Remove(product);
    }
    return RedirectToAction("Index");
  }
}
