using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string GetAllCustomers()
        {
            return @"<ul><li>Keenkid</li><li>Sakura</li><li>Elsa</li></ul>";
        }
    }
}