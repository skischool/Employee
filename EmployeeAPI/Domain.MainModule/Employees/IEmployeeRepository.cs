using System.Collections.Generic;
using Domain.Core;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Employees
{
    public interface IEmployeeRepository
    {
        Employee Add(Employee item);

        Employee Update(Employee item);

        Employee Delete(int id);

        IEnumerable<Employee> List();

        Employee Get(int id);
    }
}
