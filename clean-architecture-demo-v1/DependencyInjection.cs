using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using myapp_application;
using myapp_infrastructure;

namespace clean_architecture_demo_v1
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                    .AddInfrastructureDI();

            return services;
        }
    }
}