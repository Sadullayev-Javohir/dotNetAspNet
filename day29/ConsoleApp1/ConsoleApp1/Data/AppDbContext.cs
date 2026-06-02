using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Models;
namespace ConsoleApp1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<User> Users { get; set; }
}