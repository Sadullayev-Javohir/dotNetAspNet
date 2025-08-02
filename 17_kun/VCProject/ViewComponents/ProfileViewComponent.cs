using Microsoft.AspNetCore.Mvc;

public class ProfileViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    var user = new User
    {
      Name = "Ali",
      Age = 25,
    };

    return View(user);
  }
}
