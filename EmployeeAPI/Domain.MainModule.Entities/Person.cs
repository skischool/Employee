using System;
using System.Collections.Generic;

namespace Domain.MainModule.Entities
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
        public int GenderId { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
