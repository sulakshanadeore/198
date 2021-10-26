using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BALayer;
using DALayer;
using System.Data;
namespace MasterPagesDemo
{
    public partial class Transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            CategoryDAL dal = new CategoryDAL();
            DataTable dt = new DataTable();
            dt=dal.showall();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}