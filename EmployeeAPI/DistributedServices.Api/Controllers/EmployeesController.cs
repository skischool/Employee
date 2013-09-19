using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Infrastructure.CrossCutting.IoC;
using DistributedServices.Entities;
using DistributedServices.Api.Mappings;
using AttributeRouting.Web.Http;
using Infrastructure.Data.MainModule.Repositories;
using Infrastructure.Data.MainModule.Models;

namespace DistributedServices.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepository _service;

        public EmployeesController()
        {
            _service = IoCFactory.Resolve<IEmployeeRepository>();
        }

        /// <summary>
        /// All of the employee titles.
        /// </summary>
        /// <returns>All employee titles.</returns>
        public HttpResponseMessage GetAll(string clientToken)
        {
            var items = _service.List(clientToken);

            var itemDto = items.Select(i => Mapper.Map(i));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// A item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>Item.</returns>
        public HttpResponseMessage Get([FromUri]int id, [FromUri]string clientToken)
        {
            var item = _service.Get(id, clientToken);

            var itemDto = Mapper.Map(item);

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Creates a new employee title.
        /// </summary>
        /// <param name="item">New employee title to create in the given bundle.</param>
        /// <returns>The recently created employee title.</returns>
        public HttpResponseMessage Post([FromBody]Employee item, [FromUri]string clientToken)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Employee());

            

            var itemDto = Mapper.Map(_service.Add(item, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Updates an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for the item to update.</param>
        /// <param name="item">Item to update.</param>
        /// <returns>The recently updated item.</returns>
        public HttpResponseMessage Put([FromUri]int id, [FromUri]string clientToken, [FromBody]Employee item)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Employee());

            item.Id = id;

            var itemDto = Mapper.Map(_service.Update(item, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Deletes an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>The recently deleted item.</returns>
        public HttpResponseMessage Delete([FromUri]int id, [FromUri]string clientToken)
        {
            var itemDto = Mapper.Map(_service.Delete(id, clientToken));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }
    }
}
