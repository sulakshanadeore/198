using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //[OutputCache(Duration=10,VaryByParam ="val")]
        //public ActionResult Index(int val)
        //{

        //    ViewBag.mydata = val;
        //    return View();
        //}


        [OutputCache(Duration = 10, VaryByParam = "None")]
       // [HttpPost]
        public ActionResult Index(string id)
        {

            return Content("U entered = " + id);
        }



    }
}