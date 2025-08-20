using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using MyProject.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Service.AddIdentity<ApplicationUser, IdentityRole>()
.AddDefaultTokenProvider();

builder.Services.AddConrollersWithViews();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
  name: "default",
  pattern: "{Controller=Account}/{action=Index}/{id?}"
);

app.Run();
