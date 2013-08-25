using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class Person
    {
        public Person()
        {
            this.Employees = new List<Employee>();
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int GenderId { get; set; }
        public System.Guid ClientToken { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
