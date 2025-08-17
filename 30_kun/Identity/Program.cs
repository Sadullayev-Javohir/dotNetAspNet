using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Identity.Data;
using Identity.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔹 DB ulash (SQL Server)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 Identity qo‘shish (foydalanuvchi va rollar bilan)
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>() // DB konteksti orqali ishlaydi
    .AddDefaultTokenProviders(); // email tasdiqlash va boshqa tokenlar uchun

// 🔹 Cookie sozlamalari
builder.Services.ConfigureApplicationCookie(options =>
{
  options.LoginPath = "/Account/Login"; // login qilmagan foydalanuvchi shu yerga yo'naltiriladi
  options.LogoutPath = "/Account/Logout";
  options.AccessDeniedPath = "/Account/AccessDenied";
});

// 🔹 MVC qo‘shish
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 🔹 Middlewarelar
app.UseStaticFiles();       // wwwroot ichidagi css/js ishlashi uchun
app.UseRouting();           // marshrutlash
app.UseAuthentication();    // login/logout uchun
app.UseAuthorization();     // rollar va huquqlar uchun

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
