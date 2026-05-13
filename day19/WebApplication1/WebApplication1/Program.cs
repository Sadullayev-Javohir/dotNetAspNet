var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();
app.MapControllers();

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();

    logger.LogInformation(
        "Request: {Method} {Url}",
        context.Request.Method,
        context.Request.Path);
        
        await next();
});

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();

    var start = DateTime.UtcNow;
    await next();
    var end = DateTime.UtcNow;

    var ms = (end - start).TotalMilliseconds;
    
    logger.LogInformation(
        "Request time: {Time} ms", ms);
});

app.MapGet("/", (ILogger<Program> logger) =>
{
    logger.LogInformation("Minimal Api ishladi");
    return "Hello";
});

app.Run();

