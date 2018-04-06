using MVCFiltersDemo.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{
    [MyLogActionFilter]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }

        [HttpGet]
        public ActionResult Search()
        {
            var input = "Another search action";
            return Content(input);
        }
    }
}