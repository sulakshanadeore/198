using System;
using System.Collections;
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
        public static Hashtable cart = new Hashtable();
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cart.Add(ListBox1.SelectedItem.Text, ListBox1.SelectedValue);
            //ListBox2.Items.Add(cart.)
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ListBox2.Items.Remove(ListBox2.SelectedValue);

            ListItem li = ListBox2.SelectedItem;
            ListBox2.Items.Remove(li);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //int total = 0;


            //for (int i = 0; i < ListBox2.Items.Count; i++)
            //{
            //    total = total + Convert.ToInt32(ListBox2.Items[i].Value);
            //}
            //txtTotal.Text = total.ToString();
            int total = 0;
            IDictionaryEnumerator ie = cart.GetEnumerator();
            while (ie.MoveNext())
            {
                ListItem item = new ListItem();
                item.Value = ie.Value.ToString();
                total = Convert.ToInt32(item.Value) + total;
            }
            txtTotal.Text = total.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IDictionaryEnumerator ie=cart.GetEnumerator();
            while (ie.MoveNext())
            {
                ListItem item = new ListItem();
                item.Text = ie.Key.ToString();
                item.Value = ie.Value.ToString();
                ListBox2.Items.Add(string.Concat(item.Text,item.Value));
                
            }
            
            
        }
    }
}