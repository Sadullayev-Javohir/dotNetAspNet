using WebApplication2.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});

var app = builder.Build();
app.MapControllers();

app.Run();