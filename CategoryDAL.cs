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
        public DataTable showall()
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            //DataSet is in-memory copy of your database datatable
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");
            
            return ds.Tables["categories"];
        }


        public string DeleteCategory(int id)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            //DataSet is in-memory copy of your database datatable
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");//dataTable ---- categories---- datatable is inside the dataset
            //u get disconnected from db server
            //datatable---categories---- in/up/de

            DataRow drowFound = ds.Tables["categories"].Rows.Find(id);
            drowFound.Delete();
            DataRowState state=drowFound.RowState;
            string rowstate = null;
            if (state==DataRowState.Deleted)
            {
                rowstate = "this row is Deleted";
            }
            ds.Tables["categories"].AcceptChanges();
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);
            return rowstate;
        }

        public string UpdateCategoryData(CategoryBAL newdata)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            //DataSet is in-memory copy of your database datatable
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");//dataTable ---- categories---- datatable is inside the dataset
            //u get disconnected from db server
            //datatable---categories---- in/up/de

            DataRow drowFound = ds.Tables["categories"].Rows.Find(newdata.CategoryID);
            drowFound["Catname"] = newdata.CatName.Trim();
            drowFound["Description"] = newdata.CatDesc.Trim();
            ds.Tables["categories"].AcceptChanges();

            string rowstate = null;
            DataRowState state=drowFound.RowState;

            if (state==DataRowState.Modified)
            {
                rowstate = "Modified";
            }
            else
            {
                rowstate = "Unchanged";
            }
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);
            return rowstate;
        }

        public CategoryBAL FindCategory(int catid)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            //DataSet is in-memory copy of your database datatable
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");//dataTable ---- categories---- datatable is inside the dataset
            //u get disconnected from db server
            //datatable---categories---- in/up/de

            DataRow drowFound = ds.Tables["categories"].Rows.Find(catid);
           
            DataRowState state = drowFound.RowState;
           
            CategoryBAL bal = new CategoryBAL();
            if (drowFound != null)
            {

                bal.CategoryID = catid;
                bal.CatName = drowFound["Catname"].ToString();
                bal.CatDesc = drowFound["Description"].ToString();

            }
            return bal;


        }


        public CategoryBAL FindCategory(int catid,out string rowstate)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            //adapter/charger---- connect/disconnect
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            //DataSet is in-memory copy of your database datatable
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "categories");//dataTable ---- categories---- datatable is inside the dataset
            //u get disconnected from db server
            //datatable---categories---- in/up/de

            DataRow drowFound=ds.Tables["categories"].Rows.Find(catid);
            rowstate = null;
            DataRowState state=drowFound.RowState;
            if (state==DataRowState.Unchanged)
            {
                rowstate = "Just finding the row... no updating/deleting/adding";
            }
            CategoryBAL bal = new CategoryBAL();
            if (drowFound!=null)
            {
                
                bal.CategoryID = catid;
                bal.CatName = drowFound["Catname"].ToString();
                bal.CatDesc = drowFound["Description"].ToString();

            }
            return bal;


        }



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
            string rowstate = null;
            DataRow newrow=ds.Tables["categories"].NewRow();
            newrow["Catname"] = category.CatName;
            newrow["Description"] = category.CatDesc;

            DataRowState state = newrow.RowState;
            if (state == DataRowState.Detached)
            {
                rowstate = "Not added to existing rows yet";
            }

            


            ds.Tables["categories"].Rows.Add(newrow);
            ds.Tables["categories"].AcceptChanges();
            
            state=newrow.RowState;
            if (state == DataRowState.Added)
            {
                rowstate = "added to existing rows  in the data table but not commited to the database  server yet";
            }



            



            //SqlDataAdapter is used to submit the changes to the server
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["categories"]);

            //string status = "Done";
            return rowstate;
           




        }

    }
}
