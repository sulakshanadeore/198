using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int addnos(int i, int j)
        {
            return i + j;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Employee> ShowRecords(string servername, string dbname, string tname, string pwd = "", string userid = "")
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = servername;
            b.UserID = userid;
            b.Password = pwd;

            if (b.UserID == "" || b.Password == "")
            {
                b.IntegratedSecurity = true;//Windows authentication
            }
            SqlConnection cn = new SqlConnection(b.ToString());
            SqlCommand cmd = new SqlCommand("Select * from  " + tname, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //dr-- -is readonly,fwd only stream of data.
            //write the data/edit
            DataTable dt = new DataTable();
            dt.Load(dr);
            List<Employee> emps = new List<Employee>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Employee emp = new Employee();
                emp.Empid = Convert.ToInt32(dt.Rows[i][0]);
                emp.Empname = dt.Rows[i][1].ToString();
                emps.Add(emp);

            }

            cn.Close();
            return emps;
        }
    }
}
