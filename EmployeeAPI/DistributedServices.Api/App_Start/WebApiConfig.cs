using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DistributedServices.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "BundleApi",
            //    routeTemplate: "api/bundles/{id}",
            //    defaults: new { controller = "Bundles", action = "Get" }
            //    );

            //config.Routes.MapHttpRoute(
            //    name: "ProductPostApi",
            //    routeTemplate: "api/bundles/{bundleId}/products",
            //    defaults: new { controller = "Products", action = "Post" }
            //    );

            //config.Routes.MapHttpRoute(
            //    name: "ProductPutApi",
            //    routeTemplate: "api/bundles/{bundleId}/products/{id}",
            //    defaults: new { controller = "Products", action = "Put" }
            //    );

            //config.Routes.MapHttpRoute(
            //    name: "ProductDeleteApi",
            //    routeTemplate: "api/bundles/{bundleId}/products/{id}",
            //    defaults: new { controller = "Products", action = "Delete" }
            //    );
        }
    }
}
