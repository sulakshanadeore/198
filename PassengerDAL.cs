using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using flightBAL;
using System.Data.SqlClient;
namespace flightDAL
{
    public class PassengerDAL
    {
        public int BookTicket(PassengerBAL passenger)
        {
            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=Shopping;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("[dbo].[BookTicket]",cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@passid", passenger.PassID);
            cmd.Parameters.AddWithValue("@passname", passenger.PassName);
            cmd.Parameters.AddWithValue("@age",passenger.Age);
            cmd.Parameters.AddWithValue("@flightid",passenger.FlightID);

            cmd.Parameters.AddWithValue("@ticketno", passenger.TicketNo);
            cmd.Parameters["@ticketno"].Direction = System.Data.ParameterDirection.Output;
            
            cmd.ExecuteNonQuery();
            int ticketno=Convert.ToInt32(cmd.Parameters["@ticketno"].Value);
            cn.Close();
            cn.Dispose();

            return ticketno;

        }

        //public bool CancelTicket(int id)
        //{

        //}


    }
}
