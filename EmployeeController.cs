using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CachingDemo.Models;
namespace CachingDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Emp> emps = new List<Emp>();
        static EmployeeController()
        {
            emps.Add(new Emp {empid=1,empName="A" });
            emps.Add(new Emp { empid = 2, empName = "B" });
            emps.Add(new Emp { empid = 3, empName = "C" });
            emps.Add(new Emp { empid = 4, empName = "D" });


        }
        // GET: Employee
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        //[OutputCache(Duration = 10, VaryByParam = "id")]
        [OutputCache(CacheProfile ="c2")]
        public ActionResult Search(int id)
        {
            var m = (from a in emps
                    where a.empid == id
                    select a).FirstOrDefault();
            ViewBag.id = m.empid;
            ViewBag.name = m.empName;
            return View();
        }


    }
}