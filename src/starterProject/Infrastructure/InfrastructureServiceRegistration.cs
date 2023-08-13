using Application.Services.ImageService;
using Application.Adapters.ImageService;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.FileStorage.Local;
using Application.Services.FileStorageService;

namespace Application;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();
        services.AddScoped<IFileStorage, LocalFileStorage>();
        return services;
    }
}
