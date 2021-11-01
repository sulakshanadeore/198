using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ServiceReference1;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Service1Client client = new Service1Client();
            ServiceReference1.Employee[] emplist = client.ShowRecords("SPD", "Northwind", "Employees", "", "");
            List<Models.Employee> emps = new List<Models.Employee>();
            foreach (var item in emplist)
            {
                emps.Add(new Models.Employee { Empid = item.Empid, Empname = item.Empname });

            }

            return View(emps);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}