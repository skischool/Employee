using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class Employee
    {
        public System.Guid ClientToken { get; set; }
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int LoginId { get; set; }
        public bool IsLocal { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool Current { get; set; }
        public int PersonId { get; set; }
        public string RosterId { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual EmployeeTitle EmployeeTitle { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Person Person { get; set; }
    }
}
