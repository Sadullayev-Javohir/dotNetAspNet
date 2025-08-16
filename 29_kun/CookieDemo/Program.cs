using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
  await context.Response.WriteAsync(
    "<h2>Cookie misoli</h2>" +
    "<a href='/set'>Cookie yaratish</a><br>" +
    "<a href='/get'>Cookie o'qish</a><br>" +
    "<a href='/delete'>Cookie o'chirish</a><br>"
  );
});


// Cookie yaratish
app.MapGet("/set", async context =>
{
  CookieOptions option = new CookieOptions
  {
    Expires = DateTime.Now.AddMinutes(1)
  };
  context.Response.Cookies.Append("UserEmail", "ali@gmail.com", option);

  await context.Response.WriteAsync("Cookie yaratildi: UserEmail=ali@gmail.com");
});

// Cookie o'qish
app.MapGet("/get", async context =>
{
  string email = context.Request.Cookies["UserEmail"] ?? "Cookie topilmadi";
  await context.Response.WriteAsync($"Cookie qiymati: {email}");
});

// Cookie o'chirish
app.MapGet("/delete", async context =>
{
  context.Response.Cookies.Delete("UserEmail");
  await context.Response.WriteAsync("Cookie o'chirildi");
});

app.Run();
