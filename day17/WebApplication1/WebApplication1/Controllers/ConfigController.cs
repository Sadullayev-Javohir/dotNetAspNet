using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication1.Models;


namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConfigController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly AppSettings _settings;
    public ConfigController(IConfiguration configuration, IOptions<AppSettings> options) 
    {
        _configuration = configuration;
        _settings = options.Value;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var siteName = _configuration["AppSettings:SiteName"];
        var version = _configuration["AppSettings:Version"];
        var environment = _configuration["AppSettings:Environment"];
        // return Ok(new
        // {
        //     SiteName = siteName,
        //     Version = version,
        //     Environment = environment
        // });
        var host = _configuration["EmailSettings:Host"];
        return Ok(host);


        // var siteName = _configuration["AppSettings:SiteName"];
        // var information = _configuration["Logging:LogLevel:Default"];
        // int age = _configuration.GetValue<int>("UserSettings:Age");
        // return Ok( new {Age = age});

        // var siteName = _configuration["AppSettings:SiteName"];
        // var version = _configuration["AppSettings:Version"];
        // var section = _configuration.GetConnectionString("DefaultConnection");
        // return Ok(new { defaultConnection = section });
        // var siteName = section["SiteName"];
        // var version = section["Version"];
        // return Ok(new { SiteName = siteName, Version = version });

    }

}