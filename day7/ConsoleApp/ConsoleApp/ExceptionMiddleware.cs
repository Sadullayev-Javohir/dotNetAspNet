public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR]: {ex.Message}");

            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";

            var result = new
            {
                message = "Internal server error",
                detail = ex.Message
            };
            await context.Response.WriteAsJsonAsync(result);
        }
    }
}