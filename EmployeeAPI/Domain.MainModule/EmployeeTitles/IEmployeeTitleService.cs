using System.Collections.Generic;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTitles
{
    public interface IEmployeeTitleService
    {
        EmployeeTitle Add(EmployeeTitle item);

        EmployeeTitle Update(EmployeeTitle item);

        EmployeeTitle Delete(int id);

        EmployeeTitle Get(int id);

        IEnumerable<EmployeeTitle> List();
    }
}
