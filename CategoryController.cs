using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using SecondMVCAppWithDB.Models;
namespace SecondMVCAppWithDB.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            dt = FillData();
            List<Category> list = new List<Category>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category c = new Category();
                c.Id = Convert.ToInt32(dt.Rows[i][0]);
                c.Catname = dt.Rows[i][1].ToString();
                c.Desc = dt.Rows[i][2].ToString();
                list.Add(c);

            }
            ViewBag.catlist = list;
            return View();
            //return View(list);
        }


        public ActionResult ShowAllCategoryList()
        {
            DataTable dt = new DataTable();
            dt = FillData();
            List<Category> list = new List<Category>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category c = new Category();
                c.Id = Convert.ToInt32(dt.Rows[i][0]);
                c.Catname = dt.Rows[i][1].ToString();
                c.Desc = dt.Rows[i][2].ToString();
                list.Add(c);

            }
            //ViewData["catlist"] = list;
            TempData["catlist"] = list;
            return View();

        }


        private static DataTable FillData()
        {
            SqlConnection cn = new SqlConnection("Data Source=SPD;Initial Catalog=Shopping;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "cat");
            return ds.Tables[0];
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            DataTable dt = new DataTable();
            dt = FillData();

            DataRow drow = dt.Rows.Find(id);
            Category c = new Category();
            c.Id = id;
            //TempData["id"] = id;
            c.Catname = drow[1].ToString();
            c.Desc = drow[2].ToString();


            return View(c);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Category c = new Category();
                c.Catname = Request.Form["Catname"].ToString();
                c.Desc = Request.Form["Desc"].ToString();
                DataTable dt = new DataTable();
                dt = FillData();

                DataRow drow = dt.NewRow();
                drow[1] = c.Catname;
                drow[2] = c.Desc;
                dt.Rows.Add(drow);
                SubmitData(dt);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public static void SubmitData(DataTable dt)
        {
            SqlConnection cn = new SqlConnection("Data Source=SPD;Initial Catalog=Shopping;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "cat");
            da.Update(dt);
            
        }


        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            DataTable dt = new DataTable();
            dt = FillData();

            DataRow drow = dt.Rows.Find(id);
            Category c = new Category();
            c.Catname = drow[1].ToString();
            c.Desc = drow[2].ToString();


            return View(c);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                Category c = new Category();
                c.Catname = Request.Form["Catname"].ToString();
                c.Desc = Request.Form["Desc"].ToString();

                DataTable dt = new DataTable();
                dt = FillData();

                DataRow drow = dt.Rows.Find(id);
                drow[1] = c.Catname;
                drow[2] = c.Desc;
                
                SubmitData(dt);



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            DataTable dt = new DataTable();
            dt = FillData();

            DataRow drow = dt.Rows.Find(id);
            Category c = new Category();
            c.Catname = drow[1].ToString();
            c.Desc = drow[2].ToString();


            return View(c);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DataTable dt = new DataTable();
                dt = FillData();

                DataRow drow = dt.Rows.Find(id);
                Category c = new Category();
                drow.Delete();

                SubmitData(dt);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
