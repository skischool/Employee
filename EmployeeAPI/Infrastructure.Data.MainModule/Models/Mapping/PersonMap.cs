using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.MainModule.Entities;

namespace Infrastructure.Data.MainModule.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Gender)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Persons");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
