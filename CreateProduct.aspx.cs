using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FirstDALLayer;
using FirstBALLayer;
namespace MasterPagesDemo
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProductsDAL dal = new ProductsDAL();
            ProductsBAL bal = new ProductsBAL();
            bal.Prodname = txtname.Text;
            bal.Price = Convert.ToSingle(txtprice.Text);
            bal.UOM = txtuom.Text;
            dal.InsertProducts(bal);
            Response.Redirect("~/ShowAllProducts.aspx");
        }
    }
}