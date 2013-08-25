using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        private readonly EmployeeApiContext _context;

        public EmployeeTypeRepository()
        {
            _context = new EmployeeApiContext();
        }

        public EmployeeType Add(EmployeeType item)
        {
            var addedItem = _context.EmployeeTypes.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public EmployeeType Update(EmployeeType item, Guid clientToken)
        {
            var itemToUpdate = _context.EmployeeTypes.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == clientToken);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public EmployeeType Delete(int id, Guid clientToken)
        {
            var itemToDelete = _context.EmployeeTypes.FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            var deletedItem = _context.EmployeeTypes.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<EmployeeType> List(Guid clientToken)
        {
            var items = _context.EmployeeTypes.Where(e => e.ClientToken == clientToken);

            return items;
        }

        public EmployeeType Get(int id, Guid clientToken)
        {
            var item = _context.EmployeeTypes.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            return item;
        }
    }
}
