using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MapperE.Models;
using MapperE.ViewModels;

namespace MapperE.Controllers;

public class ProductController : Controller
{
  private readonly IMapper _mapper;

  public ProductController(IMapper mapper)
  {
    _mapper = mapper;
  }

  public IActionResult Index()
  {
    var product = new Product
    {
      Id = 1,
      Name = "Iphone 15 Pro",
      Price = 1599.99m,
      CreatedAt = DateTime.Now,
    };

    var viewModel = _mapper.Map<ProductViewModel>(product);
    return View(viewModel);
  }
}
