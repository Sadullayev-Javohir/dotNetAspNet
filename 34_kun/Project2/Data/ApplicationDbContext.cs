using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Project2.Models;


namespace Project2.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
