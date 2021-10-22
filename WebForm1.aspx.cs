using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplicationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//do this only when the page is loading for the first time
            {
                ddlCity.Items.Add("----Select City----");
                ddlCity.Items.Add("Pune");
                ddlCity.Items.Add("Mumbai");
                ddlCity.Items.Add("Bangalore");
                ddlCity.Items.Add("Hyderabad");
                ddlCity.Items.Add("Indore");
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
            if (ddlCity.SelectedValue== "----Select City----")
            {
                Response.Write("Pls select a city from the list for the user");
            }
            else
            {
                txtcity.Text = "Dear " + txtname.Text + " you have selected the location city " + ddlCity.SelectedValue;
                ddlCity.SelectedValue = "----Select City----";
            }
            
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtvalueGreen.Text = ddlState.SelectedValue;
            txtTextMagenta.Text = ddlState.SelectedItem.Text;
        }
    }
}