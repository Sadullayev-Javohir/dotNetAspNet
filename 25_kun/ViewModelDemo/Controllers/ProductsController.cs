using Microsoft.AspNetCore.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace ViewModelDemo.Controllers;

public class ProductsController : Controller
{
  private static List<Product> _products = new List<Product>
{
  new Product { Id = 1, Name = "Laptop", Price = 1500, CreatedAt = DateTime.UtcNow },
  new Product { Id = 2, Name = "Mouse", Price = 20, CreatedAt = DateTime.UtcNow }
};

  private readonly IMapper _mapper;

  public ProductsController(IMapper mapper)
  {
    _mapper = mapper;
  }

  public IActionResult Index()
  {
    var vmList = _mapper.Map<List<ProductViewModel>>(_products);
    return View(vmList);
  }

  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Create(ProductViewModel vm)
  {
    if (!ModelState.IsValid) return View(vm);

    var product = _mapper.Map<Product>(vm);
    product.Id = _products.Max(p => p.Id) + 1;
    _products.Add(product);

    return RedirectToAction(nameof(Index));
  }
}
