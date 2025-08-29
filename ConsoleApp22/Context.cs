using Microsoft.EntityFrameworkCore;
namespace ConsoleApp22
{
    internal class Context :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<EmployeeDepartment> employeeDepartments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder./*UseLazyLoadingProxies().*/UseSqlServer("server =. ; database = IT ; Trusted_Connection = true ; TrustServerCertificate = true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>().HasDiscriminator<string>("EmployeeType").HasValue<FullTimeEmployee>("FTE");

            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>().HasDiscriminator<string>("EmployeeType").HasValue<PartTimeEmployee>("PTE");


            modelBuilder.Entity<EmployeeDepartment>().HasNoKey().ToView("EmployeeDepartmentView");
        }
    }
}
