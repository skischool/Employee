using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Persons
{
    public class PersonService : IPersonService
    {
    	readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Add(Person item)
        {
            return _repository.Add(item);
        }

        public Person Update(Person item)
        {
            return _repository.Update(item);
        }

        public Person Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Person Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Person> List()
        {
            return _repository.List();
        }
    }
}
