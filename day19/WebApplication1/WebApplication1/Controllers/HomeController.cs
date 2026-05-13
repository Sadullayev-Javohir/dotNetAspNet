using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger) => _logger = logger;

    // [HttpGet]
    // public IActionResult Get()
    // {
    //     // Eng mayda loglar
    //     _logger.LogTrace("1. Trace log");
    //     
    //     // Development uchun
    //     _logger.LogDebug("2. Debug log");
    //     
    //     // Oddiy ma'lumotlar
    //     _logger.LogInformation("3. User login qildi");
    //     
    //     // Muammo bo'lishi mumkin
    //     _logger.LogWarning("4. Token expire bo'lishiga oz qoldi");
    //     
    //     // Xato yuz berdi
    //     _logger.LogError("5. Database ishlamadi");
    //     
    //     // Juda katta xato
    //     _logger.LogCritical("Server yiqildi");
    //     
    //     return Ok("success");
    // }
}