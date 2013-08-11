using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

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

            PeopleRoutes(config);

            EmployeeRoutes(config);

            EmployeeTitleRoutes(config);

            EmployeeTypeRoutes(config);
        }

        private static void PeopleRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "PeopleGetAll",
                routeTemplate: "api/people",
                defaults: new { controller = "People", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "Person",
                routeTemplate: "api/people/{id}",
                defaults: new { controller = "People", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "PersonPost",
                routeTemplate: "api/people",
                defaults: new { controller = "People", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "PersonPut",
                routeTemplate: "api/people/{id}",
                defaults: new { controller = "People", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "PersonDelete",
                routeTemplate: "api/people/{id}",
                defaults: new { controller = "People", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void EmployeeTitleRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "EmployeeTitleGetAll",
                routeTemplate: "api/employeetitles",
                defaults: new { controller = "EmployeeTitles", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTitleGet",
                routeTemplate: "api/employeetitles/{id}",
                defaults: new { controller = "EmployeeTitles", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTitlePost",
                routeTemplate: "api/employeetitles",
                defaults: new { controller = "EmployeeTitles", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTitlePut",
                routeTemplate: "api/employeetitles/{id}",
                defaults: new { controller = "EmployeeTitles", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTitleDelete",
                routeTemplate: "api/employeetitles/{id}",
                defaults: new { controller = "EmployeeTitles", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void EmployeeTypeRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "EmployeeTypeGetAll",
                routeTemplate: "api/employeetypes",
                defaults: new { controller = "EmployeeTypes", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTypeGet",
                routeTemplate: "api/employeetypes/{id}",
                defaults: new { controller = "EmployeeTypes", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTypePost",
                routeTemplate: "api/employeetypes",
                defaults: new { controller = "EmployeeTypes", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTypePut",
                routeTemplate: "api/employeetypes/{id}",
                defaults: new { controller = "EmployeeTypes", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeTypeDelete",
                routeTemplate: "api/employeetypes/{id}",
                defaults: new { controller = "EmployeeTypes", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void EmployeeRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "EmployeeGetAll",
                routeTemplate: "api/employees",
                defaults: new { controller = "Employees", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeGet",
                routeTemplate: "api/employees/{id}",
                defaults: new { controller = "Employees", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeePost",
                routeTemplate: "api/employees",
                defaults: new { controller = "Employees", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeePut",
                routeTemplate: "api/employees/{id}",
                defaults: new { controller = "Employees", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "EmployeeDelete",
                routeTemplate: "api/employees/{id}",
                defaults: new { controller = "Employees", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }
    }
}
