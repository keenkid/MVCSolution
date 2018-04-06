using MVCFiltersDemo.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        //[OutputCache(Duration = 15)]
        [ActionName("CurrentTime")]
        public string Index()
        {
            return "This is ASP.NET MVC Filters Tutorial";
        }

        //original action become invalid, and default url too
        [ActionName("CurrentTime2")]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        public string TimeString()
        {
            return "Time is:" + DateTime.Now.ToString("T");
        }
    }
}