using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IEmployeeRepository
    {
        Infrastructure.Data.MainModule.Models.Employee Add(Infrastructure.Data.MainModule.Models.Employee item);
        Infrastructure.Data.MainModule.Models.Employee Delete(int id, string clientToken);
        Infrastructure.Data.MainModule.Models.Employee Get(int id, string clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Employee> List(string clientToken);
        Infrastructure.Data.MainModule.Models.Employee Update(Infrastructure.Data.MainModule.Models.Employee item, string clientToken);
    }
}
