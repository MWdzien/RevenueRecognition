using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Abstractions.Queries;
using RevenueRecognition.Shared.Commands;

namespace RevenueRecognition.Shared.Queries;

public static class Extensions
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();
        
        services.AddSingleton<IQueryDispatcher, QueryDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}
