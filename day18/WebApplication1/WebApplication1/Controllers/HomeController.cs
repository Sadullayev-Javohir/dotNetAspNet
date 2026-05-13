using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    private readonly IAppService _appService;
    public HomeController(IAppService appService) => _appService = appService;

    [HttpGet("/")]
    public IActionResult Index() => Ok(_appService.GetSiteInfo());
}
