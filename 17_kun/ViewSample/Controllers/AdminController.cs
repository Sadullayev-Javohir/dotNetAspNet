using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ViewSample.Controllers;

public class AdminController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}
