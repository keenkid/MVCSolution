using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MySimpleApp.Models
{
    //Enable-Migrations
    //add-migration DataAnnotations
    //update-database
    public class Employee
    {
        [DisplayName("工号")]
        public int ID { get; set; }

        [StringLength(60,MinimumLength =3)]
        [DisplayName("姓名")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$",ErrorMessage = "Format should be yyyy-MM-dd")]
        [DisplayName("入职时间")]
        public String JoiningDate { get; set; }

        [Range(22,65)]
        [DisplayName("年龄")]
        public int Age { get; set; }
    }

    public class EmpDbContext : DbContext
    {
        public EmpDbContext() { }

        public DbSet<Employee> Employees { get; set; }
    }
}