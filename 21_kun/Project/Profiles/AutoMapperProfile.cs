using AutoMapper;
using Project.Models;
using Project.ViewModels;

namespace Project.Profiles;

public class AutoMapperProfile : Profile
{
  public AutoMapperProfile()
  {
    CreateMap<Product, ProductViewModel>()
      .ForMember(dest => dest.PriceFormatted,
        opt => opt.MapFrom(src => $"{src.Price:F2}"));
  }
}
