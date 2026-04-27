using MyApi.Models;

namespace MyApi.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this WebApplication app)
    {
        // GET all products
        app.MapGet("/api/products", () =>
        {
            return new[]
            {
                new Product(1, "Laptop", 1200),
                new Product(2, "Phone", 800)
            };
        });

        // POST product
        app.MapPost("/api/products", (Product product) =>
        {
            return Results.Created($"/api/products/{product.Id}", product);
        });

        // test error
        app.MapGet("/api/error", () =>
        {
            throw new Exception("Test exception!");
        });
    }
}
