using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Transactions;
namespace TransactionsDemo
{
    public class Products
    {
        public void ShowProducts()
        {
            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=Shopping;Integrated Security=True;MultipleActiveResultSets=true");
            SqlTransaction tran;
            cn.Open();
            tran = cn.BeginTransaction();
            SqlCommand cmd = new SqlCommand("insert into products(prodname) values('coffee')",cn,tran);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("update products set prodname='" + "GingerTea" + "' where prodname='Tea'", cn, tran);
            cmd1.ExecuteNonQuery();
            tran.Commit();
            cn.Close();
            tran.Dispose();
            cn.Dispose();
           
        }

        public void WorkWithScope()
        {
            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=Shopping;Integrated Security=True;MultipleActiveResultSets=true");
            cn.Open();

            using (TransactionScope scope=new TransactionScope())
            {
                SqlCommand cmd = new SqlCommand("insert into products(prodname) values('Nescafe')", cn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("update products set prodname='" + "Cardamon Tea" + "' where prodname='Tea'", cn);
                cmd1.ExecuteNonQuery();
                scope.Complete();
                scope.Dispose();
            }

            
            
        }

        
    }
}
