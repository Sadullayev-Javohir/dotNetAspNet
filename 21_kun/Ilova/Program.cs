using Ilova.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(ProductProfile));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
  name: "default",
  pattern: "{Controller=Home}/{Action=Index}/{id?}"
);

app.Run();
