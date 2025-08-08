using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ProductListViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    var products = new List<string> { "Olma", "Banan", "Gilos" };
    return View(products);
  }
}
