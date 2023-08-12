using Application.Services.ImageService;
using Application.Adapters.ImageService;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();
        return services;
    }
}
