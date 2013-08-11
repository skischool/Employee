using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.MainModule.Entities;
using Infrastructure.CrossCutting.IoC;
using DistributedServices.Entities;
using DistributedServices.Api.Mappings;
using Domain.MainModule.Persons;

namespace DistributedServices.Api.Controllers
{
    public class PeopleController : ApiController
    {
        private readonly IPersonService _service;

        public PeopleController()
        {
            _service = IoCFactory.Resolve<IPersonService>();
        }

        /// <summary>
        /// All of the employee titles.
        /// </summary>
        /// <returns>All employee titles.</returns>
        public HttpResponseMessage GetAll()
        {
            var items = _service.List();

            var itemDto = items.Select(i => Mapper.Map(i));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// A item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>Item.</returns>
        public HttpResponseMessage Get([FromUri]int id)
        {
            var item = _service.Get(id);

            var itemDto = Mapper.Map(item);

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Creates a new employee title.
        /// </summary>
        /// <param name="item">New employee title to create in the given bundle.</param>
        /// <returns>The recently created employee title.</returns>
        public HttpResponseMessage Post([FromBody]Person item)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Person());

            var itemDto = Mapper.Map(_service.Add(item));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Updates an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for the item to update.</param>
        /// <param name="item">Item to update.</param>
        /// <returns>The recently updated item.</returns>
        public HttpResponseMessage Put([FromUri]int id, [FromBody]Person item)
        {
            if (item == null)
                return Request.CreateResponse(HttpStatusCode.OK, new Person());

            item.Id = id;

            var itemDto = Mapper.Map(_service.Update(item));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }

        /// <summary>
        /// Deletes an existing item.
        /// </summary>
        /// <param name="id">Unique identifier for an item.</param>
        /// <returns>The recently deleted item.</returns>
        public HttpResponseMessage Delete([FromUri]int id)
        {
            var itemDto = Mapper.Map(_service.Delete(id));

            return Request.CreateResponse(HttpStatusCode.OK, itemDto);
        }
    }
}
