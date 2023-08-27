using Application.Services.ImageService;
using Application.Adapters.ImageService;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.FileStorage.Local;
using Application.Services.FileStorageService;
using Application.Services.InvoiceFileService;
using Infrastructure.PdfGenerator;

namespace Application;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();
        services.AddScoped<IFileStorage, LocalFileStorage>();
        services.AddScoped<IPdfGenerator, PdfGenerator>();
        return services;
    }
}
