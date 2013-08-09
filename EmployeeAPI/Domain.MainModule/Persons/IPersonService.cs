using System.Collections.Generic;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Persons
{
    public interface IPersonService
    {
        Person Add(Person item);

        Person Update(Person item);

        Person Delete(int id);

        Person Get(int id);

        IEnumerable<Person> List();
    }
}
