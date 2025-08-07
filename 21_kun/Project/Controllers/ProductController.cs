using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.ViewModels;

namespace Project.Controllers;

public class ProductController : ControllerBase
{
  private readonly IMapper _mapper;

  public ProductController(IMapper mapper)
  {
    _mapper = mapper;
  }

  [HttpGet]
  public IActionResult GetProduct()
  {
    var product = new Product
    {
      Id = 1,
      Name = "Laptop",
      Price = 1500,
      Description = "Gaming Laptop"
    };

    var viewModel = _mapper.Map<ProductViewModel>(product);
    return Ok(viewModel);

  }
}
