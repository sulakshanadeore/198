using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = ans.ToString();
            Cache["answer"] = TextBox3.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = Cache["answer"].ToString();
        }
    }
}