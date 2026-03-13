using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using myapp_domain.Interfaces;
using myapp_infrastructure.Data;
using myapp_infrastructure.Repository;
using System;

namespace myapp_infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>((provider, options) =>
            {
                var configuration = provider.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                options.UseSqlServer(
                    connectionString,
                    sql => sql.MigrationsAssembly("myapp-infrastructure") // <-- THIS FIXES IT
                );
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}