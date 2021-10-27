using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.mydata = "got data from controller";
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            TempData["v1"] = "Hello from Index";
            return RedirectToAction("Create");
           }
        public ActionResult Create()
        {
            TempData.Keep();
            string s=TempData["v1"].ToString();
            return Content(s);
        }
        public ActionResult Greet()
        {
                               //pickup
            string s1=TempData.Peek("v1").ToString();
            return Content(s1);

        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(int i,int j)
        {
            int c = i + j;
            ViewBag.answer = c;
            return View();
        }

        public ActionResult subtract()
        {
            return View();
        }

        [HttpPost]
        public ActionResult subtract(int i,int j)
        {
            int c = i - j;
            ViewData["answer"] = c;
            return View();
        }




    }
}