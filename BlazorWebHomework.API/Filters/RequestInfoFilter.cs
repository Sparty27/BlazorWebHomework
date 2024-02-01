using Microsoft.AspNetCore.Mvc.Filters;

namespace BlazorWebHomework.API.Filters
{
    public class RequestInfoFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Log.Information($"Request started. RequestId: {context.HttpContext.TraceIdentifier}. " +
                $"Controller: {context.Controller?.ToString()?.Split('.')[^1]}. " +
                $"Action: {context.HttpContext.Request.RouteValues["action"]}.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Log.Information($"Request finished. RequestId: {context.HttpContext.TraceIdentifier}.");
        }
    }
}
