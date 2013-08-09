﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.MainModule.Entities;

namespace DistributedServices.Api.Mappings
{
    public static class Mapper
    {
        public static Entities.Dto.Employee Map(Employee item)
        {
            var dto = new Entities.Dto.Employee()
            {
                ClientId = item.ClientId,
                Id = item.Id,
                TitleId = item.TitleId,
                LoginId = item.LoginId,
                IsLocal = item.IsLocal,
                EmployeeTypeId = item.EmployeeTypeId,
                Current = item.Current,
                PersonId = item.PersonId,
                RosterId = item.RosterId,
                EmployeeType = Mapper.Map(item.EmployeeType),
                Person = Mapper.Map(item.Person),
                Title = Mapper.Map(item.Title)
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.Person Map(Domain.MainModule.Entities.Person item)
        {
            var dto = new Entities.Dto.Person()
            {
                LastName = item.LastName,
                FirstName = item.FirstName,
                MiddleName = item.MiddleName,
                DateOfBirth = item.DateOfBirth,
                Id = item.Id
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.EmployeeTitle Map(Domain.MainModule.Entities.EmployeeTitle item)
        {
            var dto = new Entities.Dto.EmployeeTitle()
            {
                Name = item.Name,
                Description = item.Description,
                Id = item.Id
            };

            return dto;
        }

        public static DistributedServices.Entities.Dto.EmployeeType Map(Domain.MainModule.Entities.EmployeeType item)
        {
            var dto = new Entities.Dto.EmployeeType()
            {
                Name = item.Name,
                Description = item.Description,
                Id = item.Id
            };

            return dto;
        }
    }
}