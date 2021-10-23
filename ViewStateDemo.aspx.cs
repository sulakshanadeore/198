using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        int cnt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                lblhits.Text = "Not hits yet";
            }
            else
            {
                //ViewState --- statebag that can hold values in key value pairs, it uses dictionary.
                //ViewState can store object type of data
                ViewState["hitscount"] = Convert.ToInt32(ViewState["hitscount"]) + 1;
                cnt = Convert.ToInt32(ViewState["hitscount"]);
                lblhits.Text = ViewState["hitscount"].ToString();
                if (Convert.ToInt32(ViewState["hitscount"]) >= 3)
                {
                    Button1.Enabled = false;
                    Response.Write("U have exceeded the maximum limit of 3");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           

        }
    }
}