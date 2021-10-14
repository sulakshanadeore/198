using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstBALLayer;
using System.Data.SqlClient;
using System.Data;
namespace FirstDALLayer
{
    public class CustomerLogin
    {
        public bool ValidateUser(Login data)
        {
            //connectivity to the database
            //validate/check the data with the table data
            //both are equal----- return true
            //not equal ------ return false

            //Database Connectivity ----- name of db server
                                        //----- userid & password to connect to db server
                                        //database name

            //SELECT [dbo].[fn_CustomerValidation] ('reema','reema@123')
            SqlConnection conn = new SqlConnection("server=SPD;Integrated Security=true;database=Shopping");

            string s = "SELECT[dbo].[fn_CustomerValidation](@p_userid,@p_pwd)";

            SqlCommand cmd = new SqlCommand(s,conn);

            cmd.Parameters.AddWithValue("@p_userid", data.Username);
            cmd.Parameters.AddWithValue("@p_pwd", data.Password);
            conn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            dr.Read();
            bool ans=false;
            //array format
            //dr[0]
            if (Convert.ToInt32(dr[0]) == 1)
            {
                ans = true;

            }
            //else
            //{
            //    ans = false;
            //}
            conn.Close();
            conn.Dispose();
            return ans;

        }
    }
}
