using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;
namespace FirstMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult Greet()
        {

            return Content("Good morning");
        }


        public ActionResult CreateCustomer()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(int userid,string pwd)
        {
            CustLogin cust = new CustLogin();
            cust.Userid = userid;
            cust.Password = pwd;
            AllLogic a = new AllLogic();
            bool ans=a.Validatecustomer(cust.Userid, cust.Password);
            if (ans)
            {
                return RedirectToAction("Greet");
            }
            else
            {

                string s = "Pls check ur userid/password";
                return Content(s);
            }
        }

    }
}