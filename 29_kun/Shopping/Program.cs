using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC qo'shish
builder.Services.AddControllersWithViews();

// Session uchun kesh
builder.Services.AddDistributedMemoryCache();

// Session sozlamalari
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // sessiya muddati
    options.Cookie.HttpOnly = true;                 // faqat server orqali o'qiladi
    options.Cookie.IsEssential = true;              // GDPR uchun majburiy
});

var app = builder.Build();

// Development muhitida xatolik sahifasi
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Session ishlatish
app.UseSession();

app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cart}/{action=Index}/{id?}");

app.Run();
