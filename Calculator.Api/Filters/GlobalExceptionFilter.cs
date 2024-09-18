using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Crud.Api.Filters;

public class GlobalExceptionFilter : IExceptionFilter

{
    public void OnException(ExceptionContext context)
    {
        var statusCode = context.Result switch
        {
            BadRequestObjectResult => 400,
            NotFoundObjectResult => 404,
            _ => 500
        };
        context.Result = new ObjectResult(new
        {
            success = false,
        })
        {
            StatusCode = statusCode
        };
    }
}