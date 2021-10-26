using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Cache["mydata"] = TextBox3.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = Cache["mydata"].ToString();
        }
    }
}