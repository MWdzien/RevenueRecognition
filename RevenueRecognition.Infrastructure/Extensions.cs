using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Infrastructure.EF;
using RevenueRecognition.Infrastructure.EF.Options;
using RevenueRecognition.Infrastructure.Logging;
using RevenueRecognition.Shared.Abstractions.Commands;
using RevenueRecognition.Shared.Options;
using RevenueRecognition.Shared.Queries;

namespace RevenueRecognition.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddPostgres(configuration);
        services.AddQueries();

        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>)); 
        return services;
    }
}