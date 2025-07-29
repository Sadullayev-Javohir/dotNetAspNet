using AutoMapper;
using MyApp.Models;
using MyApp.ViewModels;

namespace MyApp.MappingProfiles
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Product, ProductViewModel>();
    }
  }
}
