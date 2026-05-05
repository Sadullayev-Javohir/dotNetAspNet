using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication2.Filters;

public class LogActionFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Action boshlanmoqda....");
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("Action tugadi...");
    }
}