using System.Collections.Generic;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Employees
{
    public interface IEmployeeService
    {
        Employee Add(Employee item);

        Employee Update(Employee item);

        Employee Delete(int id);

        Employee Get(int id);

        IEnumerable<Employee> List();
    }
}
