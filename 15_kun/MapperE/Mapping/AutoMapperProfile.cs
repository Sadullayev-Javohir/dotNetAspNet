using AutoMapper;
using MapperE.Models;
using MapperE.ViewModels;

namespace MapperE.Mapping;

public class AutoMapperProfile : Profile
{
  public AutoMapperProfile()
  {
    CreateMap<Product, ProductViewModel>().ForMember(dest => dest.PriceWithCurrency, opt => opt.MapFrom(src => $"${src.Price:N2}"));
  }
}
