using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

public class LatestPostsViewComponent : ViewComponent
{
  public async Task<IViewComponentResult> InvokeAsync()
  {
    var posts = new List<string>
    {
      "Post 1: ASP.NET Core Layout",
      "Post 2: Partial Views",
      "Post 3: View Components"
    };
    return View(posts);
  }
}
