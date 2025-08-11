var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET /
app.MapGet("/", () => "Salom, ASP.NET Core!");

// GET /api/hello
app.MapGet("/api/hello", () => new { Message = "Hello from API" });

// POST /api/data
app.MapPost("/api/data", (MyData data) =>
{
    return new { Received = data };
});

app.Run();

record MyData(string Name, int Age);
