using System;
using System.Collections.Generic;
using System.Linq;
using Domain.MainModule.Entities;

namespace Domain.MainModule.EmployeeTypes
{
    public class EmployeeTypeService : IEmployeeTypeService
    {
    	readonly IEmployeeTypeRepository _repository;

        public EmployeeTypeService(IEmployeeTypeRepository repository)
        {
            _repository = repository;
        }

        public EmployeeType Add(EmployeeType item)
        {
            return _repository.Add(item);
        }

        public EmployeeType Update(EmployeeType item)
        {
            return _repository.Update(item);
        }

        public EmployeeType Delete(int id)
        {
            return _repository.Delete(id);
        }

        public EmployeeType Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<EmployeeType> List()
        {
            return _repository.List();
        }
    }
}
