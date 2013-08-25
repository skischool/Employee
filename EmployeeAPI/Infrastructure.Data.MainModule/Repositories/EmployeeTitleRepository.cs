using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeTitleRepository : IEmployeeTitleRepository
    {
        private readonly EmployeeApiContext _context;

        public EmployeeTitleRepository()
        {
            _context = new EmployeeApiContext();
        }

        public EmployeeTitle Add(EmployeeTitle item)
        {
            var addedItem = _context.EmployeeTitles.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public EmployeeTitle Update(EmployeeTitle item, Guid clientToken)
        {
            var itemToUpdate = _context.EmployeeTitles.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == clientToken);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public EmployeeTitle Delete(int id, Guid clientToken)
        {
            var itemToDelete = _context.EmployeeTitles.FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            var deletedItem = _context.EmployeeTitles.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<EmployeeTitle> List(Guid clientToken)
        {
            var items = _context.EmployeeTitles.Where(e => e.ClientToken == clientToken);

            return items;
        }

        public EmployeeTitle Get(int id, Guid clientToken)
        {
            var item = _context.EmployeeTitles.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            return item;
        }
    }
}
