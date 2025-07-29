using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
  [Route("blog")]
  public class BlogController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return Content("Barcha postlar");
    }

    [HttpGet("{slug}")]
    public IActionResult Post(string slug)
    {
      return Content($"Post: {slug}");
    }

    [HttpGet("category/{category}")]
    public IActionResult Category(string category)
    {
      return Content($"Category: category/{category}");
    }
  }
}
