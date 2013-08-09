using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.MainModule.Entities;

namespace Infrastructure.Data.MainModule.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.RosterId)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.LoginId).HasColumnName("LoginId");
            this.Property(t => t.IsLocal).HasColumnName("IsLocal");
            this.Property(t => t.EmployeeTypeId).HasColumnName("EmployeeTypeId");
            this.Property(t => t.Current).HasColumnName("Current");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.RosterId).HasColumnName("RosterId");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.EmployeeType)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.EmployeeTypeId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.PersonId);
            this.HasRequired(t => t.Title)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.TitleId);

        }
    }
}
