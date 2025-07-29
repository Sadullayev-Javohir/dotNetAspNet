using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MyApp.Models;
using MyApp.ViewModels;

namespace MyApp.Controllers
{
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
        Name = "Notebook",
        Price = 759.99m,
        Description = "Powerful laptop"
      };

      var viewModel = _mapper.Map<ProductViewModel>(product);

      return View(viewModel);
    }
  }
}
