using System.Text.Json;
using Microsoft.AspNetCore.Http;
using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Shared.Exceptions;

internal sealed class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (RevenueRecognitionException e)
        {
            context.Response.StatusCode = 400;
            context.Response.ContentType = "application/json";

            var errorCode = ToUnderscoreCase(e.GetType().Name.Replace("Exception", string.Empty));
            var json = JsonSerializer.Serialize(new { ErrorCode = errorCode, e.Message });
            await context.Response.WriteAsync(json);
        }
    }
    
    public static string ToUnderscoreCase(string str)
        => string.Concat((str ?? string.Empty).Select((x, i) => i > 0 && i < str.Length - 1 && char.IsUpper(x) && !char.IsUpper(str[i-1]) ? $"_{x}" : x.ToString())).ToLower();
    
}