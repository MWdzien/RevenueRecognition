using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RevenueRecognition.Application.Services;
using RevenueRecognition.Domain.Repositories;
using RevenueRecognition.Infrastructure.EF.Contexts;
using RevenueRecognition.Infrastructure.EF.Options;
using RevenueRecognition.Infrastructure.EF.Repositories;
using RevenueRecognition.Infrastructure.EF.Services;
using RevenueRecognition.Shared.Options;

namespace RevenueRecognition.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICustomerRepository, PostgresCustomerRepository>();
        services.AddScoped<ICustomerReadService, PostgresCustomerReadService>();
        
        var options = configuration.GetOptions<PostgresOptions>("Postgres");

        services.AddDbContext<ReadDbContext>(c => c.UseNpgsql(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(c => c.UseNpgsql(options.ConnectionString));
        
        return services;
    }
}