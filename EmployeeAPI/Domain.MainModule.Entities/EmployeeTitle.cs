using System;
using System.Collections.Generic;

namespace Domain.MainModule.Entities
{
    public partial class EmployeeTitle
    {
        public EmployeeTitle()
        {
            this.Employees = new List<Employee>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
