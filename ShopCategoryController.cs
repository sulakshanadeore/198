using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIWithDBDemo.Models;
using BALayer;
using DALayer;
using System.Data;
using System.Data.SqlClient;

namespace WebAPIWithDBDemo.Controllers
{
    public class ShopCategoryController : ApiController
    {
        // GET: api/ShopCategory
        public List<CategoriesModel> Get()
        {
            CategoryDAL dal = new CategoryDAL();
            DataTable dt = new DataTable();
            dt=dal.showall();
            List<CategoriesModel> list = new List<CategoriesModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CategoriesModel m = new CategoriesModel();
                m.CategoryID = Convert.ToInt32(dt.Rows[i][0]);
                m.CatName = dt.Rows[i][1].ToString();
                m.CatDesc = dt.Rows[i][2].ToString();
                list.Add(m);
            }
            return list;
        }

        // GET: api/ShopCategory/5
        public CategoriesModel Get(int id)
        {
            CategoryDAL dal = new CategoryDAL();
            CategoryBAL bal = new CategoryBAL();
            bal=dal.FindCategory(id);
            CategoriesModel model = new CategoriesModel();
            model.CategoryID = bal.CategoryID;
            model.CatName = bal.CatName;
            model.CatDesc = bal.CatDesc;
            return model;
        }

        // POST: api/ShopCategory
        public void Post([FromBody]CategoriesModel value)
        {
            //CategoryDAL dal = new CategoryDAL();
            //CategoryBAL bal = new CategoryBAL();
            //bal.CatName = value.CatName;
            //bal.CatDesc = value.CatDesc;

            //string s=dal.InsertCategory(bal);

            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            SqlDataAdapter da = new SqlDataAdapter("select * from categories",cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");
            DataRow newrow=ds.Tables[0].NewRow();
            newrow[1] = value.CatName;
            newrow[2] = value.CatDesc;
            ds.Tables[0].Rows.Add(newrow);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables[0]);

        }

        // PUT: api/ShopCategory/5
        public void Put(int id, [FromBody]CategoriesModel value)
        {

            CategoryDAL dal = new CategoryDAL();
            CategoryBAL bal = new CategoryBAL();
            bal.CategoryID = id;
            bal.CatName = value.CatName;
            bal.CatDesc = value.CatDesc;

            dal.UpdateCategoryData(bal);
        }

        // DELETE: api/ShopCategory/5
        public void Delete(int id)
        {
            CategoryDAL dal = new CategoryDAL();
            dal.DeleteCategory(id);
        }
    }
}
