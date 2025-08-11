using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers;

public class BlogController : Controller
{
  [Route("blog/{year:int}/{month:int}/{slug}")]
  public IActionResult Details(int year, int month, string slug)
  {
    ViewBag.Year = year;
    ViewBag.Month = month;
    ViewBag.Slug = slug;
    return View();
  }
}
