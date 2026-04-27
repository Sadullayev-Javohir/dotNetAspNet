namespace MyApi.Middleware;

public static class LoggingMiddleware
{
  public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder app)
  {
    return app.Use(async (context, next) =>
    {
      var start = DateTime.UtcNow;
      Console.WriteLine($"{context.Request.Method} {context.Request.Path}");
      await next();

      var duration = DateTime.UtcNow - start;
      Console.WriteLine($"{context.Response.StatusCode} | {duration.TotalMilliseconds}");
    });
  }
}
