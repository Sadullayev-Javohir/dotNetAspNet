var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseMiddleware<LoggingMiddleware>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/error", () =>
{
    throw new Exception("Test exception");
});

app.Run();