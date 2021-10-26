using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FirstBALLayer;
using FirstDALLayer;

using BALayer;
using DALayer;
using System.Data;

namespace MasterPagesDemo
{
    public partial class statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ProductsDAL products = new ProductsDAL();
            //int i=products.CountProducts();
            //Label2.Text = i.ToString();

            DALayer.CategoryDAL dal = new CategoryDAL();
            DataTable dt = new DataTable();
            dt=dal.showall();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label2.Text = dt.Rows.Count.ToString();
        }
    }
}