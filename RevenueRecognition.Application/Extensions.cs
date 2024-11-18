
using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Domain.Factories;
using RevenueRecognition.Domain.Policies;
using RevenueRecognition.Shared;
using RevenueRecognition.Shared.Commands;

namespace RevenueRecognition.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();

        // injecting dependencies from domain in Application layer so the Domain layer stays clean
        services.AddSingleton<ICustomerFactory, CustomerFactory>();

        // injecting policies dependencies with singleton lifetime because the policies are hard coded
        services.Scan(b => b.FromAssemblies(typeof(ICustomerPolicy).Assembly)
            .AddClasses(c => c.AssignableTo<ICustomerPolicy>())
            .AsImplementedInterfaces()
            .WithSingletonLifetime());
        
        
        
        return services;
    }
}