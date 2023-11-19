using FoodGame.Features.FoodManagement.Services;

namespace FoodGame.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IFoodService, FoodService>();

        return services;
    }
}