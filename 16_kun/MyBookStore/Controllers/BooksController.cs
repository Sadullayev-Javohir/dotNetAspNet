using Microsoft.AspNetCore.Mvc;
using MyBookStore.Models;
using System.Collections.Generic;

namespace MyBookStore.Controllers;

public class BooksController : Controller
{
  public IActionResult Index()
  {
    var books = new List<Book>
    {
      new Book
                {
                    Id = 1,
                    Title = "Master va Margarita",
                    Author = "Mixail Bulgakov",
                    Price = 45000,
                    CoverImage = "/imgs/1.webp",
                    Description = "Falsafiy roman, syujetli, murakkab"
                },
                new Book
                {
                    Id = 2,
                    Title = "Yulduzli Tunlar",
                    Author = "Pirimqul Qodirov",
                    Price = 38000,
                    CoverImage = "/imgs/2.webp",
                    Description = "Tarixiy sevgi roman, Amir Temur haqida"
                },
                new Book
                {
                    Id = 3,
                    Title = "Artificial Intelligence",
                    Author = "Stuart Russell",
                    Price = 62000,
                    CoverImage = "/imgs/3.jpg",
                    Description = "AI asoslari, o‘quv qo‘llanma"
                }
    };
    return View(books);
  }
}
