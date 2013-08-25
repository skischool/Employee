using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IEmployeeTitleRepository
    {
        Infrastructure.Data.MainModule.Models.EmployeeTitle Add(Infrastructure.Data.MainModule.Models.EmployeeTitle item);
        Infrastructure.Data.MainModule.Models.EmployeeTitle Delete(int id, Guid clientToken);
        Infrastructure.Data.MainModule.Models.EmployeeTitle Get(int id, Guid clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.EmployeeTitle> List(Guid clientToken);
        Infrastructure.Data.MainModule.Models.EmployeeTitle Update(Infrastructure.Data.MainModule.Models.EmployeeTitle item, Guid clientToken);
    }
}
