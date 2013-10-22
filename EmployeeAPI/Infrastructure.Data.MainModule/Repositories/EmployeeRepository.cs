using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.MainModule.Models;
using Domain.Core;
using System.Data.Entity.Validation;

namespace Infrastructure.Data.MainModule.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeApiContext _context;

        public EmployeeRepository()
        {
            _context = new EmployeeApiContext();
        }

        public Employee Add(Employee item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            item.ClientToken = guid;
            
            var addedItem = _context.Employees.Add(item);

            addedItem.DateCreated = DateTime.Now;

            _context.SaveChanges();

            return addedItem;
        }

        public Employee Update(Employee item, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var personToUpdate = _context.Persons.FirstOrDefault(p => p.Id == item.Person.Id && p.ClientToken == guid);

            personToUpdate.ClientToken = guid;

            personToUpdate.DateOfBirth = item.Person.DateOfBirth;

            personToUpdate.LastName = item.Person.LastName;

            personToUpdate.FirstName = item.Person.FirstName;

            personToUpdate.MiddleName = item.Person.MiddleName;

            personToUpdate.DateModified = DateTime.Now;

            personToUpdate.GenderId = item.Person.GenderId;

            _context.SaveChanges();

            var employeeToUpdate = _context.Employees.FirstOrDefault(e => e.Id == item.Id && e.ClientToken == guid);

            employeeToUpdate.IsLocal = item.IsLocal;

            employeeToUpdate.Current = item.Current;

            employeeToUpdate.TitleId = item.EmployeeTitle.Id;

            employeeToUpdate.LoginId = item.LoginId;

            employeeToUpdate.EmployeeTypeId = item.EmployeeType.Id;

            employeeToUpdate.RosterId = item.RosterId;

            employeeToUpdate.DateModified = DateTime.Now;

            _context.SaveChanges();

            //try
            //{
            //    _context.SaveChanges();

            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            var error = string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

            
            var updatedEmployee = _context.Employees.FirstOrDefault(e => e.Id == item.Id && e.ClientToken == guid);

            return updatedEmployee;
        }

        //var itemToUpdate = _context.Employees.FirstOrDefault(b => b.Id == item.Id && b.ClientToken == guid);

        //itemToUpdate.ClientToken = item.ClientToken;

        //itemToUpdate.Current = item.Current;

        //itemToUpdate.EmployeeTypeId = item.EmployeeType.Id;

        //itemToUpdate.IsLocal = item.IsLocal;

        //itemToUpdate.LoginId = item.LoginId;

        //itemToUpdate.PersonId = item.Person.Id;

        //itemToUpdate.Person.FirstName = item.Person.FirstName;

        //itemToUpdate.Person.LastName = item.Person.LastName;

        //itemToUpdate.Person.MiddleName = item.Person.MiddleName;

        //itemToUpdate.Person.DateOfBirth = item.Person.DateOfBirth;

        //itemToUpdate.Person.GenderId = item.Person.GenderId;

        //itemToUpdate.Person.Id = item.Person.Id;

        //itemToUpdate.RosterId = item.RosterId;

        //itemToUpdate.TitleId = item.EmployeeTitle.Id;

        //itemToUpdate.Id = item.Id;

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

        public Employee GetByLoginId(int loginId, string clientToken)
        {
            var guid = Guid.Parse(clientToken);

            var item = _context.Employees.FirstOrDefault(e => e.LoginId == loginId && e.ClientToken == guid);

            return item;
        }
    }
}
