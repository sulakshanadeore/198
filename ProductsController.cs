using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;
namespace FirstMVCApp.Controllers
{
    public class ProductsController : Controller
    {
        public static List<AmazonProducts> productList = new List<AmazonProducts>();

        static ProductsController()
        {
            productList.Add(new AmazonProducts {Prodid=1,Prodname="Laptop",Price=40000,Catid=100 });

            productList.Add(new AmazonProducts { Prodid = 2, Prodname = "Mobiles", Price = 20000, Catid = 101 });

            productList.Add(new AmazonProducts { Prodid = 3, Prodname = "Shirts", Price = 1000, Catid = 102});

            productList.Add(new AmazonProducts { Prodid = 4, Prodname = "Desktop", Price = 45000, Catid = 100 });



        }
        // GET: Products
        public ActionResult Index()
        {

            return View(productList);
        }

        public ActionResult Edit(int id)
        {
            AmazonProducts product=productList.Find(p => p.Prodid == id);

            return View(product);
        }


        [HttpPost]
        public ActionResult Edit(int id,AmazonProducts data)
        {
            if (ModelState.IsValid)
            {
                AmazonProducts products=productList.Find(p => p.Prodid == id);
                products.Prodname = data.Prodname;
                products.Price = data.Price;
                products.Catid = data.Catid;
                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Details(int id)
        {
            AmazonProducts products = productList.Find(p => p.Prodid == id);

            return View(products);
        }
        public ActionResult Delete(int id)
        {
            AmazonProducts products = productList.Find(p => p.Prodid == id);
             return View(products);
        }
        [HttpPost]
        public ActionResult Delete(int id,AmazonProducts data)
        {
            if (ModelState.IsValid)
            {
                AmazonProducts products = productList.Find(p => p.Prodid == id);
                productList.Remove(products);

                return RedirectToAction("Index");
            }

            return View(data);
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(AmazonProducts data)
        {
            if (ModelState.IsValid)
            {

                productList.Add(new AmazonProducts { Prodid = data.Prodid, Prodname = data.Prodname, Price = data.Price, Catid = data.Catid });
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}