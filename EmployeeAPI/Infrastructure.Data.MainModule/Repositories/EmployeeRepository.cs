using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeApiContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeApiContext();
        }

        public Employee Add(Employee item)
        {
            var addedItem = _context.Employees.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Employee Update(Employee item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToUpdate = _context.Employees.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

            itemToUpdate.ClientToken = item.ClientToken;

            itemToUpdate.Current = item.Current;

            itemToUpdate.EmployeeTypeId = item.EmployeeTypeId;

            itemToUpdate.IsLocal = item.IsLocal;

            itemToUpdate.LoginId = item.LoginId;

            itemToUpdate.PersonId = item.PersonId;

            itemToUpdate.RosterId = item.RosterId;

            itemToUpdate.TitleId = item.TitleId;

            itemToUpdate.Id = item.Id;

            itemToUpdate.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Employee Delete(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var itemToDelete = _context.Employees.FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            var deletedItem = _context.Employees.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Employee> List(string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var items = _context.Employees.Where(e => e.ClientToken == guid);

            return items;
        }

        public Employee Get(int id, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.Employees.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == guid);

            return item;
        }
    }
}
