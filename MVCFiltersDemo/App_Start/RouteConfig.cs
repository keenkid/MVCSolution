using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFiltersDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("employee", "employee/{id}", new { controller = "employee", action = "search", id=UrlParameter.Optional });
            routes.MapRoute("Employee", "Employee/{action}/{name}", new { controller = "Employee", action = "search", name = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "getcurrenttime", id = UrlParameter.Optional }
            );
        }
    }
}
