var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hey leave me alone");
app.MapGet("/info", () => new { Name = "Vali", Age = 24 });

app.Run();
