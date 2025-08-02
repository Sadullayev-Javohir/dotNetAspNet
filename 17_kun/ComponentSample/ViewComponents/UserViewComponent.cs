using Microsoft.AspNetCore.Mvc;


public class UserViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    var user = new User
    {
      Name = "Javohir",
      Age = 19,
    };

    return View(user);
  }
}
