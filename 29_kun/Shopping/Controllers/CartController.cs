using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
    var product = new Product { Id = id, Name = name, Price = price };

    var cartItem = cart.FirstOrDefault(c => c.Product.Id == id);

    if (cartItem != null)
    {
      cartItem.Quantity++;
    }
    else
    {
      cart.Add(new CartItem { Product = product, Quantity = 1 });
    }

    SaveCart(cart);
    TempData["Message"] = "Mahsulot savatchaga qo'shildi";
    return RedirectToAction("Index");
  }

  private List<CartItem> GetCart()
  {
    var sessionCart = HttpContext.Session.GetString("Cart");
    if (sessionCart != null)
    {
      return JsonConvert.DeserializeObject<List<CartItem>>(sessionCart);
    }
    return new List<CartItem>();
  }

  private void SaveCart(List<CartItem> cart)
  {
    HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
  }
}
