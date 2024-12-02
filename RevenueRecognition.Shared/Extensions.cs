using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Shared.Services;

namespace RevenueRecognition.Shared;

public static class Extensions
{
    public static IServiceCollection AddShared(this IServiceCollection services)
    {
        services.AddHostedService<AppInitializer>();
        return services;
    }
}