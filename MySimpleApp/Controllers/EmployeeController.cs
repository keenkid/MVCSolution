using MySimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySimpleApp.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDbContext db = new EmpDbContext();

        // GET: Employee
        public ActionResult Index()
        {
            //var employees = from e in EmpList orderby e.ID select e;
            var employees = from e in db.Employees orderby e.ID select e;
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            //var employee = EmpList.Single(m => m.ID == id);
            var employee = db.Employees.Single(m => m.ID == id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [NonAction]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EmpList.Add(new Employee() { ID = 5, Name = collection["Name"], JoiningDate = collection["JoiningDate"], Age = int.Parse(collection["Age"]) });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                //employee.ID = EmpList.Count + 1;
                //EmpList.Add(employee);
                db.Employees.Add(employee);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //var employee = EmpList.Single(m => m.ID == id);
            var employee = db.Employees.Single(m => m.ID == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //var employee = EmpList.Single(m => m.ID == id);
                var employee = db.Employees.Single(m => m.ID == id);
                
                if (TryUpdateModel<Employee>(employee))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            //var employee = EmpList.Single(m => m.ID == id);
            var employee = db.Employees.Single(m => m.ID == id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                //var employee = EmpList.Single(m => m.ID == id);
                var employee = db.Employees.Single(m => m.ID == id);
                if (null != employee)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>()
            {
                new Employee() { ID=1, Name="Allan", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=23},
                new Employee() { ID=2, Name="Carson", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=45},
                new Employee() { ID=3, Name="Sakura", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=37},
                new Employee() { ID=4, Name="Laura", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=26}
            };
        }

        public static List<Employee> EmpList = new List<Employee>()
            {
                new Employee() { ID=1, Name="Allan", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=23},
                new Employee() { ID=2, Name="Carson", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=45},
                new Employee() { ID=3, Name="Sakura", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=37},
                new Employee() { ID=4, Name="Laura", JoiningDate=DateTime.Now.ToString("yyyy-MM-dd"),Age=26}
            };
    }
}
