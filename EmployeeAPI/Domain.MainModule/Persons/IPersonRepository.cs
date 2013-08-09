using System.Collections.Generic;
using Domain.Core;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Persons
{
    public interface IPersonRepository
    {
        Person Add(Person item);

        Person Update(Person item);

        Person Delete(int id);

        IEnumerable<Person> List();

        Person Get(int id);
    }
}
