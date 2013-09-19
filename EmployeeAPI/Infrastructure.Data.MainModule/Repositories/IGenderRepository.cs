using System;
namespace Infrastructure.Data.MainModule.Repositories
{
    public interface IGenderRepository
    {
        Infrastructure.Data.MainModule.Models.Gender Add(Infrastructure.Data.MainModule.Models.Gender item);
        Infrastructure.Data.MainModule.Models.Gender Delete(int id, Guid clientToken);
        Infrastructure.Data.MainModule.Models.Gender Get(int id, Guid clientToken);
        System.Collections.Generic.IEnumerable<Infrastructure.Data.MainModule.Models.Gender> List(Guid clientToken);
        Infrastructure.Data.MainModule.Models.Gender Update(Infrastructure.Data.MainModule.Models.Gender item, Guid clientToken);
    }
}
