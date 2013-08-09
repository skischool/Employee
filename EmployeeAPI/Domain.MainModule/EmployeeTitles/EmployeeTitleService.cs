using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTitles
{
    public class EmployeeTitleService : IEmployeeTitleService
    {
    	readonly IEmployeeTitleRepository _repository;

        public EmployeeTitleService(IEmployeeTitleRepository repository)
        {
            _repository = repository;
        }

        public EmployeeTitle Add(EmployeeTitle item)
        {
            return _repository.Add(item);
        }

        public EmployeeTitle Update(EmployeeTitle item)
        {
            return _repository.Update(item);
        }

        public EmployeeTitle Delete(int id)
        {
            return _repository.Delete(id);
        }

        public EmployeeTitle Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<EmployeeTitle> List()
        {
            return _repository.List();
        }
    }
}
