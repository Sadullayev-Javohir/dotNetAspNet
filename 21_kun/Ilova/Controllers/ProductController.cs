using AutoMapper;
using Ilova.Models;
using Ilova.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ilova.Controllers;

[ApiController]
[Route("[Controller]")]
public class ProductController : ControllerBase
{
  private readonly IMapper _mapper;

  public ProductController(IMapper mapper)
  {
    _mapper = mapper;
  }

  [HttpGet]
  public ActionResult<ProductViewModel> Get()
  {
    var product = new Product
    {
      Id = 1,
      Name = "Gaming Laptop",
      Price = 1585.25m,
      Description = "High performance laptop"
    };

    var viewModel = _mapper.Map<ProductViewModel>(product);
    return Ok(viewModel);
  }
}
