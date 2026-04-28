using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1;

// [ApiController]
[Route("api/products")]
public class Controllers : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] Product product)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        return Ok(product);
    }
}