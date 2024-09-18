using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Calculator.Api.Filters;

public class GlobalActionFilter : IActionFilter
{


    public void OnActionExecuting(ActionExecutingContext context){}

    public void OnActionExecuted(ActionExecutedContext context)
    {
        context.Result = new ObjectResult(new 
        {
            success = true,
            data = new
            {
                result = (context.Result as ObjectResult)?.Value
            }
        });
        
    }
}