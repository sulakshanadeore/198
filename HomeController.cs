using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransactionsDemo;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Products p = new Products();
            p.ShowProducts();
            return Content("Done");
        }

        public ActionResult About()
        {
            Products p = new Products();
            p.WorkWithScope();
            return Content("Done");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}