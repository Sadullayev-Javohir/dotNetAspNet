var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
  name: "default",
  pattern: "{controller=Product}/{action=Index}/{id?}"
);

app.Run();
