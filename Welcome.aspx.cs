using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Session.SessionID.ToString();
            Label3.Text = Session.IsNewSession.ToString();
            Label4.Text = Session.IsCookieless.ToString();


            string uname = Session["username"].ToString();

            Label1.Text = uname;
        }
    }
}