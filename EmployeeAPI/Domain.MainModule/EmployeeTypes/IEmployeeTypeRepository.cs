using System.Collections.Generic;
using Domain.Core;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTypes
{
    public interface IEmployeeTypeRepository
    {
        EmployeeType Add(EmployeeType item);

        EmployeeType Update(EmployeeType item);

        EmployeeType Delete(int id);

        IEnumerable<EmployeeType> List();

        EmployeeType Get(int id);
    }
}
