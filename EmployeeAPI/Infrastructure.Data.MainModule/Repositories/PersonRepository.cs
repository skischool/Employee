using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Infrastructure.Data.MainModule.Contexts;
using Domain.Core;
using Domain.MainModule.Entities;
using Domain.MainModule.Persons;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly EmployeeContext _context;

        public PersonRepository()
        {
            _context = new EmployeeContext();
        }

        public Person Add(Person item)
        {
            var addedItem = _context.Persons.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Person Update(Person item)
        {
            var itemToUpdate = _context.Persons.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.FirstName = item.FirstName;

            itemToUpdate.LastName = item.LastName;

            itemToUpdate.MiddleName = item.MiddleName;

            itemToUpdate.DateOfBirth = item.DateOfBirth;

            itemToUpdate.GenderId = item.GenderId;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Person Delete(int id)
        {
            var itemToDelete = _context.Persons.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.Persons.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Person> List()
        {
            var items = _context.Persons;

            return items;
        }

        public Person Get(int id)
        {
            var item = _context.Persons.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
