using Microsoft.EntityFrameworkCore;
using myapp_domain.Entities;

namespace myapp_infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}