using Microsoft.Extensions.DependencyInjection;

namespace TrainCloud.Uic;

public static class UicNumberServiceExtensions
{
    public static IServiceCollection AddUicNumberService(this IServiceCollection services)
    {
        services.AddScoped<IUicNumberService, UicNumberService>();

        return services;
    }
}
