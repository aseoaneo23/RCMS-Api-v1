using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace RCMS.WebApi.AuthMiddleware;

public class ApiKeyAuthMiddleware(RequestDelegate next, IConfiguration configuration)
{
    public async Task InvokeAsync(HttpContext context)
    {
        if(!context.Request.Headers.TryGetValue(AuthConstants.ApiKeyHeaderName, 
               out var extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API Key is missing");
            return;
        }
        
        var apiKey = configuration.GetValue<string>(AuthConstants.ApiKeySectionName) ?? "EF3D0BF7ADDA478481B4CBE4B3E130C5";
        
        if (string.IsNullOrEmpty(apiKey))
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("API Key no está configurada");
            return;
        }
        
        if (!apiKey.Equals(extractedApiKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("API Key is incorrect.");
            return;
        }
        
        await next(context);
    }
}