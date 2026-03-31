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
            
            Console.WriteLine($"Xatolik: {ex.Message}");

            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(
                System.Text.Json.JsonSerializer.Serialize(new
                {
                    StatusCode = 500,
                    Message = ex.Message
                }));
        }
    }
}