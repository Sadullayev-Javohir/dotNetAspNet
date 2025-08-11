using AutoMapper;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;
using System;

namespace ViewModelDemo.Mappings;

public class MappingProfile : Profile
{
  public MappingProfile()
  {
    CreateMap<Product, ProductViewModel>()
      .ForMember(dest => dest.CreatedDate,
      opt => opt.MapFrom(src => src.CreatedAt.ToString("yyyy-MM-dd")));

    CreateMap<ProductViewModel, Product>()
      .ForMember(dest => dest.CreatedAt,
      opt => opt.MapFrom(src => DateTime.Now));
  }
}
