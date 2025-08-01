using Microsoft.AspNetCore.Mvc;
using MyStoreApp.Models;
using System.Collections.Generic;

namespace MyStoreApp.Controllers;

public class ProductsController : Controller
{
  public IActionResult Index()
  {
    var products = new List<Product>
    {
                new Product
                {
                    Id = 1,
                    Name = "Smartfon",
                    Price = 2500000,
                    ImageUrl = "/img/phone.jpg",
                    Description = "Android smartfon, 128GB"
                },
                new Product
                {
                    Id = 2,
                    Name = "Quloqchin",
                    Price = 450000,
                    ImageUrl = "/img/headphone.jpeg",
                    Description = "Bluetooth quloqchin"
                },
                new Product
                {
                    Id = 3,
                    Name = "Smart Soat",
                    Price = 890000,
                    ImageUrl = "/img/watch.jpg",
                    Description = "Yurak urishini o‘lchovchi smart soat"
                }
    };
    return View(products);
  }
}
