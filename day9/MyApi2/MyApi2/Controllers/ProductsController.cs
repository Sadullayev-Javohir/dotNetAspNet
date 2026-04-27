using Microsoft.AspNetCore.Mvc;
using MyApi2.Models;

namespace MyApi2.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new()
    {
        new Product() {Id = 1, Name = "Laptop"},
        new Product() {Id = 2, Name="Phone"},
        new Product() {Id = 3, Name = "Laptop 2"}
    };
    
    // Get all
    [HttpGet]
    public ActionResult<List<Product>> GetAll() => Ok(products);
    
    // GET by route
    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] int id)
    {
        var product = products.FirstOrDefault(x => x.Id == id);
        return (product == null) ? NotFound() : Ok(product);
    }
    
    // Get by query
    [HttpGet("search")]
    public ActionResult<List<Product>> Search(string name)
    {
        var result = products.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        return Ok(result);
    }
    
    // POST body binding
    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    } 
    [HttpPost("something")]
    public ActionResult<Product> Create2(Product product)
    {
        products.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    } 
}