using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Employees
{
    public class EmployeeService : IEmployeeService
    {
    	readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public Employee Add(Employee item)
        {
            return _repository.Add(item);
        }

        public Employee Update(Employee item)
        {
            return _repository.Update(item);
        }

        public Employee Delete(int id)
        {
            return _repository.Delete(id);
        }

        public Employee Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Employee> List()
        {
            return _repository.List();
        }
    }
}
