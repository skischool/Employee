using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IEmployeeTypeRepository
    {
        Infrastructure.Data.MainModule.Models.EmployeeType Add(Infrastructure.Data.MainModule.Models.EmployeeType item);
        Infrastructure.Data.MainModule.Models.EmployeeType Delete(int id, Guid clientToken);
        Infrastructure.Data.MainModule.Models.EmployeeType Get(int id, Guid clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.EmployeeType> List(Guid clientToken);
        Infrastructure.Data.MainModule.Models.EmployeeType Update(Infrastructure.Data.MainModule.Models.EmployeeType item, Guid clientToken);
    }
}
