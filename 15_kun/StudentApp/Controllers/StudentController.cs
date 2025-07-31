using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using StudentApp.Models;
using StudentApp.ViewModels;

namespace StudentApp.Controllers;

public class StudentController : Controller
{
  private readonly IMapper _mapper;

  public StudentController(IMapper mapper)
  {
    _mapper = mapper;
  }

  public IActionResult Index()
  {
    var students = new List<Student>
    {
      new Student { Id = 1, FullName = "Ali Karimov", DateOfBirth = new DateTime(2000, 5, 12), Email = "ali@example.com", GPA = 3.2 },
      new Student { Id = 2, FullName = "Laylo Sobirova", DateOfBirth = new DateTime(2002, 11, 3), Email = "laylo@example.com", GPA = 2.1 },
    };

    var viewModels = _mapper.Map<List<StudentViewModel>>(students);

    return View(viewModels);
  }

}
