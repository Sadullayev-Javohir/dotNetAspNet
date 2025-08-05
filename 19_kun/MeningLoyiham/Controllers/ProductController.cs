using Microsoft.AspNetCore.Mvc;
using MeningLoyiham.Models;
using System.Collections.Generic;
using System.Linq;

namespace MeningLoyiham.Controllers;

public class ProductController : Controller
{
  private static List<Product> products = new List<Product>();

  public IActionResult Index()
  {
    return View(products);
  }

  public IActionResult Details(int id)
  {
    var product = products.FirstOrDefault(p => p.Id == id);
    return View(product);
  }

  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Create(Product product)
  {
    product.Id = products.Count + 1;
    products.Add(product);
    return RedirectToAction("Index");
  }

  public IActionResult Edit(int id)
  {
    var product = products.FirstOrDefault(p => p.Id == id);
    return View(product);
  }

  [HttpPost]
  public IActionResult Edit(Product updateProduct)
  {
    var product = products.FirstOrDefault(p => p.Id == updateProduct.Id);
    product.Name = updateProduct.Name;
    product.Price = updateProduct.Price;
    return RedirectToAction("Index");
  }

  public IActionResult Delete(int id)
  {
    var product = products.FirstOrDefault(p => p.Id == id);
    return View(product);
  }

  [HttpPost, ActionName("Delete")]
  public IActionResult DeleteConfirmed(int id)
  {
    var product = products.FirstOrDefault(p => p.Id == id);
    products.Remove(product);
    return RedirectToAction("Index");
  }


}
