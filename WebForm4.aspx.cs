using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Products> plist = new List<Products>();
            //Products p1 = new Products();
            //p1.Prodid = Convert.ToInt32(Request.QueryString["prodid"]);
            //p1.ProductName = Request.QueryString["pname"].ToString();
            //plist.Add(p1);

            //foreach (var item in plist)
            //{
            //    ListBox1.Items.Add(item.Prodid + " " + item.ProductName);
            //}

            //TextBox1.Text = Request.QueryString["prodid"].ToString();
            //TextBox2.Text = Request.QueryString["pname"].ToString();
            if (!Page.IsPostBack)
            {


                string parray = Request.QueryString["products"].ToString();

                Response.Write(parray);
            }
        }
    }
}