using ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration cf;

        public AppDbContext(IConfiguration cf)
        {
            this.cf = cf;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cf.GetConnectionString("Connection"));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
