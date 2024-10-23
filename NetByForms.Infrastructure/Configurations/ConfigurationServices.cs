using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Extensions.Interfaces;
using NetByForms.Infrastructure.Repository.Interfaces;
using System.Reflection;

namespace NetByForms.Infrastructure.Configurations
{
    public static class ConfigurationServices
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            _ = services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            _ = services.AddAutoMapper(Assembly.GetExecutingAssembly());
            _ = services.AddScoped(typeof(IRepositoryRead<>), typeof(RepositoryRead<>));
            _ = services.AddScoped(typeof(IRepositoryWrite<>), typeof(RepositoryWrite<>));
            _ = services.AddScoped<IFormRepositoryRead, FormRepositoryRead>();
            _ = services.AddScoped<IFormRepositoryWrite, FormRepositoryWrite>();
            _ = services.AddScoped<IFormInputOptionRepositoryRead, FormInputOptionRepositoryRead>();
            _ = services.AddScoped<IFormInputOptionRepositoryWrite, FormInputOptionRepositoryWrite>();
            _ = services.AddScoped<IFormInputRepositoryRead, FormInputRepositoryRead>();
            _ = services.AddScoped<IFormInputRepositoryWrite, FormInputRepositoryWrite>();
            return services;

        }
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
