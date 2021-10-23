using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userdata");
            cookie.Values.Add("username", txtname.Text);
            cookie.Values.Add("age", txtage.Text);
            cookie.Values.Add("email", txtemail.Text);
            cookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(cookie);

            Response.Redirect("~/WebForm2.aspx");
        }
    }
}