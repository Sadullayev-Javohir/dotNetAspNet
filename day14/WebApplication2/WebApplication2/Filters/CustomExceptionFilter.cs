using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication2.Filters;

public class CustomExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        context.Result = new ObjectResult(new
        {
            message = "Interval server error"
        })
        {
            StatusCode = 500
        };
    }
}