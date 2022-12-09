
using $safeprojectname$.Services;
using $safeprojectname$.Views.Pages;

namespace $safeprojectname$.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<INavigationService, NavigationService>();

        return services;    
    }

    public static IServiceCollection RegisterPages(this IServiceCollection services)
    {
        services.AddSingleton<HomePage>();

        return services;
    }

    public static IServiceCollection RegisterViewModels(this IServiceCollection services)
    {
        services.AddSingleton<HomeViewModel>();

        return services;
    }
}
