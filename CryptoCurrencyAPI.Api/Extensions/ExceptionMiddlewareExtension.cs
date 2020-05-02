using CryptoCurrencyAPI.Api.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CryptoCurrencyAPI.Api.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}