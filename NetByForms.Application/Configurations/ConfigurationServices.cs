using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NetByForms.Application.Configurations
{
    public static class ConfigurationServices
    {
        public static IServiceCollection ConfigureAppServices(this IServiceCollection services)
        {
            _ = services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            _ = services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
