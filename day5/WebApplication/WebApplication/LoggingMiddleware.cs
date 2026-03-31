
public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Requestni log qilish
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

        // Keyingi middlewarega uzatish
        await _next(context);

        // Response statusini log qilish
        Console.WriteLine($"Response Status: {context.Response.StatusCode}");
    }
}