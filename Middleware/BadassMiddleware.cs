using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace PizzaToDo.Middleware
{
    public class BadassMiddleware
    {
        private readonly RequestDelegate _next;

        public BadassMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.HasFormContentType && context.Request.Form.Any() && context.Request.Form.Select(pair => string.Join(" ", pair.Value)).Contains("hack"))
            {
                context.Response.ContentType = "text/html";
                context.Response.Redirect("/Home/Badass");
            }

            await _next(context);
        }
    }

    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseBadass(this IApplicationBuilder app)
        {
            return app.UseMiddleware<BadassMiddleware>();
        }
    }
}