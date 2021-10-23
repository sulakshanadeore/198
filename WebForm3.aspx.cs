using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Products[] pdata = new Products[list.Count];
            string s1 = null;
            foreach (var    item     in list)
            {
               
                for (int i = 0; i < pdata.Length; i++)
                {
                    pdata[i] = new Products();
                pdata[i].Prodid = item.Prodid;
                    pdata[i].ProductName = item.ProductName;
                    s1 += string.Concat(pdata[i].Prodid, pdata[i].ProductName);
                }
                
            }

            Response.Redirect("~/WebForm4.aspx?products=" + s1);



        }

        static List<Products> list = new List<Products>();
        protected void Button2_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Prodid = Convert.ToInt32(TextBox1.Text);
            p.ProductName = TextBox2.Text;
            list.Add(p);
        }
    }
}