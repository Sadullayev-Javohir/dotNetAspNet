using WebApplication1.Filters;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});

var app = builder.Build();

app.MapControllers();
app.Run();