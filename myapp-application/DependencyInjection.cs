using Microsoft.Extensions.DependencyInjection;

namespace myapp_application
{
  public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
            {
                services.AddApplicationDI()
                    .AddIfrastructureDI();
                return services;
        }
  }
}
