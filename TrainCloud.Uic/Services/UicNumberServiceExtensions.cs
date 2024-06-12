using Microsoft.Extensions.DependencyInjection;

namespace TrainCloud.Uic.Services;

/// <summary>
/// Extension methods for setting up IUicNumberService in an Microsoft.Extensions.DependencyInjection.IServiceCollection.
/// </summary>
public static class UicNumberServiceExtensions
{
    /// <summary>
    /// Adds IUicNumberService to the IServiceCollection for usage in the TrainCloud Application/Microservices
    /// </summary>
    /// <param name="services">The Microsoft.Extensions.DependencyInjection.IServiceCollection to add services to.</param>
    /// <returns>The Microsoft.Extensions.DependencyInjection.IServiceCollection so that additional calls can be chained.</returns>
    public static IServiceCollection AddUicNumberService(this IServiceCollection services)
    {
        services.AddTransient<IUicNumberService, UicNumberService>();

        return services;
    }
}
