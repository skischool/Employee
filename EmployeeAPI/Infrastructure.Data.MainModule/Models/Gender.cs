using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class Gender
    {
        public Gender()
        {
            this.Persons = new List<Person>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.Guid ClientToken { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
