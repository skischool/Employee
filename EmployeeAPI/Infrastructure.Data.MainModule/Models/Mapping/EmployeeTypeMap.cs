using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.MainModule.Entities;

namespace Infrastructure.Data.MainModule.Models.Mapping
{
    public class EmployeeTypeMap : EntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EmployeeTypes");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
