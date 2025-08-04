using Microsoft.AspNetCore.Mvc;

using BlogPost.Models;

namespace BlogPost.Controllers;

public class BlogController : Controller
{
  private static List<Blog> posts = new()
        {
          new Blog
{
    Slug = "my-travel-to-samarkand",
    Title = "My Travel to Samarkand",
    Content = "Samarkand is one of the oldest cities in the world..."
},
            new Blog
            {
                Slug = "how-to-code-in-csharp",
                Title = "How to Code in C#",
                Content = "In this article, you'll learn the basics of coding in C#..."
            },
            new Blog
            {
                Slug = "learn-aspnet-core",
                Title = "Learn ASP.NET Core",
                Content = "ASP.NET Core is a modern web framework..."
            }
        };

  [Route("you/{slang}")]
  public IActionResult ShowSlang(string slang) => Content($"Hey you said: {slang}");

  // GET: /blog/{slug}
  [Route("blog/{slug}")]
  public IActionResult Details(string slug)
  {
    var post = posts.FirstOrDefault(p => p.Slug == slug);

    if (post == null)
    {
      return NotFound(); // 404
    }

    return View(post); // Viewga model sifatida uzatamiz
  }
}
