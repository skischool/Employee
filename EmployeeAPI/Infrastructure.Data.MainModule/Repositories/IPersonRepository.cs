using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IPersonRepository
    {
        Infrastructure.Data.MainModule.Models.Person Add(Infrastructure.Data.MainModule.Models.Person item);
        Infrastructure.Data.MainModule.Models.Person Delete(int id);
        Infrastructure.Data.MainModule.Models.Person Get(int id);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Person> List();
        Infrastructure.Data.MainModule.Models.Person Update(Infrastructure.Data.MainModule.Models.Person item);
    }
}
