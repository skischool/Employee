using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class GenderRepository : IGenderRepository
    {
        private readonly EmployeeApiContext _context;

        public GenderRepository()
        {
            _context = new EmployeeApiContext();
        }

        public Gender Add(Gender item)
        {
            var addedItem = _context.Genders.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Gender Update(Gender item, Guid clientToken)
        {
            var itemToUpdate = _context.Genders.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == clientToken);

            itemToUpdate.Name = item.Name;

            itemToUpdate.Description = item.Description;

            item.DateModified = DateTime.Now;

            _context.SaveChanges();

            return itemToUpdate;
        }

        public Gender Delete(int id, Guid clientToken)
        {
            var itemToDelete = _context.Genders.FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            var deletedItem = _context.Genders.Remove(itemToDelete);

            _context.SaveChanges();

            return deletedItem;
        }

        public IEnumerable<Gender> List(Guid clientToken)
        {
            var items = _context.Genders.Where(e => e.ClientToken == clientToken);

            return items;
        }

        public Gender Get(int id, Guid clientToken)
        {
            var item = _context.Genders.ToList().FirstOrDefault(b => b.Id == id && b.ClientToken == clientToken);

            return item;
        }
    }
}
