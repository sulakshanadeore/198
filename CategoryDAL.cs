using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALayer;
using System.Data.SqlClient;
using System.Data;
namespace DALayer
{
    public class CategoryDAL
    {
        public string InsertCategory(CategoryBAL category)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories",cn);
            //DataSet is in-memory copy of your database datatable
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");//dataTable ---- categories---- datatable is inside the dataset
            //u get disconnected from db server
            //datatable---categories---- in/up/de

            DataRow newrow=ds.Tables["categories"].NewRow();
            newrow["Catname"] = category.CatName;
            newrow["Description"] = category.CatDesc;

            ds.Tables["categories"].Rows.Add(newrow);

            //SqlDataAdapter is used to submit the changes to the server
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);
            string status = "Done";
            return status;
           




        }

    }
}
