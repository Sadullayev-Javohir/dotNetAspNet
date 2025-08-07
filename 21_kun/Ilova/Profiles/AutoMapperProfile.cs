using AutoMapper;
using Ilova.Models;
using Ilova.ViewModels;

namespace Ilova.Profiles;

public class ProductProfile : Profile
{
  public ProductProfile()
  {
    CreateMap<Product, ProductViewModel>()
      .ForMember(dest => dest.PriceFormatted,
        opt => opt.MapFrom(src => $"${src.Price:F2}"));
  }
}
