using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Infrastructure.Data.MainModule.Contexts;
using Domain.Core;
using Domain.MainModule.Entities;
using Domain.MainModule.EmployeeTitles;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeTitleRepository : IEmployeeTitleRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeTitleRepository()
        {
            _context = new EmployeeContext();
        }

        public EmployeeTitle Add(EmployeeTitle item)
        {
            var addedItem = _context.EmployeeTitles.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public EmployeeTitle Update(EmployeeTitle item)
        {
            var itemToUpdate = _context.EmployeeTitles.FirstOrDefault(b => b.Id == item.Id);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public EmployeeTitle Delete(int id)
        {
            var itemToDelete = _context.EmployeeTitles.FirstOrDefault(b => b.Id == id);

            var deletedItem = _context.EmployeeTitles.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<EmployeeTitle> List()
        {
            var items = _context.EmployeeTitles;

            return items;
        }

        public EmployeeTitle Get(int id)
        {
            var item = _context.EmployeeTitles.ToList().FirstOrDefault(b => b.Id == id);

            return item;
        }
    }
}
