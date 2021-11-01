using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Description ="this is demo service with helloworld method",Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description ="Hello service")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description ="method for connecting to desired server to show list of records by taking value parameters")]
        public List<Employee> ShowRecords(string servername,string dbname,string tname, string pwd="", string userid="")
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
            b.DataSource = servername;
            b.UserID = userid;
            b.Password = pwd;
            
            if (b.UserID==""||b.Password=="")
            {
                b.IntegratedSecurity = true;//Windows authentication
            }
            SqlConnection cn = new SqlConnection(b.ToString());
            SqlCommand cmd = new SqlCommand("Select * from  " + tname, cn);
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
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
