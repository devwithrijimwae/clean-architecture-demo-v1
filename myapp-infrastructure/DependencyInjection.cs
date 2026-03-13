using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-V685RRL\\MSSQLSERVER01;Database=TestV1APIDb;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
