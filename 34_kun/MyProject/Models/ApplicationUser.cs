using Microsoft.AspNetCore.Identity;

namespace MyProject.Models;

public class ApplicationUser : IdentityUser
{
  public string FullName { get; set; }
}
