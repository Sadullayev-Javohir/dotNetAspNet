using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
  options.IdleTimeout = TimeSpan.FromMinutes(10);
  options.Cookie.HttpOnly = true;
  options.Cookie.IsEssential = true;
  options.Cookie.SecurePolicy = CookieSecurePolicy.None;
});

var app = builder.Build();
app.UseSession();

app.MapGet("/", async context =>
{
  int count = context.Session.GetInt32("Count") ?? 0;
  count++;
  context.Session.SetInt32("Count", count);

  await context.Response.WriteAsync(
    $"Siz bu sahifani {count} marta ochdingiz. <br>" + $"Session ID cookie brauzerda: {context.Request.Cookies[".AspNetCore.Session"] ?? "yo'q"}"
  );
});

app.Run();
