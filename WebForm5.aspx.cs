using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (HiddenField1.Value==TextBox1.Text)
            {
                Response.Write("Answer is correct");
            }
            else
            {
                Response.Write("Answer is not correct");
            }
        }
    }
}