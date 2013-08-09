using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Infrastructure.Data.MainModule.Contexts;
using Domain.Core;
using Domain.MainModule.Entities;
using Domain.MainModule.Employees;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeContext();
        }

        public Employee Add(Employee item)
        {
            var addedItem = _context.Employees.Add(item);

            _context.SaveChanges();

            return addedItem;
        }

        public Employee Update(Employee item)
        {
            var itemToUpdate = _context.Employees.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate = item;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Employee Delete(int id)
        {
            var itemToDelete = _context.Employees.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.Employees.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Employee> List()
        {
            var items = _context.Employees;

            return items;
        }

        public Employee Get(int id)
        {
            var item = _context.Employees.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
