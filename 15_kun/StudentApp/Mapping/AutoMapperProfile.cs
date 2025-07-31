using AutoMapper;
using StudentApp.Models;
using StudentApp.ViewModels;

namespace StudentApp.Mapping;

public class AutoMapperProfile : Profile
{
  public AutoMapperProfile()
  {
    CreateMap<Student, StudentViewModel>()
    .ForMember(dest => dest.Age,
      opt => opt.MapFrom(src => (DateTime.Now.Year - src.DateOfBirth.Year).ToString() + " yosh"))
    .ForMember(dest => dest.GPAStatus, opt => opt.MapFrom(src => src.GPA >= 2.5 ? "Pased" : "Failed"));
  }
}
