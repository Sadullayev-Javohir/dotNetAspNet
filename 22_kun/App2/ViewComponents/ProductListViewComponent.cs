using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App2.ViewComponents;

public class ProductListViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    var products = new List<string> { "Olma", "Uzum", "Nok", "Shaftoli" };
    return View(products);
  }
}
