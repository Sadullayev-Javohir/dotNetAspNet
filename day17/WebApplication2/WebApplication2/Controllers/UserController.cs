using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService _userService)
    {
        this._userService = _userService;
    }
    // GetAll
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }
    
    // Create
    [HttpPost]
    public IActionResult Create(Users user)
    {
        return Ok(_userService.Create(new Users() {Name = user.Name}));
    }
    
    // Delete
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok(_userService.Delete(id));
    }
    
    // Update
    [HttpPut]
    public IActionResult Update(Users updatedUser)
    {
        var result = _userService.Update(updatedUser);
        return Ok(result);
    }
}