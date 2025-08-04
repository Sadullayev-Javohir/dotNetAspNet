using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentForm.Models;

namespace StudentForm.Controllers;

public class HomeController : Controller
{
  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Register(Student s)
  {
    ViewBag.Name = s.FullName;
    ViewBag.Age = s.Age;
    return View();
  }
}
