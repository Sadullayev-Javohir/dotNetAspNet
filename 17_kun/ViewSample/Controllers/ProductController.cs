using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewSample.Models;

namespace ViewSample.Controllers;

public class ProductController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Statistics()
  {
    return View();
  }
}
