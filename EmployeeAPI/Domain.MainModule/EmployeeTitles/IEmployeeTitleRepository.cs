using System.Collections.Generic;
using Domain.Core;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTitles
{
    public interface IEmployeeTitleRepository
    {
        EmployeeTitle Add(EmployeeTitle item);

        EmployeeTitle Update(EmployeeTitle item);

        EmployeeTitle Delete(int id);

        IEnumerable<EmployeeTitle> List();

        EmployeeTitle Get(int id);
    }
}
