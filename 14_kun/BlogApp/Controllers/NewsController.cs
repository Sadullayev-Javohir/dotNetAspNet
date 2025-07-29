using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
  [Route("news")]
  public class NewsController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return Content("Barcha news xabarlar");
    }

    [HttpGet("{messages:alpha}")]
    public IActionResult News(string messages)
    {
      return Content($"News: news/{messages}");
    }

    [HttpGet("kunuz/{url}")]
    public IActionResult Kunuz(string url)
    {
      return Content($"Kunuz: news/kunuz/{url}");
    }


  }
}
