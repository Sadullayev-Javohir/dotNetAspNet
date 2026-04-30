using Microsoft.AspNetCore.Mvc;
using WebApplication2.Filters;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

[ApiController]
[Route("api/products")]
[LogActionFilter]
public class ProductsController : ControllerBase
{
    private static List<Product> _products = new()
    {
        new Product() {Id = 1, Name = "Laptop"},
        new Product() {Id = 2, Name = "Phone"}
    };

    [HttpGet]
    [CustomAuthFilter]
    public IActionResult GetAll() => Ok(_products);
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _products.FirstOrDefault(x => x.Id == id);

        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpGet("error")]
    public IActionResult Error() => throw new Exception("Test exception");
}