using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Product product) => Ok(product);
}