using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using System.Text.Json;

namespace ShoppingCart.Controllers;

public class CartController : Controller
{
  public IActionResult Index()
  {
    var cart = GetCart();
    return View(cart);
  }

  public IActionResult AddToCart(int id, string name, decimal price)
  {
    var cart = GetCart();
    var item = cart.FirstOrDefault(c => c.ProductId == id);

    if (item == null)
    {
      cart.Add(new CartItem { ProductId = id, ProductName = name, Price = price, Quantity = 1 });
    }
    else
    {
      item.Quantity++;
    }

    SaveCart(cart);
    return RedirectToAction("Index");
  }

  private List<CartItem> GetCart()
  {
    var sessionData = HttpContext.Session.GetString("cart");
    if (sessionData == null)
    {
      return new List<CartItem>();
    }
    return JsonSerializer.Deserialize<List<CartItem>>(sessionData);
  }

  private void SaveCart(List<CartItem> cart)
  {
    HttpContext.Session.SetString("cart", JsonSerializer.Serialize(cart));
  }
}
