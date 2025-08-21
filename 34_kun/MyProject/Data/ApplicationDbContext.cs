using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyProject.Models;


namespace MyProject.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
}
