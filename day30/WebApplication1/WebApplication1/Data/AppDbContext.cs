using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // 🟢 DbSet = Table
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .ToTable("students");

        modelBuilder.Entity<Student>()
            .Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}