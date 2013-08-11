using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Domain.MainModule.Entities;
using Infrastructure.Data.MainModule.Models;
using Infrastructure.Data.MainModule.Models.Mapping;

namespace Infrastructure.Data.MainModule.Contexts
{
    public partial class EmployeeContext : DbContext
    {
        static EmployeeContext()
        {
            Database.SetInitializer<EmployeeContext>(null);
        }

        public EmployeeContext()
            : base("Name=EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<EmployeeTitle> EmployeeTitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeTypeMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new EmployeeTitleMap());
        }
    }
}
