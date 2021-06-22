using Microsoft.EntityFrameworkCore;
using NetCoreApplicationRepository.Data.Services;


namespace NetCoreApplicationRepository.db
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
