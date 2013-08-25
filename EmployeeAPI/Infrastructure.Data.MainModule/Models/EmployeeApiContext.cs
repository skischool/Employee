using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infrastructure.Data.MainModule.Models.Mapping;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class EmployeeApiContext : DbContext
    {
        static EmployeeApiContext()
        {
            Database.SetInitializer<EmployeeApiContext>(null);
        }

        public EmployeeApiContext()
            : base("Name=EmployeeApiContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTitle> EmployeeTitles { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeTitleMap());
            modelBuilder.Configurations.Add(new EmployeeTypeMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
