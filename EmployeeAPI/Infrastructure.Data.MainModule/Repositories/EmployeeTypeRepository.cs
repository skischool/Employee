using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Infrastructure.Data.MainModule.Contexts;
using Domain.Core;
using Domain.MainModule.Entities;
using Domain.MainModule.EmployeeTypes;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeTypeRepository()
        {
            _context = new EmployeeContext();
        }

        public EmployeeType Add(EmployeeType item)
        {
            var addedItem = _context.EmployeeTypes.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public EmployeeType Update(EmployeeType item)
        {
            var itemToUpdate = _context.EmployeeTypes.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public EmployeeType Delete(int id)
        {
            var itemToDelete = _context.EmployeeTypes.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.EmployeeTypes.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<EmployeeType> List()
        {
            var items = _context.EmployeeTypes;

            return items;
        }

        public EmployeeType Get(int id)
        {
            var item = _context.EmployeeTypes.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
