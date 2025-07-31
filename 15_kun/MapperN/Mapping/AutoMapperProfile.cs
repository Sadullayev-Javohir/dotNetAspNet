using AutoMapper;
using MapperN.ViewModels;
using MapperN.Models;

namespace MapperN.Mapping;

public class AutoMapperProfile : Profile
{
  public AutoMapperProfile()
  {
    CreateMap<Product, ProductViewModel>().ForMember(dest => dest.PriceWithCurrency, opt => opt.MapFrom(src => $"${src.Price:N2}"));
  }
}
