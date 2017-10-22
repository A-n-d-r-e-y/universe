using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Universe.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Microwave",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Action",
                routeTemplate: "api/microwave/{id}/action",
                defaults: new { controller = "Action" }
            );

            //config.Routes.MapHttpRoute(
            //    name: "Action",
            //    routeTemplate: "api/microwave/{id}/action/{actionId}",
            //    defaults: new { controller = "Action", actionId = RouteParameter.Optional }
            //);
        }
    }
}
