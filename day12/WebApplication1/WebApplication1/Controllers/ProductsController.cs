using Microsoft.AspNetCore.Mvc;
using MyApi.Filters;
using WebApplication1.Models;
using WebApplication1.Filters;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/products")]
[LogActionFilter]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new List<Product>()
    {
        new Product() {Id = 1, Name = "Laptop"},
        new Product() {Id = 2, Name = "Phone"}
    };

    [HttpGet]
    [CustomAuthFilter]
    public IActionResult GetAll() => Ok(products);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        return (product == null) ? NotFound() : Ok(product);
    }

    [HttpGet("error")]
    public IActionResult Error() => throw new Exception("Test exception");
}