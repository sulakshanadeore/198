using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstBALLayer;
using System.Data.SqlClient;
namespace FirstDALLayer
{
  public  class ProductsDAL
    {
        public void InsertProducts(ProductsBAL bal)
        {
            SqlConnection cn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");
            string s = "[dbo].[sp_InsertProducts]";
            SqlCommand cmd = new SqlCommand(s,cn);
            cmd.Parameters.AddWithValue("@p_prodname", bal.Prodname);
            cmd.Parameters.AddWithValue("@p_price", bal.Price);
            cmd.Parameters.AddWithValue("@p_uom", bal.UOM);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();





        }

    }
}
