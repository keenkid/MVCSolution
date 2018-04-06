using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFirstApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Process", "Process/{action}/{id}", new { controller = "Process", action = "List", id = UrlParameter.Optional });

            routes.MapRoute("Employee", "Employee/{name}", new { controller = "Employee", action = "search", name = UrlParameter.Optional });

            routes.MapRoute("Customer", "Customer/{action}", new { controller = "Customer", action = "getallcustomers", name = UrlParameter.Optional});

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "NewHome", action = "AnotherChance", id = UrlParameter.Optional });
        }
    }
}
