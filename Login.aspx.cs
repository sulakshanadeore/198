using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Session.SessionID.ToString();
            Label4.Text = Session.IsNewSession.ToString();
            Label5.Text = Session.IsCookieless.ToString();
            Label6.Text = Application["cnt"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text=="abc" && txtpwd.Text=="abc@123")
            {
                Session["username"] = txtusername.Text;
                Response.Redirect("~/Welcome.aspx");
            }
            else
            {
                Response.Write("check userid/pwd");
            }
        }
    }
}