using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp1.Middleware
{
    public class GlobalException
    {
        private RequestDelegate _next;
        private ILogger<GlobalException> _logger;

        public GlobalException(RequestDelegate next, ILogger<GlobalException> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                switch (ex.GetType())
                {
                    case Type t when t == typeof(NotFound):
                        context.Response.StatusCode = 404;
                        await context.Response.WriteAsync("Not Found: " + ex.Message);
                        break;
                    case Type t when t == typeof(Conflict):
                        context.Response.StatusCode = 409;
                        await context.Response.WriteAsync("Conflict: " + ex.Message);
                        break;
                    default:
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("Internal Server Error: " + ex.Message);
                        break;
                }
            }
        }
    }
}
