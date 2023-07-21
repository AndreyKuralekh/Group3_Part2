using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HW1_Cars_Controller
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware_GetCarName
    {
        private readonly RequestDelegate _next;

        public Middleware_GetCarName(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Middleware_GetCarNameExtensions
    {
        public static IApplicationBuilder UseMiddleware_GetCarName(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware_GetCarName>();
        }
    }
}
