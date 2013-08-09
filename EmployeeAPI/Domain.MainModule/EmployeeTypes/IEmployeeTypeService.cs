using System.Collections.Generic;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTypes
{
    public interface IEmployeeTypeService
    {
        EmployeeType Add(EmployeeType item);

        EmployeeType Update(EmployeeType item);

        EmployeeType Delete(int id);

        EmployeeType Get(int id);

        IEnumerable<EmployeeType> List();
    }
}
