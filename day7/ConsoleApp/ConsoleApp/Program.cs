var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<ExceptionMiddleware>();

app.MapGet("/", () => "Hello World!");

app.MapGet("error", () =>
{
    throw new Exception("Test Exception");
});

app.Run();