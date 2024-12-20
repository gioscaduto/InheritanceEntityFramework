using InheritanceEntityFramework.Data;
using InheritanceEntityFramework.Repositories;
using InheritanceEntityFramework.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InheritanceEntityFramework.Configurations;

public static class DependencyInjectionConfig
{
    public static IServiceCollection ResolveDependencies(this IServiceCollection services)
    {
        services.AddScoped<AppDbContext>();

        services.AddScoped<IVehicleService, VehicleService>();
        services.AddScoped<IVehicleRepository, VehicleRepository>();

        return services;
    }
}
