namespace MyApi.Middleware;

public static class ExceptionMiddleware
{
  public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
  {
    return app.Use(async (context, next) =>
    {
      try
      {
        await next();
      }
      catch(Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync(new
        {
          error = "Internal Server Error",
          message = ex.Message
        });
      }
    });
  }
}
