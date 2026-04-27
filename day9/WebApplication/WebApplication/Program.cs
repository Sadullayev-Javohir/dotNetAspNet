using MyApi.Endpoints;
using MyApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseExceptionMiddleware();
app.UseLogginMiddleware();

app.MapProductEndpoints();

app.Run();


// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleware 1 start");
//     await next();
//     // Console.WriteLine("Middleware 1 end");
// });
//
// app.Use(async (context, next) =>
// {
//     Console.WriteLine("Middleare 2 start");
//     await next();
//     Console.WriteLine("Middleware 2 end");
// });

// app.MapGet("/hello", () => "Hello World");
//
// app.MapGet("/products", () =>
// {
//     return new[]
//     {
//         new {Id = 1, Name = "Laptop"},
//         new {Id = 2, Name = "Phone"}
//     };
// });
//
// app.MapPost("/products", (Product product) =>
// {
//     return Results.Created($"products/{product.Id}", product);
// });
//
// app.MapPut("products/{id}", (int id, Product product) =>
// {
//     return Results.Ok($"Product {id} updated");
// });
//
// app.MapDelete("products/{id}", (int id) =>
// {
//     return Results.NoContent();
// });
//
// app.Use(async (context, next) =>
// {
//     var start = DateTime.UtcNow;
//     Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
//
//     await next();
//
//     var duration = DateTime.UtcNow - start;
//     Console.WriteLine($"Response: {context.Response.StatusCode} in {duration.TotalMilliseconds}");
// });
//
// app.Use(async (context, next) =>
// {
//     try
//     {
//         await next();
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine("Error: " + ex.Message);
//         context.Response.WriteAsJsonAsync(new
//         {
//             error = "Something went wrong"
//         });
//     }
// });
//
// app.MapGet("/test", () =>
// {
//     throw new Exception("Database error");
// });
//
// app.Run();
//
//
// record Product (int Id, string Name);
