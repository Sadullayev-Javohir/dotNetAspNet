public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"[REQUEST] {context.Request.Method} {context.Request.Path}");
        await _next(context);
        Console.WriteLine($"[RESPONSE] Status: {context.Response.StatusCode}");
    }
}