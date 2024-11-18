using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Shared.Queries;

namespace RevenueRecognition.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddQueries();
        return services;
    }
}