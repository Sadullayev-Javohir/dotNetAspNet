using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new List<Product>
    {
        new Product() {Id = 1, Name = "Phone"},
        new Product() {Id = 2, Name = "Laptop"}
    };

    /// <summary>
    /// Hamma Productlarni qaytaradi
    /// </summary>
    [HttpGet]
    public IActionResult Search(string name)
    {
        return Ok(name);
    }
    // public IActionResult GetAll() => Ok(products);

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        return (product == null) ? NotFound() : Ok(product);
    }
    [HttpPost]
    public IActionResult Create(Product product)
    {
        products.Add(product);
        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        var existing = products.FirstOrDefault(x => x.Id == id);
        if (existing == null) return NotFound();
        existing.Name = product.Name;
        return Ok(existing);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        if (product == null) return NotFound();

        products.Remove(product);
        return Ok();
    }
}