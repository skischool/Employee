using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedServices.Entities.Dto
{
    public class Employee
    {
        public int ClientId { get; set; }
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int LoginId { get; set; }
        public bool IsLocal { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool Current { get; set; }
        public int PersonId { get; set; }
        public string RosterId { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Person Person { get; set; }
        public virtual EmployeeTitle Title { get; set; }
    }
}
