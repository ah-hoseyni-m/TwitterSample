using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System.Net.Http;

namespace Twitter.Clone.Settings.ExceptionHandler;

public static class CustomExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
    }
}
public class CustomExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IHostEnvironment _hostEnvironment;
    private readonly ILogger<CustomExceptionHandlerMiddleware> _logger;


    public CustomExceptionHandlerMiddleware(RequestDelegate Next, ILogger<CustomExceptionHandlerMiddleware> logger, IHostEnvironment hostEnvironment)
    {
        _next = Next;
        _logger = logger;
        _hostEnvironment = hostEnvironment;
    }
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            if (_hostEnvironment.IsDevelopment())
            {
                //await context.Response.WriteAsync(ex.Message.ToString());
                await context.Response.WriteAsync(ex.Message);
            }
            else { await context.Response.WriteAsync("خطای غیر منتظره"); }


        }


    }
}