using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeningLoyiham.Models;

namespace MeningLoyiham.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult RedirectHere()
  {
    return RedirectToAction("Target");
  }

  public IActionResult Target()
  {
    return View();
  }

  public IActionResult GetJson()
  {
    var data = new { name = "Ali", age = 25 };
    return Json(data);
  }

  public IActionResult GetNotFound()
  {
    return NotFound("Bu sahifa topilmadi");
  }

  public IActionResult GetBadRequest()
  {
    return BadRequest("Xato so'rov");
  }

  public IActionResult CustomStatus()
  {
    return StatusCode(403, "Sizga ruxsat yo'q");
  }

  public PartialViewResult GetPartial()
  {
    return PartialView("_PartialInfo");
  }


}
